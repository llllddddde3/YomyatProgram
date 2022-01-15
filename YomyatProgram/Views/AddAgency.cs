using System;
using System.Windows.Forms;
using YomyatProgram.Models;

namespace YomyatProgram.Views
{
    public partial class AddAgency : Form
    {
        public AddAgency()
        {
            InitializeComponent();
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تعبئة كافة الحقول", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MyContext context = new MyContext();
            try
            {
                context.Agencies.Add(new Agency { Name = txtName.Text });
                context.SaveChanges();
                MessageBox.Show("تمت الإضافة بنجاح", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
