using System;

namespace GY.Security.Model
{
     public class Users
     { 

         public Guid UserID { get; set; } 
         public String NickName { get; set;}  
         public String UserName { get; set; }  
         public String UserPwd { get; set; } 
         public String Email { get; set; } 
         public String Phone { get; set; } 
         public int UserType { get; set; }
         public String Describe { get; set; }
         public int Status { get; set; }
         public Guid CreatedBy { get; set; }
         public String CreatedByName { get; set; }  
         public DateTime CreatedTime { get; set; }  
         public Guid ModifiedBy { get; set; }
         public String ModifiedByName { get; set; }
         public DateTime ModifiedTime { get; set; }

     }
}
