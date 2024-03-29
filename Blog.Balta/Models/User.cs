﻿using Dapper.Contrib.Extensions;

namespace Blog.Balta.Models
{
    //É necessario para que o dapper busque por "User" e não por "Users"
    [Table("[User]")]
    public class User
    {
        public User()
            => Roles = new List<Role>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)]//para ele não escrever isso no insert
        public List<Role> Roles { get; set; }
    }
}
