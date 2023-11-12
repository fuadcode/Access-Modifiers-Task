using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_Task.Models
{
    class AdminPanel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string userEmail { get; set; }
        public string IpAdress { get; set; }
        public int accessdegree { get; set; }

        private bool Moderator
        {
            get
            {
                return Moderator;
            }
            set
            {
                Moderator = value;
            }
        }
        public bool Adminquery { get; } //Yanlız get var...(ReadOnly)

    }
}
