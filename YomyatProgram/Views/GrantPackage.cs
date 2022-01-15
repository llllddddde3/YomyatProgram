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
using YomyatProgram.Utils;

namespace YomyatProgram.Views
{
    public partial class GrantPackage : Form
    {
        MyContext context = new MyContext();
        List<Agency> Agencies;
        public GrantPackage()
        {
            InitializeComponent();
            Agencies = new List<Agency>();
        }

        private void GrantPackage_Load(object sender, EventArgs e)
        {
            var Packages = context.Packages.ToList();
            if (!Packages.Any())
            {
                MessageBox.Show("لا يوجد باقات لديك", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGrant.Enabled = false;
                return;
            }
            Agencies = context.Agencies.ToList();
            comboAgency.DataSource = Agencies;
            comboAgency.DisplayMember = "Name";
            comboAgency.ValueMember = "Id";
            comboPackages.DataSource = Packages;
            comboPackages.DisplayMember = "Title";
            comboPackages.ValueMember = "Id";
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تعبئة كافة الحقول", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var selectedItem = (Package)comboPackages.SelectedItem;
                context.Receipts.Add(new Receipt
                {
                    Title = txtTitle.Text,
                    Value = checkIsDebt.Checked ? (-1) * selectedItem.Price : selectedItem.Price,
                    Date = DateTime.Now,
                    ReceiptType = Models.Enums.ReceiptType.Packages,
                    RelatedId = selectedItem.Id,
                    IsDebt = checkIsDebt.Checked,
                    AccountId = Statics.CurrentAccount.Id,
                    AgencyId = checkIsAgency.Checked ? (int)comboAgency.SelectedValue : null
                });
                context.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkIsAgency_CheckedChanged(object sender, EventArgs e)
        {
            checkIsDebt.Checked = comboAgency.Enabled = lblAgency.Enabled = checkIsAgency.Checked;
            if (checkIsAgency.Checked && !Agencies.Any())
            {
                MessageBox.Show("لا يوجد وكلاء لديك", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGrant.Enabled = false;
                return;
            }
            else
                btnGrant.Enabled = true;
        }
    }
}
