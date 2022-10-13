using CuentaRegresiva.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuentaRegresiva.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //TABLAS DE LA BASE DE DATOS
        public DbSet<School> Schools { get; set; }

        public DbSet<Table> Tables { get; set; }
    }
}
