﻿namespace ProductManagement.Domain.Arguments.User
{
    public class CreateUserRequest
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
