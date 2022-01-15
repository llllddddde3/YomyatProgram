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

namespace YomyatProgram.Views
{
    public partial class Manage : Form
    {
        bool IsPayment;
        int PayId, RecId;
        MyContext context = new();
        public Manage(bool isPayment,int payId,int recId)
        {
            InitializeComponent();
            IsPayment = isPayment;
            PayId = payId;
            RecId = recId;
        }
        private void Manage_Load(object sender, EventArgs e)
        {
          
            if(IsPayment)
            {
                var payment = context.Payments.First(x => x.Id == PayId);
                txtTitle.Text = payment.Title;
                txtValue.Text = payment.Value.ToString();
                txtDesc.Text = payment.Description;
            }
            else
            {
                var Receipt = context.Receipts.First(x => x.Id == RecId);
                txtTitle.Text = Receipt.Title;
                txtValue.Text = Receipt.Value.ToString();
                txtDesc.Text = ReceiptTypeArabic.Titles[(int)Receipt.ReceiptType];
                lblDesOrType.Text = "النوع";
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "هل انت متأكد من الحذف ؟", "إنتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (result != DialogResult.Yes)
                return;
            try
            {
                if (IsPayment)
                {
                    context.Payments.Remove(context.Payments.First(x => x.Id == PayId));
                    context.SaveChanges();
                }
                else
                {
                    context.Receipts.Remove(context.Receipts.First(x => x.Id == RecId));
                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
