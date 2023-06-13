using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class ProjectRepository : IProjectRepository
    {
        public void AddNewProject(ProjectObject project) => ProjectDAO.Instance.AddProject(project);
      

        public void DeleteProject(string ProjectID) => ProjectDAO.Instance.DeleteProject(ProjectID);
       

        public ProjectObject GetProjectByIDOrName(string ProjectID) => ProjectDAO.Instance.GetProjectByID(ProjectID);


        public IEnumerable<ProjectObject> GetProjectList() => ProjectDAO.Instance.getProjectList;


        public void UpdateProject(ProjectObject project) => ProjectDAO.Instance.UpdateProject(project);
       
    }
}
