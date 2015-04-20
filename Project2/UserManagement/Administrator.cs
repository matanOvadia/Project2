using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class Administrator : ForumMember
    {

        public Administrator(String name, String pass, String e_mail) : base(name, pass, e_mail) { }

        public Administrator(ForumMember forumMember) : base(forumMember.getName(), forumMember.getPassword(), forumMember.getE_Mail()) { }
    }

}
