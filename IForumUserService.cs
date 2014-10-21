using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ForumUserServiceNS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IForumUserService" in both code and config file together.
    [ServiceContract]
    public interface IForumUserService
    {
        [OperationContract]
        ForumUser GetForumUser(string name);

    }

    [DataContract]
    public class ForumUser
    {
        public ForumUser()
        {

        }

        public ForumUser(int userID, string userName, string password, string firstname, string lastname, string email, string phone, string street1, string street2, string city, string state, string zip, int permissions)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.Password = password;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Street1 = street1;
            this.Street2 = street2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Permissions = permissions;
        }

        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string UserName { get; set; } //validation created

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string FirstName { get; set; } //validation created

        [DataMember]
        public string LastName { get; set; } //validation created

        [DataMember]
        public string Email { get; set; } //validation created


        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Street1 { get; set; }

        [DataMember]
        public string Street2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; } //validation created

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public int Permissions { get; set; }
    }
}
