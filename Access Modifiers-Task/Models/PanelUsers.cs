using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_Task.Models
{
    class PanelUsers:AdminPanel
    {
        public PanelUsers(string UserName, string Password ,bool Adminquery, string userEmail, bool Moderator)
        {

                         this.UserName = UserName;
                         this.Password = Password;
                         this.Adminquery = true;
                         this.userEmail = "fuad.iskenderov20@gmail.com";
                         this.Moderator = false;
                         

        }
    }
}
