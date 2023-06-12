
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octopus.Client.Repositories;


namespace ProjectManagementWinApp_TRANCUONGQUYET
{
    public partial class frmProjectManagement : Form
    {

        // Thêm cái Repositry
        IProjectRepository projectRepository = new ProductRepository();




        public frmProjectManagement()
        {
            InitializeComponent();

        }

        private void frmProjectManagement_Load(object sender, EventArgs e)
        {

        }

        private void dgvProjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
