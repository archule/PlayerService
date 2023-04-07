using PlayerService.Data;
using PlayerService.Models;

namespace PlayerService.Data{
    public static class PrepDb {

        public static void PrepPopulation(IApplicationBuilder app) {
            using(var serviceScope = app.ApplicationServices.CreateScope()) {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }


        }

        private static void SeedData(AppDbContext context) {
            if(!context.Players.Any()) {
                Console.WriteLine("--> sending data");
                context.Players.AddRange(new Player(){FirstName="Tim", LastName="Tebow", College="Florida"},
                                           new Player(){FirstName="Peyton", LastName="Manning", College="Tennessee"});
                                           context.SaveChanges(); 
            } else {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}