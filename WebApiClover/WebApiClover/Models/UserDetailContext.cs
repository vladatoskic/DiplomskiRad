using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClover.Models;

namespace WebApiClover.Models
{
    public class UserDetailContext : DbContext 
    {

        public UserDetailContext(DbContextOptions<UserDetailContext> options) : base(options)
        {


        }

        public DbSet<UserDetail> UserDetails { get; set; }


        public DbSet<RentService> RentService { get; set; }

        public DbSet<FlightInfo> FlightsInfo { get; set; }

        public DbSet<CarInfo> CarInfo { get; set; }

        public DbSet<WebApiClover.Models.CompanyAbout> CompanyAbout { get; set; }

        public DbSet<WebApiClover.Models.FlightInfo2> FlightInfo2 { get; set; }

        public DbSet<WebApiClover.Models.OfficeDetail> OfficeDetail { get; set; }

        public DbSet<WebApiClover.Models.ReservationDetails> ReservationDetails { get; set; }

        public DbSet<WebApiClover.Models.Friends> Friends { get; set; }

        public DbSet<WebApiClover.Models.Seat> Seat { get; set; }

        public DbSet<WebApiClover.Models.FlightReservation> FlightReservation { get; set; }

        public DbSet<WebApiClover.Models.Rate> Rate { get; set; }

        public DbSet<WebApiClover.Models.flightRate> flightRate { get; set; }
    }
}
