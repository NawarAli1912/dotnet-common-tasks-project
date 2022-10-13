using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkSocial.Domain.Aggregates.UserProfileAggregate
{
    public class BasicInfo
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string EmailAddress { get; private set; }
        public string Phone { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string CurrnetCity { get; private set; }


        private BasicInfo()
        {
        }

        // Factory method
        public static BasicInfo Create(
            string firstName, string lastName, string emailAddress,
            string phone, DateTime dateOfBirth, string currentCity)
        {
            //TO DO: add validation, error handling strategies, error notification strategies
            return new BasicInfo
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                DateOfBirth = dateOfBirth,
                Phone = phone,
                CurrnetCity = currentCity
            };
        }
    }
}
