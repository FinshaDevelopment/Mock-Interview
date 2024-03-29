﻿using MockInterview.Domain.Commons;

namespace MockInterview.Domain.Entities.Users
{
    public class Interviewer : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
