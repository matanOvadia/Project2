using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class SuperManager : ForumMember
    {

        private static List<int> memberTypes = new List<int>();

        public SuperManager(String userName, String pass, String e_mail) : base(userName, pass, e_mail) { }

        public Boolean addMemberType(int type)
        {
            if (memberTypes.Contains(type))
                return false;
            memberTypes.Add(type);
            return true;
        }

        public Boolean removeMemberType(int type)
        {
            if (!memberTypes.Contains(type))
                return false;
            memberTypes.Remove(type);
            return true;
        }

        public override void viewMenues()
        {

        }
    }
}
