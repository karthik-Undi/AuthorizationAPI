﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AuthorizationAPI.Model
{
    public partial class Userdetails
    {
        public int Userid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
