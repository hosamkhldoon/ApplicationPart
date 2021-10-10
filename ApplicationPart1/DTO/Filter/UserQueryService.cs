using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class UserQueryService
    {
       
        public int IndexConditionID { get; set; }
        public int IndexConditionName { get; set; }
        public int IndexConditionDescription { get; set; }
        public int IndexConditionCreationDate { get; set; }
        public int IndexConditionClassID { get; set; }
        public int IndexConditionLoginName { get; set; }
        public int IndexConditionLastModifier { get; set; }
       

        public string SeconedValueID { get; set; }
        public string SeconedValueName { get; set; }
        public string SeconedValueDescription { get; set; }
        public string SeconedValueCreationDate { get; set; }
        public string SeconedValueClassID { get; set; }
        public string SeconedValueLoginName { get; set; }
        public string SeconedValueLastModifier { get; set; }


        public string QID { get; set; }
        public string QClassID { get; set; }
        public string QName { get; set; }
        public string QCreationDate { get; set; }
        public string QDescription { get; set; }
        public string QLoginName { get; set; }
        public string QLastModifier { get; set; }
      

   
        public int IDSqlServerOrElsticSearch { get; set; }
   



    



      
    }
}
