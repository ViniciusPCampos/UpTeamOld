using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace UPTEAM.Presentation.Web.Providers
{
    public class GerencialMemberShipUser : MembershipUser
    {
        public GerencialMemberShipUser(long userId, string userName, string login)
           : base(Membership.Provider.Name, userName, userId, login, null, null, true, true, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now)
        {

        }
    }
}