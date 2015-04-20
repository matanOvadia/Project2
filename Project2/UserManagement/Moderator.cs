using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class Moderator : ForumMember
    {

        private List<Complaint> complaints;
        public Moderator(String name, String pass, String e_mail) : base(name, pass, e_mail) 
        {
            this.complaints = new List<Complaint>();
        }

        public void addComplaint(Complaint comp)
        {
            this.complaints.Add(comp);
        }
    }
}
