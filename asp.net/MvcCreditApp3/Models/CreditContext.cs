using Microsoft.AspNet.Identity.EntityFramework;
using MvcCreditApp3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCreditApp3.Models
{
    public class CreditContext : ApplicationDbContext
    {
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}