using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopForum;

namespace Bridges
{
    public interface Bridge
    {
        Boolean addForum(String newForum, String forumAdministrator);

        Boolean removeForum(Forum forum);

        Boolean addSubForum(String forumName, String subForumName, String moderator);

        Boolean addDiscussion(String forumName, String subForumName, String discTitle, String content, String member);

        Boolean addReply(String forumName, String subForumName, String discussion, String title, String content, String forumMember);
        Boolean addAdministrator(Administrator admin);

        Boolean registerForumMember(String newMemberName, String pass, String e_mail);

        Guest enterAsGuest();

        User memberLogin(String userName, String pass);

        Boolean removeGuest(Guest guest);

        User getUser(String userName);

        Administrator getAdmin(String userName);
    }
}
