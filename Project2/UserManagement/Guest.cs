using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class Guest : User
    {
        private static int guestNumber = 0;
        private int gustNum;
    
        public Guest()
        {
           this.gustNum= guestNumber++;
        }
    }
}
