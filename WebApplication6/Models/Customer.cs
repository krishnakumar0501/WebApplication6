﻿namespace WebApplication6.Models
{
    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }
        public Location Location { get; set; }
    }
}
