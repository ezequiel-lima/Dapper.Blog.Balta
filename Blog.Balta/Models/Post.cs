﻿using Dapper.Contrib.Extensions;

namespace Blog.Balta.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
