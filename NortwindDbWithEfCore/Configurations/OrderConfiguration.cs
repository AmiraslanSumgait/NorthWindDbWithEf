using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NortwindDbWithEfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindDbWithEfCore.Configurations
{
    public class OrderConfiguration:IEntityTypeConfiguration<Order>
    {
        
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => new { o.CustomerId, o.EmployeeId });
        }

    }
}
