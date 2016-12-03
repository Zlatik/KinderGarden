using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinderGArden.DBClasses;
namespace KinderGArden.Mvc
{
    public enum userType { Editor, Viewer };


    class UserType
    {

        public userType type;
        public admin currentAdmin;
        public void setType(userType e, string uname, string pass)
        {
            if (e == userType.Viewer)
            {
                type = userType.Viewer;
                currentAdmin = new admin(0, "User", "no");
            }
            else
            {
                currentAdmin = new admin(0, "Admin", "12345");
            }
        }
    }
}