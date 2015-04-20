using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopForum.DataTypes;

namespace WorkshopForum
{
    public class Storage
    {
        public static List<Forum> forumStorage = new List<Forum>();
        public static List<ForumMember> forumMemberStorage = new List<ForumMember>();
        public static List<Guest> guestStorage = new List<Guest>();
        public static List<Administrator> adminStorage = new List<Administrator>();
        public static List<Moderator> moderatorStorage = new List<Moderator>();
        public static List<SuperManager> superStorage = new List<SuperManager>();
        public static List<State> stateStorage = new List<State>();

        public static void resetAll()
        {
            forumStorage = new List<Forum>();
            forumMemberStorage = new List<ForumMember>();
            guestStorage = new List<Guest>();
            adminStorage = new List<Administrator>();
            moderatorStorage = new List<Moderator>();
            superStorage = new List<SuperManager>();
        }

    }
}
