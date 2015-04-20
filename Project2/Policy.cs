using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class Policy
    {
        private static Policy policy = null;
        private static Boolean haveCap = false;
        private static Boolean haveNums = false;
        private static int secLevel = 4;
        private static int minimumSilverDaysOfMembership;
        private static int minimumSilverNumOfPublishedMessages;

        public static void setPasswordProperties(Boolean caps, Boolean syms, Boolean nums)
        {
            haveCap = caps;
            haveNums = nums;
        }

        internal static bool isSilverMember(ForumMember forumMemeber, int daysOfMembership
         , int numOfPublishedMessages)
        {
            if ((daysOfMembership >= minimumSilverDaysOfMembership)
                && (numOfPublishedMessages >= minimumSilverNumOfPublishedMessages))
                return true;
            else return false;
        }

        public static Boolean setSecLevel(int level)
        {
            if (level > 4)
                secLevel = level;
            else
                return false;
            return true;
        }

        public static Boolean isValidPassword(String pass)
        {
            if (!haveCap && !haveNums)
                return true;
            char[] passArr = pass.ToCharArray();
            if (passArr.Length != secLevel)
            {
                Console.WriteLine("Error : password must be " + secLevel + " characters long");
                return false;
            }
            Boolean capsValid = false, numValid = false;
            for (int i = 0; i < pass.Length && !capsValid && !numValid; i++)
            {
                if ((int)passArr[i] >= 48 && (int)passArr[i] <= 57)
                    numValid = true;
                else if ((int)passArr[i] >= 65 && (int)passArr[i] <= 90)
                    capsValid = true;
            }
            if ((capsValid || !haveCap)  && (numValid || !haveNums)) 
                return true;
            Console.WriteLine("Error : invalid password");
            return false;
        }
    }
}
