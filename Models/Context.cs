﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web2._5.Models;

namespace Web2._5.Models
{
    public class Context : DbContext
    {
        public DbSet<HospitalModel> Hospitals { get; set; }
        public DbSet<LabModel> Labs { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<PatientModel> Patients { get; set; }

        
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public Context() { }

    }
}
