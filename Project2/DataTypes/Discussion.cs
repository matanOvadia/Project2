using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
   public class Discussion
    {
        String title;
        NewMessage firstMessage;

        public Discussion(String title, NewMessage firstMessage)
        {
        	this.title = title;
        	this.firstMessage = firstMessage;
        }

       public String getTitle()
        {
            return this.title;
        }

        public NewMessage getMessage()
        {
            return this.firstMessage;
        }
    }
}
