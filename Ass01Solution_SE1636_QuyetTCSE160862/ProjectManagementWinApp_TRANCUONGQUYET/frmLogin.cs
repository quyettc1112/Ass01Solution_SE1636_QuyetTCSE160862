using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.IO;



namespace ProjectManagementWinApp_TRANCUONGQUYET
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConfiguration builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var email = builder["AdminAccount:Email"];
            var password = builder["AdminAccount:Password"];
            

            if (txtEmail.Text.Equals(email) && txtPassword.Text.Equals(password))
            {
                Hide();
                frmProjectManagement f = new frmProjectManagement();
                f.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Fail", "Notification");

        }


    }
}
