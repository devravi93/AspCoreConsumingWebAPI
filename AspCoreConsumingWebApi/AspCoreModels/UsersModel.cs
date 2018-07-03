using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AspCoreModels
{
    [DataContract]
    public class UsersModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "EmailId")]
        public string EmailId { get; set; }

        [DataMember(Name = "Mobile")]
        public string Mobile { get; set; }

        [DataMember(Name = "Address")]
        public string Address { get; set; }

        [DataMember(Name = "IsActive")]
        public bool IsActive { get; set; }
    }
}
