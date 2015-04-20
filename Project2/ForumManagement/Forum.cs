using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
   public class Forum
    {
       private List<SubForum> subForums;
       private Administrator admin;
       private String forumName;
       private int numberOfModerators;

       public Forum(String forumName, Administrator admin) {
           this.admin = admin;
           this.forumName = forumName;
           this.subForums=new List<SubForum>();
           this.numberOfModerators = 1;
       }

        public void addSubForum(SubForum subForum)
       {
           this.subForums.Add(subForum);
       }

       public SubForum getSubForum(String subForum)
       {
           foreach (SubForum element in subForums)
               if (element.getName() == subForum)
                   return element;
           return null;
       }

       public String getName()
       {
           return this.forumName;
       }

       public List<SubForum> getSubForums()
       {
           return this.subForums;
       }

       public int getNumberOfModerators()
       {
           return this.numberOfModerators;
       }

       public void setNumberOfModerators(int modNum)
       {
           if (modNum > 0)
               this.numberOfModerators = modNum;
       }
    }
}
