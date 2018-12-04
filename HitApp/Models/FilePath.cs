using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class FilePath
    {
        public int FilePathId { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public FileType FileType { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
