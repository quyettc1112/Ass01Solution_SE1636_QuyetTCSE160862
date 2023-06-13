using BusinessObject;
using DevExpress.Utils.CommonDialogs.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace DataAccessObject
{
    public class ProjectDAO // CRUD với data bằng Collection
    {
        // Tạo Collection một List Project
        private static List<ProjectObject> ProjectList = new List<ProjectObject>() {
            new ProjectObject{ProjectID = "PJ01", ProjectName = "PRN", EstimatedStartDate = "01/01/2023", EstimatedEndDate = "02/01/2023",
            ProjectDescription = "PRN AssignMent", ProjectAddress = "TX25, Q12", ProjectCity = "HCM"
            },
            new ProjectObject{ProjectID = "PJ02", ProjectName = "SWP", EstimatedStartDate = "01/01/2023", EstimatedEndDate = "02/01/2023",
            ProjectDescription = "SWP AssignMent", ProjectAddress = "Thanh Xuan", ProjectCity = "HN"
            },
            new ProjectObject{ProjectID = "PJ03", ProjectName = "SWR", EstimatedStartDate = "01/01/2023", EstimatedEndDate = "02/01/2023",
            ProjectDescription = "SWR AssignMent", ProjectAddress = "Tri Ton", ProjectCity = "AG"
            }
        };



        // Sử dụng SingleTOn Pattern cho ProjectDAO
        // đảm bảo rằng một class chỉ có một instance duy nhất

        private static ProjectDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProjectDAO() {}  // bước này để không cho phép tạo toán tử new
        public static ProjectDAO Instance // tạo đối tượng duy nhất cho phép truy cập từ bên ngoài 
        {
            get { 
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProjectDAO();
                    }
                    return instance;
                } 
            }
        } // end 


        // trả về 1 list Project 
        public List<ProjectObject> getProjectList => ProjectList;



        // Tìm project dựa vào ID hoặc name
        public ProjectObject GetProjectByIDOrName(String projectID) {
            ProjectObject projectObject = ProjectList.SingleOrDefault(id => id.ProjectID == projectID);
            if (projectObject != null)
            {
                projectObject = ProjectList.SingleOrDefault(name => name.ProjectName == projectID);
                return projectObject;
            }
            else
            {
                throw new Exception($"Project ID = {projectObject.ProjectID} is not found");
            }

        }


        // ADD new Project vào Project List
        public void AddProject (ProjectObject projectObject)
        {
            // Check Dupplicated
            ProjectObject Po = GetProjectByIDOrName(projectObject.ProjectID);
            if (Po == null)
            {
                ProjectList.Add(projectObject);
            }
            else {
                throw new Exception($"Project ID = {projectObject.ProjectID} is already exists");
            }
        }

        // Delete một project dựa vào ID
        public void DeleteProject(String projectID) { 
            
            ProjectObject  p = GetProjectByIDOrName(projectID);
            if (p != null) { 
                ProjectList.Remove(p);          
            }
            else
            {
                throw new Exception("Project Not Found!!!");
            }
        
        }




    }
}
