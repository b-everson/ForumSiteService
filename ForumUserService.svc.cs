using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ForumUserServiceNS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ForumUserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ForumUserService.svc or ForumUserService.svc.cs at the Solution Explorer and start debugging.
    public class ForumUserService : IForumUserService
    {
        public ForumUser GetForumUser(string name)
        {
            return ForumUserDB.GetUser(name);
        }

        public List<ForumUser> GetForumUsers()
        {
            return ForumUserDB.GetUsers();
        }
    }
}
