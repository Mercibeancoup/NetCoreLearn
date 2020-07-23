﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLearn.Models
{
    public class CurrentUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Account { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime LoginTime { get; set; }
    }
}
