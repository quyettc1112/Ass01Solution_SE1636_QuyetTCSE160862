using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProjectRepository
    {
        IEnumerable<ProjectObject> GetProjectList();

        ProjectObject GetProjectByIDOrName(String ProjectID);

        void AddNewProject (ProjectObject project);
        void DeleteProject (String ProjectID);
        void UpdateProject (ProjectObject project);

    }
}
