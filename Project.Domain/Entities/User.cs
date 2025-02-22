﻿namespace Project.Domain.Entities
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Role> Roles { get; set; } = new();
        public Guid RefreshToken { get; set; } = Guid.NewGuid();

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void UpdateUser(User newUser)
        {
            Email = newUser.Email;
            Password = newUser.Password;
            Roles = newUser.Roles;
        }

        public void GenerateRefreshToken()
        {
            RefreshToken = Guid.NewGuid();
        }

        public void addRole(Role role)
        {
            Roles.Add(role);
        }
    }
}
