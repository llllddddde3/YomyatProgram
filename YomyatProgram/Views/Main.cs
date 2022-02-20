using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using YomyatProgram.Models;
using YomyatProgram.Models.ViewModels;
using YomyatProgram.Utils;

namespace YomyatProgram.Views
{
    public partial class Main : Form
    {
        MyContext context = new MyContext();
        Login Login;
        public Main(Login login)
        {
            InitializeComponent();
            Login = login;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = DateTime.Now.ToString();
                lblName.Text = Statics.CurrentAccount.FullName;
                btnSearch_Click(sender, e);
            }
            catch
            {
                txtBalance.Text = "0";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            List<MainVM> Views = new();
            double balance = context.Receipts.Where(x => !x.IsDebt).Sum(s => s.Value) - context.Payments.Sum(s => s.Value);
            Views = GetViews(date, Views);
            grdAccounting.DataSource = Views;
            if (!radioDaily.Checked)
                grdAccounting.Columns["UserName"].Visible = false;
            grdAccounting.Columns["Date"].Visible = false;
            grdAccounting.Columns["Id"].Visible = false;
            grdAccounting.Columns["Title"].HeaderText = "العنوان";
            grdAccounting.Columns["Value"].HeaderText = "القيمة";
            grdAccounting.Columns["Type"].HeaderText = "النوع";
            grdAccounting.Columns["UserName"].HeaderText = "اسم المدخل";
            txtBalance.Text = balance.ToString();
        }

