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
       // Review GetById(int id);
    }
}
