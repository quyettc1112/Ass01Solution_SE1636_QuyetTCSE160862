
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
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


        // Hàm này để lấy dữ liệu được chọn 
        private ProjectObject GetProjectObject()
        {
            ProjectObject p = null;
            try
            {
                p = new ProjectObject
                {
                    ProjectID = tbProjectID.Text,
                    ProjectName = tbProjectName.Text,
                    ProjectDescription = tbProjectDes.Text,
                    EstimatedStartDate = tbEStartDate.Text,
                    EstimatedEndDate = tbEEndDAte.Text,
                    ProjectAddress = tbProjectAddress.Text,
                    ProjectCity = tbProjectCity.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Project");

            }
            return p;
        }

        //Hàm này tự động xóa dữ liệu cũ
        private void Cleartext()
        {
            tbProjectID.Text = string.Empty;
            tbProjectName.Text = string.Empty;
            tbProjectDes.Text = string.Empty;
            tbEEndDAte.Text = string.Empty;
            tbEStartDate.Text = string.Empty;
            tbProjectAddress.Text = string.Empty;
            tbProjectCity.Text = string.Empty;
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

                if (project.Count() == 0) // đếm xem còn project nào trong drig hay ko, nếu còn thi btnDelete.Enabled = true;
                {
                    Cleartext();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có thật sự muốn thoát hay không?", "Quản lý thông tin Project - Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                this.Close();

            }
        } // End Close

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            try
            {
                ProjectObject p = GetProjectObject();
                if (p != null)
                {
                    d = MessageBox.Show("Bạn có thật sự muốn xóa hay không?", "Quản lý thông tin Project - Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (d == DialogResult.OK)
                    {
                        ProjectRepo.DeleteProject(p.ProjectID);
                        LoadProjectList();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Project Error");
            }
        } // End Delete


        // Hàm này dùng để thêm thông tin cho
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProjectDetail f = new frmProjectDetail()
            {
                Text = "ADD New Project",
                InsertOrUpdate = false, // Chỉnh sang Hàm Insert
                ProjectRepository = ProjectRepo
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadProjectList();


            }
            


        }





    }
}
