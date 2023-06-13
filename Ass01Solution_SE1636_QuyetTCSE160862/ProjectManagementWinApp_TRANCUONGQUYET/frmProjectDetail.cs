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

       

        //--------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                var P = new ProjectObject
                {
                    ProjectID = tbProjectID.Text,
                    ProjectName = tbProjectName.Text,
                    ProjectCity = tbProjectCTy.Text,
                    EstimatedEndDate = mEEndDate.Text,
                    EstimatedStartDate = mEStartDate.Text,
                    ProjectAddress = tbProjectAddress.Text,
                    ProjectDescription = tbProjectDes.Text,
                };
                if (InsertOrUpdate == false) {
                    // Tạo mới
                    ProjectRepository.AddNewProject(P);
                
                }




            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }


    }
}
