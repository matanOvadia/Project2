using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class ForumHandler
    {

	public ForumHandler(){
	}	

        public static Boolean addForum(String newForum, String forumAdmin) {
            Forum forum;
            if ((forum = getForum(newForum)) != null)
            {
                Console.WriteLine("Error : forum " + newForum + " already exists");
                System.Threading.Thread.Sleep(3000);
                return false;
            }
            Administrator forumAdministrator = UserHandler.getAdmin(forumAdmin);
            if (forumAdministrator == null)
            {
                Console.WriteLine("Error : no such user " + forumAdministrator.getName());
                System.Threading.Thread.Sleep(3000);
                return false;
            }
            Storage.forumStorage.Add(new Forum(newForum, forumAdministrator));
            return true;
        }

        public static Boolean removeForum(Forum forum)
        {
            foreach (Forum element in Storage.forumStorage)
                if (element.getName().Equals(forum.getName()))
                {
                    Storage.forumStorage.Remove(element);
                    return true;
                }
            Console.WriteLine("Error : forum " + forum.getName() + " not found");
            return false;
        }

        public static Boolean addSubForum(String forumName, String subForumName, String moderator)
        {
            Forum forum = getForum(forumName);
            if (forum != null && forum.getSubForum(subForumName) == null)
            {
                Moderator mod = UserHandler.getModerator(moderator);
                if (moderator == null)
                {
                    Console.WriteLine("Error : user " + moderator  + " isn't a forum member");
                    return false;
                }
                
                forum.addSubForum(new SubForum(subForumName, mod));
                return true;
            }
            else
            {
                Console.WriteLine("Error");
                return false;
            }
        }

        public static Boolean addDiscussion(String forumName, String subForumName, String discTitle, String content, String member)
        {
            Forum forum;
            if ((forum = ForumHandler.getForum(forumName)) == null)
            {
                Console.WriteLine("Error : invalid forum");
                return false;
            }
            SubForum subForum = forum.getSubForum(subForumName);
            if (subForum == null)
            {
                Console.WriteLine("Error : invalid sub forum");
                return false;
            }
            ForumMember forumMember = (ForumMember)UserHandler.getUser(member);
            subForum.addDiscussion(new Discussion(discTitle, new NewMessage(discTitle, content, forumMember)));
            return true;
            //subForum.addDiscussion(new Discussion(title, new NewMessage(title, content, forumMember)));
        }
         
        public static Boolean addReply(String forumName, String subForumName, String discussion, String title, String content, String forumMember)
        {
            Forum forum;
            if ((forum = getForum(forumName)) == null)
            {
                Console.WriteLine("Error : invalid forum");
                return false;
            }
            SubForum subForum;
            if ((subForum = forum.getSubForum(subForumName)) == null)
            {
                Console.WriteLine("Error : invalid sub forum");
                return false;
            }
            Discussion disc;
            if ((disc = subForum.getDiscussion(discussion)) == null)
            {
                Console.WriteLine("Error : invalid Discussion");
                return false;
            }
            ForumMember member = (ForumMember)UserHandler.getUser(forumMember);
            disc.getMessage().addReply(new ReplyMessage(title, content, member));
            return true;
        }

        /*public static Boolean view()
        {
            Console.WriteLine("Forums : ");
            foreach (Forum forum in Storage.forumStorage)
                Console.WriteLine("Forum " + forum.getName());
            Console.WriteLine("Please choose a forum");
            String choice = Console.ReadLine();
            Forum chosenForum = getForum(choice);
            if (chosenForum == null)
            {
                Console.WriteLine("Error : invalid forum");
                return false;
            }
            Console.WriteLine("Forum " + choice + " sub forums : ");
            foreach (SubForum sub in chosenForum.getSubForums())
                Console.WriteLine(sub.getName());
            Console.WriteLine("Please choose a sub forum");
            String subChoice = Console.ReadLine();
            SubForum chosenSubForum = chosenForum.getSubForum(subChoice);
            if (chosenSubForum == null)
            {
                Console.WriteLine("Error : invalid sub forum");
                return false;
            }
            return true;
        }
        */

        public static Forum getForum(String forum)
        {
            foreach (Forum element in Storage.forumStorage)
                if (element.getName() == forum)
                    return element;
            return null;
        }

	    public static void printForums()
	    {
		    for (int i = 0; i < Storage.forumStorage.Count; i++)
		    {
		    	Console.WriteLine("Forum " + i + " : " + Storage.forumStorage.ElementAt(i).getName());
		    }
	}
    }
}
