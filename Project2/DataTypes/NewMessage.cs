using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class NewMessage : Message
    {
    	private List<ReplyMessage> replies;

        public NewMessage(String title, String content, ForumMember messageOwner) : base(title, content, messageOwner) 
        { 
        	this.replies = new List<ReplyMessage>();
        }

        public override void addReply(ReplyMessage newReply)
        {
        	this.replies.Add(newReply);
        }

        public List<ReplyMessage> getReplies()
        {
            return this.replies;
        }

     
    }
}
 
