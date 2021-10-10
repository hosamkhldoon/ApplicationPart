using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ContactQueryService
    {
    
     
        public int IndexConditionName { get; set; }
       
        public string QType { get; set; }
        public string QName { get; set; }
  
        public int IDSqlServerOrElsticSearch { get; set; }
    }
}
