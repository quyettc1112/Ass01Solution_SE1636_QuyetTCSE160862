using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;

namespace ProductRepository
{
    public class ProjectRepositoryImpl : IProjectRepository
    {
        public void AddNewProject(ProjectObject project) => ProjectDAO.Instance.AddProject(project);

        public void DeleteProject(string ProjectIDOrName)
        {
            throw new NotImplementedException();
        }

        public ProjectObject GetProjectIDOrName(string ProjectIDOrName) => ProjectDAO.Instance.GetProjectByIDOrName(ProjectIDOrName);


        public IEnumerable<ProjectObject> GetProjectList() => ProjectDAO.Instance.getProjectList;
       

        public void UpdateProject(ProjectObject project)
        {
            throw new NotImplementedException();
        }
    }
}
