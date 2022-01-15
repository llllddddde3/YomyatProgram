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

namespace YomyatProgram.Views
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPass.Text == string.Empty || txtUserName.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تعبئة كافة الحقول", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                MyContext context = new MyContext();
                context.Accounts.Add(new Account
                {
                    FullName = txtName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPass.Text
                });
                context.SaveChanges();
                MessageBox.Show("تمت الإضافة بنجاح", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = txtUserName.Text = txtPass.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
