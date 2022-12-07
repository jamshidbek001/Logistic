// =================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
// =================================================

using System;

namespace LogisticUz.Api.Controllers.Foundations.Customers
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public GenderType Gender { get; set; }
    }
}