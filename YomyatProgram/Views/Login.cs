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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            var account = context.Accounts
                .FirstOrDefault(x => x.UserName.ToLower() == txtUsername.Text.ToLower() && x.Password == txtPass.Text);
            if (account is not null)
            {
                Statics.CurrentAccount = account;
                txtPass.Text = txtUsername.Text = string.Empty;
                Main main = new(this);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("خطأ في اسم المستخدم أو كلمة المرور", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
