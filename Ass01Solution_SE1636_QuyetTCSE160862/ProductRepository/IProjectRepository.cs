using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepository
{
    internal interface IProjectRepository
    {
        IEnumerable<ProjectObject> GetProjectList();
        ProjectObject GetProjectIDOrName(String ProjectIDOrName);
        void AddNewProject (ProjectObject project);
        void DeleteProject (String ProjectIDOrName);
        void UpdateProject (ProjectObject project);
    }
}
