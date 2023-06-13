
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;


namespace ProjectManagementWinApp_TRANCUONGQUYET
{

    public partial class frmProjectManagement : Form
    {


        // Thêm cái Repositry
        IProjectRepository ProjectRepo = new ProjectRepository();

        //BindingSource
        BindingSource source;

        public frmProjectManagement()
        {
            InitializeComponent();

        }

        private void frmProjectManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

        }

        private void dgvProjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProjectList();
        }



        public void LoadProjectList()
        {
            var project = ProjectRepo.GetProjectList();
            try
            {
                // Lấy dữ liệu của bidingsuou đổ vào cái textbox
                source = new BindingSource();
                source.DataSource = project;

                //. Xóa dữ liệu cũ nếu có
                tbProjectID.DataBindings.Clear();
                tbProjectName.DataBindings.Clear();
                tbEStartDate.DataBindings.Clear();
                tbEEndDAte.DataBindings.Clear();
                tbProjectAddress.DataBindings.Clear();
                tbProjectCity.DataBindings.Clear();
                tbProjectDes.DataBindings.Clear();


                // Đổ dữ liệu mới vào 
                tbProjectID.DataBindings.Add("Text", source, "ProjectID");
                tbProjectName.DataBindings.Add("Text", source, "ProjectName");
                tbEStartDate.DataBindings.Add("Text", source, "EstimatedStartDate");
                tbEEndDAte.DataBindings.Add("Text", source, "EstimatedEndDate");
                tbProjectAddress.DataBindings.Add("Text", source, "ProjectAddress");
                tbProjectCity.DataBindings.Add("Text", source, "ProjectCity");
                tbProjectDes.DataBindings.Add("Text", source, "ProjectDescription");


                // xóa cái dgrid data củ, thay bằng cái mới
                dgvProjectList.DataSource = null;
                dgvProjectList.DataSource = source;

                if (project.Count() == 0)
                {
                    // Cleartext();   
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }


        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

    }
}
