using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopForum.DataTypes;

namespace WorkshopForum
{
    public class UserHandler
    {
        public static User currentUser = null;
        public static Boolean addAdministrator(Administrator admin)
        {
            if (!(currentUser is SuperManager) && !(currentUser is Administrator))
            {
                Console.WriteLine("Error : only administrator/super-manager can add new administrator");
                return false;
            }
            Storage.adminStorage.Add(admin);
            return true;
        }

        public static Boolean registerForumMember(String newMemberName, String pass, String e_mail)
        {
            if (getUser(newMemberName) != null)
            {
                Console.WriteLine("Error : user name " + newMemberName + " taken");
                return false;
            }
            if (!Policy.isValidPassword(pass)) 
                return false;
            ForumMember newMember = new ForumMember(newMemberName, pass, e_mail);
            Storage.forumMemberStorage.Add(newMember);
            return true;
        }

        public static Guest enterAsGuest()
        {
            Guest guest = new Guest();
            Storage.guestStorage.Add(guest);
            return guest;
        }

        public static ForumMember memberLogin(String userName, String pass)
        {
            ForumMember user;
            if ((user = UserHandler.getUser(userName)) == null)
            {
                Console.WriteLine("Error : Wrong user name");
                return null;
            }
            if (pass != user.getPassword())
            {
                Console.WriteLine("Error : Wrong password for user " + userName);
                return null;
            }
            return user;
        }

        public static Boolean removeGuest(Guest guest)
        {
            Storage.guestStorage.Remove(guest);
            return true;
        }

        public static ForumMember getUser(String userName)
        {
            foreach (ForumMember element in Storage.forumMemberStorage)
            {
                if (element.getName() == userName)
                    return element;
            }
            return null;
        }

        public static Administrator getAdmin(String userName)
        {
            foreach (Administrator element in Storage.adminStorage)
            {
                if (element.getName() == userName)
                    return element;
            }
            return null;
        }

        public static Boolean AppointForumMemberToAdministrator(ForumMember forumMember)
        {
            if (Policy.isSilverMember(forumMember, forumMember.getDaysOfMembership()
                , forumMember.getNumOfPublishedMessages()))
            {
                Storage.forumMemberStorage.Remove(forumMember);
                Storage.adminStorage.Add(new Administrator(forumMember));
                return true;
            }
            else
            {
                Console.Out.WriteLine(forumMember.getName() + " is not silver member, than can't becmoe administrator");
                return false;
            }
        }
        
        public static Boolean submitComplaint(SubForum sub, String submitter, String title, String content, String moderator)
        {
            Boolean writtenMessage = haveWrittenMessage(sub, (ForumMember)getUser(submitter), getModerator(moderator));
            if (!writtenMessage)
                return false;
            else getModerator(moderator).addComplaint(new Complaint(submitter, title, content));
            return true;
        }

        public static Moderator getModerator(String userName)
        {
            foreach (Moderator element in Storage.moderatorStorage)
            {
                if (element.getName() == userName)
                    return element;
            }
            return null;
        }

        private static Boolean haveWrittenMessage(SubForum sub, ForumMember submitter, Moderator mod)
        {
            if (sub.getSubForumModerator(mod.getName()) == null)
                return false;
            foreach (Discussion disc in sub.getDiscussions())
            {
                //if (disc.getMessage().getMessageOwner().Equals(sub) && 
                foreach (ReplyMessage rep in disc.getMessage().getReplies())
                    if (rep.getMessageOwner().Equals(sub.getName()))
                    {
                        return true;
                    }
             }
            return false; ;
        }

        public static void addMembershipState(String nicknameState, int mininumNumOfMembershipDays, int minimumHouresOfLogin, int minimumNumOfPublishedMessages,
            bool isCanBeAdmin, bool isCanBeSuperManager)
        {
            Storage.stateStorage.Add(new State(nicknameState, mininumNumOfMembershipDays, minimumHouresOfLogin, minimumNumOfPublishedMessages,
            isCanBeAdmin,isCanBeSuperManager));
        }

        public static State determineState(int numOfMembershipDays, int houresOfLogin, int numOfPublishedMessages)
        {
            List<State> SortedList = Storage.stateStorage.OrderBy(s => s.getMinimumNumOfMembershipDays()).ToList();
            
            foreach (State s in Storage.stateStorage)
            {
                if ((s.getMinimumNumOfMembershipDays() <= numOfMembershipDays)
                    && (s.getMinimumHouresOfLogin() <= houresOfLogin)
                    && (s.getMinimumNumOfPublishedMessages() <= numOfPublishedMessages))
                    return s;
            }

            Console.Out.WriteLine("no maching state");
            return null;

        }
    }
}
