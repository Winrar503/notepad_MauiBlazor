using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string NamePhoto { get; set; }

        //[NotMapped]
        //public int Top_Aux { get; set; }
        //public Notes Notes { get; set; }
    }
}

