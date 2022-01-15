using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YomyatProgram.Models;
using YomyatProgram.Models.Enums;
using YomyatProgram.Utils;

namespace YomyatProgram.Views
{
    public partial class AddPost : Form
    {
        MyContext context = new MyContext();
        List<Agency> Agencies;
        public AddPost()
        {
            InitializeComponent();
            Agencies = new List<Agency>();
        }
        private void AddPost_Load(object sender, EventArgs e)
        {
            Agencies = context.Agencies.ToList();
            comboAgency.DataSource = Agencies;
            comboAgency.DisplayMember = "Name";
            comboAgency.ValueMember = "Id";
        }
        private void btnAddPost_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == string.Empty || txtPrice.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تعبئة كافة الحقول", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double value;
            try
            {
                value = Convert.ToDouble(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية في حقل قيمة السعر", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                context.Receipts.Add(new Receipt
                {
                    Title = txtTitle.Text,
                    Value = checkIsDebt.Checked ? (-1) * value : value,
                    Date = DateTime.Now,
                    IsDebt = checkIsDebt.Checked,
                    ReceiptType = ReceiptType.Post,
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
                MessageBox.Show("لا يوجد باقات لديك", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddPost.Enabled = false;
                return;
            }
            else
                btnAddPost.Enabled = true;
        }

      
    }
}
