using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopForum;

namespace Bridges
{
    public class RealBridge : Bridge
    {
        public RealBridge()
        { }

        public static void Main(String[] args)
        {  }

        public Boolean addForum(String newForum, String forumAdministrator)
        {
            return ForumHandler.addForum(newForum, forumAdministrator);
        }

        public Boolean removeForum(Forum forum)
        {
            return ForumHandler.removeForum(forum);
        }

        public Boolean addSubForum(String forumName, String subForumName, String moderator)
        {
            return ForumHandler.addSubForum(forumName, subForumName, moderator);
        }

        public Boolean addDiscussion(String forumName, String subForumName, String discTitle, String content, String member)
        {
            return ForumHandler.addDiscussion(forumName, subForumName, discTitle, content, member);
        }

        public Boolean addReply(String forumName, String subForumName, String discussion, String title, String content, String forumMember)
        {
            return ForumHandler.addReply(forumName, subForumName, discussion, title, content, forumMember);
        }

        public Boolean addAdministrator(Administrator admin)
        {
            return UserHandler.addAdministrator(admin);
        }

        public Boolean registerForumMember(String newMemberName, String pass, String e_mail)
        {
            return UserHandler.registerForumMember(newMemberName, pass, e_mail);
        }

        public Guest enterAsGuest()
        {
            return UserHandler.enterAsGuest();
        }

        public User memberLogin(String userName, String pass)
        {
            return UserHandler.memberLogin(userName, pass);
        }

        public Boolean removeGuest(Guest guest)
        {
            return UserHandler.removeGuest(guest);
        }

        public User getUser(String userName)
        {
            return UserHandler.getUser(userName);
        }

        public Administrator getAdmin(String userName)
        {
            return UserHandler.getAdmin(userName);
        }
    }
}
