using HitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetAll();
        Project GetById(int projectId);
        void Create(Project project);
        void Delete(int id);
        void Update(Project project);
        Project SetTodaysDate();
        void Save();

    }
}
