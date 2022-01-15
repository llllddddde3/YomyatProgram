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
    public partial class AddPackage : Form
    {
        public AddPackage()
        {
            InitializeComponent();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == string.Empty || txtCount.Text == string.Empty || txtPrice.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تعبئة كافة الحقول", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double value;
            int count;
            try
            {
                value = Convert.ToDouble(txtPrice.Text);
                count = Convert.ToInt32(txtCount.Text);
            }
            catch
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية في حقل قيمة السعر او عدد المنشورات", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MyContext context = new MyContext();
            try
            {
                context.Packages.Add(new Package
                {
                    Title = txtTitle.Text,
                    Price = value,
                    PostsCount = count
                });
                context.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCount.Text = txtPrice.Text = txtTitle.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
