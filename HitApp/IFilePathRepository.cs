using HitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp
{
    public interface IFilePathRepository
    {
        IEnumerable<FilePath> GetAll();
        FilePath GetById(int id);
    }
}
