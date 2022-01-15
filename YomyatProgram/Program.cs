using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YomyatProgram.Models;
using YomyatProgram.Views;

namespace YomyatProgram
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyContext context = new MyContext();
            context.Database.EnsureCreated();
            if(!context.Accounts.Any())
            {
                context.Accounts.Add(new Account
                {
                    FullName = "Anas Alaswad",
                    UserName = "anas",
                    Password = "anasnouralaswad"
                });
                context.SaveChanges();
            }
            Application.Run(new Login());
        }
    }
}
