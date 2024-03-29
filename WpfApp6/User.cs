﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? ImageUrl { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }


        public override string ToString()
         => @$"{Firstname} - {Lastname} - {Gender} - {Phone} - {Email} - {Address}";
    }
}
