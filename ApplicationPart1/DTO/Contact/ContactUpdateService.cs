using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ContactUpdateService
    {
        public string CreationDateFileUser { get; set; }
        public string NameFileUser { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string TypeContact { get; set; }
        public string Password { get; set; }
        public DateTime LastFileDate { get; set; }

    }
}
