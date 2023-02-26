using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UserLogin    // namespace PS_43_Tsvety
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FacNumber{ get; set; }
        public UserRoles Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime ActiveTo { get; set; }


        // override here ... to return a string representation of the object that includes all of these properties in a formatted string
        // we need to provide a customized string representation of an object that is specific to our application need
        public override string ToString()
        {
            return Username + ", " 
                + Password + ", "
                + FacNumber + ", "
                + Role + ", "
                + Created + ", "
                + ActiveTo;
        }
    }
}
