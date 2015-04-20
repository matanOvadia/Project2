using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
   public interface Bridge
   { 
        void addForum(String forumName, Administrator admin);
        void addSubForum(Forum forum, String subForumName);
        void addDiscussion(SubForum subForum, String title, String content, ForumMember forumMember);
        void addReply(Message message, SubForum subForum, String content, ForumMember messageOwner);
   }
}
