using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Data.ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Data.ApplicationDbContext>>()))
            {
                seedSides(context);


                context.SaveChanges();
            }


            void seedSides(Data.ApplicationDbContext context) {
                // Look for any Side.
                /*
                if (context.Side.Any())
                {
                    return;   // DB has been seeded
                }
                */
                foreach (var entity in context.Side)
                    context.Side.Remove(entity);

                context.Side.AddRange(
                    new Side
                    {
                        Name = "Attacker",
                        Icon = "/media/general/attacker.PNG",
                    },
                    new Side
                    {
                        Name = "Defender",
                        Icon = "/media/general/defender.PNG",
                    }
                );
            }

        }
    }
}
