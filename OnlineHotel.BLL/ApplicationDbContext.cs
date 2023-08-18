﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHotel.BLL
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions Options) :
            base(Options)
        {
            
        }
        public DbSet<ApplicationUser> ApplicationUsers{ get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
    }
}
