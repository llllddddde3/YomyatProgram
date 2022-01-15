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
using YomyatProgram.Utils;

namespace YomyatProgram.Views
{
    public partial class AddRecipt : Form
    {
        public AddRecipt()
        {
            InitializeComponent();
        }

        private void AddRecipt_Load(object sender, EventArgs e)
        {
            List<object> list = new();
            list.Add(new { Id = (int)ReceiptType.Contracts,
                Title = ReceiptTypeArabic.Titles[(int)ReceiptType.Contracts]
            });
            list.Add(new { Id = (int)ReceiptType.Others,
                Title = ReceiptTypeArabic.Titles[(int)ReceiptType.Others]
            });
            comboType.DataSource = list;
            comboType.DisplayMember = "Title";
            comboType.ValueMember = "Id";
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == string.Empty || txtPrice.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تعبئة كافة الحقول", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTitle.Text == string.Empty)
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
            var result = MessageBox.Show(this, "هل انت متأكد من تسديد دفعة بهذه المعلومات ؟", "إنتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (result != DialogResult.Yes)
                return;
            try
            {
                MyContext context = new MyContext();
                context.Receipts.Add(new Receipt
                {
                    Title = txtTitle.Text,
                    Value = value,
                    ReceiptType = (ReceiptType)comboType.SelectedValue,
                    Date = DateTime.Now,
                    AccountId = Statics.CurrentAccount.Id
                });
                context.SaveChanges();
                MessageBox.Show("تمت تسديد الدفعة", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Text = txtPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
