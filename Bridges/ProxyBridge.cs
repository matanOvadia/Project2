using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopForum;

namespace Bridges
{
    public class ProxyBridge : Bridge
    {
        private Bridge real;

        public ProxyBridge() { }

        public void setRealBridge(Bridge real)
        {
            this.real = real;
        }

        public Boolean addForum(String forumName, String forumAdministrator)
        {
            if (this.real != null)
                return real.addForum(forumName, forumAdministrator);
            return false;
        }

        public Boolean addSubForum(String forum, String subForumName, String moderator)
        {
            if (this.real != null)
                return real.addSubForum(forum, subForumName, moderator);
            return false;
        }

        public Boolean addDiscussion(String forumName, String subForumName, String discTitle, String content, String member)
        {
            if (this.real != null)
                return real.addDiscussion(forumName, subForumName, discTitle, content, member);
            return false;
        }

        public Boolean addReply(String forumName, String subForumName, String discussion, String title, String content, String forumMember)
        {
            if (this.real != null)
                return real.addReply(forumName, subForumName, discussion, title, content, forumMember);
            return false;
        }

        public Boolean removeForum(Forum forum)
        {
            if (this.real != null)
                return real.removeForum(forum);
            return false;    
        }

        public Boolean addAdministrator(Administrator admin)
        {
            if (this.real != null)
                return real.addAdministrator(admin);
            return false;
        }

        public Boolean registerForumMember(String newMemberName, String pass, String e_mail)
        {
            if (this.real != null)
                return real.registerForumMember(newMemberName, pass, e_mail);
            return false;
        }
        public Guest enterAsGuest()
        {
            if (this.real != null)
                return real.enterAsGuest();
            return null;
        }

        public User memberLogin(String userName, String pass)
        {
            if (this.real != null)
                return real.memberLogin(userName, pass);
            return null;
        }

        public Boolean removeGuest(Guest guest)
        {
            if (this.real != null)
                return real.removeGuest(guest);
            return false;
        }

        public User getUser(String userName)
        {
            if (this.real != null)
                return real.getUser(userName);
            return null;
        }

        public Administrator getAdmin(String userName)
        {
            if (this.real != null)
                return real.getAdmin(userName);
            return null;
        }
}

    
}
