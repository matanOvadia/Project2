using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum.DataTypes
{
    public class State : MembershipState
    {
        //name of the state: gold, silver, regular...
        private String nicknameState;

        // who can be belongs to this state?
        private int mininumNumOfMembershipDays;
        private int minimumHouresOfLogin;
        private int minimumNumOfPublishedMessages;
        
        // what he can do?
        private bool isCanBeAdmin1;
        private bool isCanBeSuperManager1;


        public State(String nicknameState, int mininumNumOfMembershipDays, int minimumHouresOfLogin, int minimumNumOfPublishedMessages,
            bool isCanBeAdmin,bool isCanBeSuperManager)
        {
            this.nicknameState = nicknameState;

            this.minimumHouresOfLogin = minimumHouresOfLogin;
            this.minimumNumOfPublishedMessages = minimumNumOfPublishedMessages;
            this.mininumNumOfMembershipDays = mininumNumOfMembershipDays;

            this.isCanBeAdmin1 = isCanBeAdmin;
            this.isCanBeSuperManager1 = isCanBeSuperManager;

        }

        public int getMinimumNumOfMembershipDays() 
        {
            return this.mininumNumOfMembershipDays;
        }

        public override bool isCanBeAdmin()
        {
            return isCanBeAdmin1;
        }

        public override bool isCanBeSuperManager()
        {
            return isCanBeSuperManager1;
        }

        internal int getMinimumHouresOfLogin()
        {
            return this.minimumHouresOfLogin;
        }

        internal int getMinimumNumOfPublishedMessages()
        {
            return this.minimumNumOfPublishedMessages;
        }

        public String getNickname()
        {
            return this.nicknameState;
        }
    }
}
