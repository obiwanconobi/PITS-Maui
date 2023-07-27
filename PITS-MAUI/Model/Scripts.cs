using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITS_MAUI.Model
{
    public class Scripts
    {
            public string scriptId { get; set; }
            public string machineType { get; set; }
            public int permissionLevel { get; set; }
            public string scriptName { get; set; }
            public string script { get; set; }
            public DateTime creationDate { get; set; }
            public string createdBy { get; set; }
            public DateTime editedDate { get; set; }
            public string editedBy { get; set; }
            public int active { get; set; }
       
    }
}
