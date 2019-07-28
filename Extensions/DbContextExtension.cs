using System;
using System.Linq.Expressions;
using dropdown.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dropdown.Extensions
{
    public static class DbContextExtensions
    {
        public static void ModelBuilderExtension(this ModelBuilder builder)
        {
            foreach (var model in builder.Model.GetEntityTypes())
            {
                builder.Entity(model.Name).Property<DateTime>("CreatedAt");
                builder.Entity(model.Name).Property<DateTime>("UpdatedAt").HasDefaultValue(DateTime.Now);
                builder.Entity(model.Name).Property<Char>("RecStatus").HasDefaultValue('A');

                var t = model.ClrType;

                if (typeof(ISoftDelete).IsAssignableFrom(t))
                {
                    builder.Entity(model.Name).Property<bool?>("IsSoftDelete").HasDefaultValue(true);
                }
            }
        }
    }
}