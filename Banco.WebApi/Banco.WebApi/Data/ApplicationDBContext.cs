﻿using Banco.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext ( DbContextOptions options ):base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
