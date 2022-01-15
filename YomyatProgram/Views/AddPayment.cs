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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == string.Empty || txtValue.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تعبئة كافة الحقول", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double value;
            try
            {
               value = Convert.ToDouble(txtValue.Text);
            }
            catch 
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية في حقل قيمة الدفعة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show(this, "هل انت متأكد من اضافة دفعة بهذه المعلومات ؟", "إنتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (result != DialogResult.Yes)
                return;
            try
            {
                MyContext context = new MyContext();
                context.Payments.Add(new Payment
                {
                    Title = txtTitle.Text,
                    Value = value,
                    Description = txtDesc.Text,
                    Date = DateTime.Now,
                    IsSalaries = checkIsSal.Checked,
                    AccountId = Statics.CurrentAccount.Id,
                });
                context.SaveChanges();
                MessageBox.Show("تمت اضافة دفعة", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkIsSal_CheckedChanged(object sender, EventArgs e)
        {
            if(checkIsSal.Checked)
            {
                txtTitle.Text = "رواتب";
                txtTitle.ReadOnly = true;
            } 
            else
            {
                txtTitle.Text = "";
                txtTitle.ReadOnly = false;
            }    
        }
    }
}
