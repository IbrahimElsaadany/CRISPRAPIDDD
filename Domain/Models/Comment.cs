﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string Content { get; set; }
    }
}