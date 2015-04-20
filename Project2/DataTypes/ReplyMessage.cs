using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
   public class ReplyMessage : Message
    {
        public ReplyMessage(String title, String content, ForumMember messageOwner) : base(title, content, messageOwner) { }

       
        public override String getTitle()
        {
        	return this.title;
        }

        public override void addReply(ReplyMessage newReply)
        {
            Console.WriteLine("error : ReplyMessage class");
        }
    }
}
 
