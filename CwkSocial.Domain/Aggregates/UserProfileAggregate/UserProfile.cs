using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkSocial.Domain.Aggregates.UserProfileAggregate
{
    public class UserProfile
    {
        public Guid Id { get; private set; }
        public string IdentityId { get; private set; }
        public BasicInfo BasicInfo { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        private UserProfile()
        {
        }

        public static UserProfile Create(string identityId, BasicInfo basicInfo)
        {
            //TO DO: add validation, error handling strategies, error notification strategies
            return new UserProfile
            {
                IdentityId = identityId,
                BasicInfo = basicInfo,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }

        //public methods
        public void UpdateBasicInfo(BasicInfo newBasicInfo)
        {
            BasicInfo = newBasicInfo;
            LastModified = DateTime.UtcNow;
        }
    }
}
