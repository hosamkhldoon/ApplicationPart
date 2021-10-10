using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ContactReadService
    {
       
        public string NameFileUser { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string TypeContact { get; set; }
        public DateTime LastFileDate { get; set; }
    }
}
