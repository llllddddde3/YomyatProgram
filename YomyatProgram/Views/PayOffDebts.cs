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
        public string GetRelated(int relatedId) => context.Packages.First(x => x.Id == relatedId).Title;
        public payOffDebts()
        {
            InitializeComponent();
        }

        private void payOffDebts_Load(object sender, EventArgs e)
        {
           var receipts = context.Receipts.Where(x => x.IsDebt)
                .Include(x=>x.Agency)
                .Include(x=>x.Account)
                .AsNoTracking().ToList();
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
                    AgencyName = item.AgencyId.HasValue ? item.Agency.Name : "-",
                    Date = item.Date.ToShortDateString(),
                    UserName = item.Account.FullName
                });
            }
            grdDebt.DataSource = receiptVMs;
            grdDebt.Columns["Id"].Visible = false;
            grdDebt.Columns["Title"].HeaderText = "العنوان";
            grdDebt.Columns["Value"].HeaderText = "القيمة";
            grdDebt.Columns["ReceiptType"].HeaderText = "النوع";
            grdDebt.Columns["Related"].HeaderText = "نوع الباقة";
            grdDebt.Columns["AgencyName"].HeaderText = "اسم الوكيل";
            grdDebt.Columns["Date"].HeaderText = "التاريخ";
            grdDebt.Columns["UserName"].HeaderText = "اسم المدخل";
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
                var debt = context.Receipts.First(x => x.Id == selectedId);
                debt.Value *= (-1);
                debt.IsDebt = false;
                debt.AccountId = Statics.CurrentAccount.Id;
                context.SaveChanges();
                MessageBox.Show("تمت تسديد الدفعة", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                payOffDebts_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
