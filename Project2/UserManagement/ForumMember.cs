using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopForum.DataTypes;

namespace WorkshopForum
{
    public class ForumMember : User
    {
        private int type;


        private String name;
        private String pass;
        private String e_mail;
        private MembershipState stateOfMembership;
        private DateTime timeOfRegistration;
        private DateTime timeOfLogin;
        private bool isLogedIn;
        private int numOfPublishedMessages;

        public ForumMember(String name, String pass, String e_mail)
        {
            this.name = name;
            this.pass = pass;
            this.e_mail = e_mail;
            timeOfRegistration = DateTime.Today;
            this.numOfPublishedMessages=0;
        }

        //          ~ Top level methods~
        public State getMembershipState()
        {
            int numOfMembershipDays = (this.timeOfRegistration - DateTime.Today).Days;
            int houresOfLogin = (this.timeOfLogin - DateTime.Now).Hours;

            return UserHandler.determineState(numOfMembershipDays, houresOfLogin, numOfPublishedMessages);
        }

        //          ~ Low level methods~

        public void setLogedInTrue()
        { 
            this.isLogedIn = true;
            timeOfLogin = DateTime.Now;
        }

        public void setLogedInFalse()
        {
            this.isLogedIn = false;
        }

        public void numOfPublishedMessagesPlusPlus() 
        {
            this.numOfPublishedMessages++;
        }

        public String getName()
        {
            return this.name;
        }

        public String getPassword()
        {
            return this.pass;
        }

        public String getE_Mail()
        {
            return this.e_mail;
        }  
         
        public override void viewMenues()
        {  }
       
        internal int getDaysOfMembership()
        {
            throw new NotImplementedException();
        }

        internal int getNumOfPublishedMessages()
        {
            throw new NotImplementedException();
        }
    }
}
