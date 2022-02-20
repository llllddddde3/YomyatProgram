using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YomyatProgram.Models;
using YomyatProgram.Models.Enums;
using YomyatProgram.Models.ViewModels;
using YomyatProgram.Utils;

namespace YomyatProgram.Views
{
    public partial class payOffDebts : Form
    {
        MyContext context = new MyContext();
        int selectedId;
        List<Receipt> receipts = new List<Receipt>();
        public string GetRelated(int relatedId) => context.Packages.First(x => x.Id == relatedId).Title;
        public payOffDebts()
        {
            InitializeComponent();
        }

        private void payOffDebts_Load(object sender, EventArgs e)
        {
            receipts = context.Receipts.Where(x => x.IsDebt)
                 .Include(x => x.Agency)
                 .Include(x => x.Account)
                 .AsNoTracking().ToList();
            if (!receipts.Any())
            {
                btnFilter.Enabled = btnPayOffAll.Enabled = false;
                return;
            }
            FillFilter(receipts);
            FillGrid(receipts);
        }

        private void FillGrid(List<Receipt> receipts)
        {
            List<ReceiptVM> receiptVMs = new List<ReceiptVM>();
            foreach (var item in receipts)
            {
                receiptVMs.Add(new ReceiptVM
                {
                    Id = item.Id,
                    Title = item.Title,
                    Value = item.Value * (-1),
                    ReceiptType = ReceiptTypeArabic.Titles[(int)item.ReceiptType],
                    Related = item.RelatedId != 0 && item.ReceiptType == ReceiptType.Packages ? GetRelated(item.RelatedId) : "-",
                    AgencyId = item.AgencyId.HasValue ? item.AgencyId.Value : default,
                    AgencyName = item.AgencyId.HasValue ? item.Agency.Name : "-",
                    Date = item.Date.ToShortDateString(),
                    UserName = item.Account.FullName
                });
            }
            txtSumDebts.Text = (-1 * receipts.Sum(x => x.Value)).ToString();
            grdDebt.DataSource = receiptVMs;
            grdDebt.Columns["Id"].Visible = false;
            grdDebt.Columns["AgencyId"].Visible = false;
            grdDebt.Columns["Title"].HeaderText = "العنوان";
            grdDebt.Columns["Value"].HeaderText = "القيمة";
            grdDebt.Columns["ReceiptType"].HeaderText = "النوع";
            grdDebt.Columns["Related"].HeaderText = "نوع الباقة";
            grdDebt.Columns["AgencyName"].HeaderText = "اسم الوكيل";
            grdDebt.Columns["Date"].HeaderText = "التاريخ";
            grdDebt.Columns["UserName"].HeaderText = "اسم المدخل";
            btnFilter.Enabled = btnPayOffAll.Enabled = true;
        }

        private void FillFilter(List<Receipt> receipts)
        {
            var agencies = new List<Agency>();
            agencies.Add(new Agency { Id = 0, Name = "الكل" });
            foreach (var item in receipts.Where(x => x.AgencyId.HasValue))
            {
                if (!agencies.Any(x => x.Id == item.AgencyId))
                    agencies.Add(item.Agency);
            }
            comboAgency.DataSource = agencies;
            comboAgency.DisplayMember = "Name";
            comboAgency.ValueMember = "Id";
            var filterReceipts = new List<string>();
            filterReceipts.Add("الكل");
            filterReceipts.AddRange(receipts.Select(x => x.Title).Distinct().ToList());
            ComboTitles.DataSource = filterReceipts;
        }

        private void grdDebt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var debt = (ReceiptVM)grdDebt.Rows[e.RowIndex].DataBoundItem;
            txtTitle.Text = debt.Title;
            selectedId = debt.Id;
            txtValue.Text = debt.Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == string.Empty || txtValue.Text == string.Empty)
            {
                MessageBox.Show("الرجاء اختيار دفعة لتسديدها", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double value;
            try
            {
                value = Convert.ToDouble(txtValue.Text);
            }
            catch
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية في حقل القيمة المسددة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show(this, "هل انت متأكد من تسديد دفعة بهذه المعلومات ؟", "إنتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (result != DialogResult.Yes)
                return;
            try
            {
                PayOff(selectedId);
                txtTitle.Text =txtValue.Text = string.Empty;
                MessageBox.Show("تمت تسديد الدفعة", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                payOffDebts_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PayOff(int id)
        {
            var debt = context.Receipts.First(x => x.Id == id);
            debt.Value *= (-1);
            debt.IsDebt = false;
            debt.AccountId = Statics.CurrentAccount.Id;
            context.SaveChanges();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!receipts.Any())
                return;
            int agencyId = (int)comboAgency.SelectedValue;
            if (agencyId == 0 && ComboTitles.Text == "الكل")
            {
                FillGrid(receipts);
            }
            else if (agencyId != 0 && ComboTitles.Text == "الكل")
            {
                FillGrid(receipts.Where(x => x.AgencyId == agencyId).ToList());
            }
            else if (agencyId == 0 && ComboTitles.Text != "الكل")
            {
                FillGrid(receipts.Where(x => x.Title == ComboTitles.Text).ToList());
            }
            else if (agencyId != 0 && ComboTitles.Text != "الكل")
            {
                FillGrid(receipts.Where(x => x.AgencyId == agencyId && x.Title == ComboTitles.Text).ToList());
            }
        }

        private void btnPayOffAll_Click(object sender, EventArgs e)
        {
            if (!receipts.Any())
                return;
            var result = MessageBox.Show(this, "هل انت متأكد من تسديد الدفعات جميعها ؟", "إنتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (result != DialogResult.Yes)
                return;
            try
            {
                var allReceipts = (List<ReceiptVM>)grdDebt.DataSource;
                foreach (var item in allReceipts)
                    PayOff(item.Id);
                MessageBox.Show("تمت تسديد الدفعات", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                payOffDebts_Load(sender, e);
            }
            catch (Exception)
            {
            }
        }
    }
}
