﻿namespace CwkSocial.Api.Contracts.UserProfile.Requests
{
    public record UserProfileUpdateRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? CurrnetCity { get; set; }
    }
}
