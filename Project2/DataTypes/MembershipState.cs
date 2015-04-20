using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum.DataTypes
{
    public abstract class MembershipState
    {
        public abstract Boolean isCanBeAdmin();
        public abstract Boolean isCanBeSuperManager();
    }
}