        private List<MainVM> GetViews(DateTime date, List<MainVM> Views)
        {
            double sumDailyPayments, sumDailyRecipts, netProfit;
            if (radioDaily.Checked)
            {
                var recipts = context.Receipts.Where(x => !x.IsDebt && x.Date.Date == date.Date).ToList();
                var payments = context.Payments.Where(x => x.Date.Date == date.Date);
                int i = 1;
                foreach (var item in recipts)
                    Views.Add(new MainVM
                    {
                        Id = item.Id,
                        No = i++,
                        Title = item.Title,
                        Type = "مقبوضات",
                        Value = item.Value.ToString(),
                        Date = item.Date,
                        UserName = Statics.CurrentAccount.FullName
                    });
                foreach (var item in payments)
                    Views.Add(new MainVM
                    {
                        Id = item.Id,
                        No = i++,
                        Title = item.Title,
                        Type = "مدفوعات",
                        Value = item.Value.ToString(),
                        Date = item.Date,
                        UserName = Statics.CurrentAccount.FullName
                    });
                Views = Views.OrderBy(x => x.Date).ToList();
                sumDailyPayments = payments.Sum(x => x.Value);
                sumDailyRecipts = recipts.Sum(x => x.Value);
            }
            else if (radioMonthly.Checked)
            {
                var recipts = context.Receipts.Where(x => !x.IsDebt && x.Date.Month == date.Month && x.Date.Year == date.Year).ToList();
                var payments = context.Payments.Where(x => x.Date.Month == date.Month && x.Date.Year == date.Year);
                int i = 1;
                foreach (var item in recipts)
                    Views.Add(new MainVM
                    {
                        Id = item.Id,
                        No = i++,
                        Title = item.Title,
                        Type = "مقبوضات",
                        Value = item.Value.ToString(),
                        Date = item.Date,
                        UserName = Statics.CurrentAccount.FullName
                    });
                foreach (var item in payments)
                    Views.Add(new MainVM
                    {
                        Id = item.Id,
                        No = i++,
                        Title = item.Title,
                        Type = "مدفوعات",
                        Value = item.Value.ToString(),
                        Date = item.Date,
                        UserName = Statics.CurrentAccount.FullName
                    });
                Views = Views.OrderBy(x => x.Date).ToList();
                Views.Add(new MainVM
                {
                    No = i++,
                    Title = "مجموع المقبوضات",
                    Type = "مقبوضات",
                    Value = recipts.Sum(x => x.Value).ToString()
                });
                Views.Add(new MainVM
                {
                    No = i++,
                    Title = "مجموع المدفوعات",
                    Type = "مدفوعات",
                    Value = payments.Where(x => !x.IsSalaries).Sum(x => x.Value).ToString()
                });
                Views.Add(new MainVM
                {
                    No = i++,
                    Title = "الرواتب",
                    Type = "مدفوعات",
                    Value = payments.Where(x => x.IsSalaries).Sum(x => x.Value).ToString()
                });
                sumDailyPayments = payments.Sum(x => x.Value);
                sumDailyRecipts = recipts.Sum(x => x.Value);
            }
            else
            {
                var recipts = context.Receipts.Where(x => !x.IsDebt && x.Date.Year == date.Year).ToList();
                var payments = context.Payments.Where(x => x.Date.Year == date.Year);
                int i;
                for (i = 1; i < 5; i++)
                {
                    double value = 0;
                    string title = "";
                    if (i == 1)
                    {
                        title = "الربع الأول";
                        value = recipts.Where(x => x.Date.Month == 1 || x.Date.Month == 2 || x.Date.Month == 3).Sum(x => x.Value);
                    }
                    else if (i == 2)
                    {
                        title = "الربع الثاني";
                        value = recipts.Where(x => x.Date.Month == 4 || x.Date.Month == 5 || x.Date.Month == 6).Sum(x => x.Value);
                    }
                    else if (i == 3)
                    {
                        title = "الربع الثالث";
                        value = recipts.Where(x => x.Date.Month == 7 || x.Date.Month == 8 || x.Date.Month == 9).Sum(x => x.Value);
                    }
                    else if (i == 4)
                    {
                        title = "الربع الرابع";
                        value = recipts.Where(x => x.Date.Month == 10 || x.Date.Month == 11 || x.Date.Month == 12).Sum(x => x.Value);
                    }
                    Views.Add(new MainVM
                    {
                        No = i,
                        Title = title,
                        Type = "مقبوضات",
                        Value = value.ToString()
                    });
                }
                for (; i < 9; i++)
                {
                    double value = 0;
                    string title = "";
                    if (i == 5)
                    {
                        title = "الربع الأول";
                        value = payments.Where(x => x.Date.Month == 1 || x.Date.Month == 2 || x.Date.Month == 3).Sum(x => x.Value);
                    }
                    else if (i == 6)
                    {
                        title = "الربع الثاني";
                        value = payments.Where(x => x.Date.Month == 4 || x.Date.Month == 5 || x.Date.Month == 6).Sum(x => x.Value);
                    }
                    else if (i == 7)
                    {
                        title = "الربع الثالث";
                        value = payments.Where(x => x.Date.Month == 7 || x.Date.Month == 8 || x.Date.Month == 9).Sum(x => x.Value);
                    }
                    else if (i == 8)
                    {
                        title = "الربع الرابع";
                        value = payments.Where(x => x.Date.Month == 10 || x.Date.Month == 11 || x.Date.Month == 12).Sum(x => x.Value);
                    }
                    Views.Add(new MainVM
                    {
                        No = i,
                        Title = title,
                        Type = "مدفوعات",
                        Value = value.ToString()
                    });
                }
                sumDailyPayments = payments.Sum(x => x.Value);
                sumDailyRecipts = recipts.Sum(x => x.Value);
            }
            netProfit = sumDailyRecipts - sumDailyPayments;
            txtSumPayments.Text = sumDailyPayments.ToString();
            txtSumReceipts.Text = sumDailyRecipts.ToString();
            txtNetProfit.Text = netProfit.ToString();
            return Views;
        }
        private void grdAccounting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (!radioDaily.Checked)
                return;
            try
            {
                var mainVM = (MainVM)grdAccounting.Rows[e.RowIndex].DataBoundItem;
                bool isPay = mainVM.Type == "مدفوعات";
                Manage manage;
                if (isPay)
                    manage = new Manage(isPay, mainVM.Id.Value, 0);
                else
                    manage = new Manage(isPay, 0, mainVM.Id.Value);
                var result = manage.ShowDialog();
                if (DialogResult.OK == result)
                    btnSearch_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ToolStripMenuItemAddAgency_Click(object sender, EventArgs e)
        {
            AddAgency addAgency = new AddAgency();
            addAgency.ShowDialog();
        }

        private void ToolStripMenuItemAddPackage_Click(object sender, EventArgs e)
        {
            AddPackage addPackage = new AddPackage();
            addPackage.ShowDialog();
        }

        private void ToolStripMenuItePayment_Click(object sender, EventArgs e)
        {
            AddPayment addPayment = new AddPayment();
            var result = addPayment.ShowDialog();
            if (DialogResult.OK != result)
                btnSearch_Click(sender, e);
        }

        private void ToolStripMenuItemPayOffDebts_Click(object sender, EventArgs e)
        {
            payOffDebts payOffDebts = new payOffDebts();
            var result = payOffDebts.ShowDialog();
            if (DialogResult.OK != result)
                btnSearch_Click(sender, e);
        }

        private void ToolStripMenuItemAddRecipts_Click(object sender, EventArgs e)
        {
            AddRecipt addRecipt = new AddRecipt();
            var result = addRecipt.ShowDialog();
            if (DialogResult.OK != result)
                btnSearch_Click(sender, e);
        }

        private void ToolStripMenuItemAddPost_Click(object sender, EventArgs e)
        {
            AddPost addPost = new AddPost();
            var result = addPost.ShowDialog();
            if (DialogResult.OK != result)
                btnSearch_Click(sender, e);
        }

        private void ToolStripMenuItemGrantPackage_Click(object sender, EventArgs e)
        {
            GrantPackage grantPackage = new GrantPackage();
            var result = grantPackage.ShowDialog();
            if (DialogResult.OK != result)
                btnSearch_Click(sender, e);
        }

        private void ToolStripMenuItemAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }

        private void ToolStripMenuItemLogOut_Click(object sender, EventArgs e)
        {
            Statics.CurrentAccount = null;
            Login.Show();
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (Double.TryParse(txtBalance.Text, NumberStyles.Currency, null, out amount))
            {
                txtBalance.Text = amount.ToString("C");
            }

        }
    }
}
