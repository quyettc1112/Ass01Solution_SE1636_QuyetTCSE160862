using System;
using System.Buffers;
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
    public partial class frmProjectDetail : Form
    {
        public frmProjectDetail()
        {
            InitializeComponent();
        }

        // Dùng Inteface để sử dụng các hàm thao tác với Collection
        public IProjectRepository ProjectRepository { get; set; }


        public bool InsertOrUpdate { get; set; } // nếu False thì sẽ Insert, nếu True thì sẽ update

        // Hàm này có thể dùng để lấy dữ liệu của project người dủng chọn
        public ProjectObject Project { get; set; }



        // Hàm check nhập thiếu dử liệu
        private bool ValidateInputs(ProjectObject P)
        {
            if (string.IsNullOrEmpty(P.ProjectID) ||
                string.IsNullOrEmpty(P.ProjectName) ||
                string.IsNullOrEmpty(P.ProjectDescription) ||
                string.IsNullOrEmpty(P.EstimatedEndDate) ||
                string.IsNullOrEmpty(P.EstimatedStartDate) ||
                string.IsNullOrEmpty(P.ProjectAddress) ||
                string.IsNullOrEmpty(P.ProjectCity))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }


        //-Hàm nay để thêm mới Project hoặc Update Project
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var P = new ProjectObject
                {
                    ProjectID = mkProjectID.Text,
                    ProjectName = tbProjectName.Text,
                    ProjectCity = tbProjectCTy.Text,
                    EstimatedEndDate = dtEED.Value.ToString("MM/dd/yyyy"),
                    EstimatedStartDate = dtESD.Value.ToString("MM/dd/yyyy"),
                    ProjectAddress = tbProjectAddress.Text,
                    ProjectDescription = tbProjectDes.Text,
                };



                if (ValidateInputs(P) == true)
                {

                    if (InsertOrUpdate == false)
                    {
                        // Tạo mới
                        ProjectRepository.AddNewProject(P);
                        DialogResult d;
                        d = MessageBox.Show($"Bạn sẽ thêm Project {P.ProjectName}", "Quản lý thông tin Project - Thêm Dữ Liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                        if (d == DialogResult.OK)
                        {
                            DialogResult = DialogResult.OK;
                        }

                    }
                    else
                    {
                        ProjectRepository.UpdateProject(P);
                        DialogResult d;
                        d = MessageBox.Show($"Bạn sẽ cập nhật Project {P.ProjectName}", "Quản lý thông tin Project - Cập Nhật Dữ Liêu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                        if (d == DialogResult.OK)
                        {
                            DialogResult = DialogResult.OK;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Project" : "Update a Project");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Load dữ liệu của Project
        private void frmProjectDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                mkProjectID.Text = Project.ProjectID;
                tbProjectName.Text = Project.ProjectName;
                tbProjectDes.Text = Project.ProjectDescription;
                dtESD.Text = Project.EstimatedStartDate;
                dtEED.Text = Project.EstimatedEndDate;
                tbProjectAddress.Text = Project.ProjectAddress;
                tbProjectCTy.Text = Project.ProjectCity;

            }
        }
    }
}
