namespace BoxingEvent.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BoxingEvent.Models.BoxingEvent>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BoxingEvent.Models.BoxingEvent context)
        {
            context.GrejnoTelo.AddOrUpdate(
                 g=>g.GrejnoTeloId,
                 new Models.GrejnoTelo { GrejnoTeloId= 1, Naziv = "Kako god", Snaga =740, Tip= "NBT" },
                 new Models.GrejnoTelo { GrejnoTeloId = 2, Naziv = "Kako god1", Snaga = 340, Tip = "NBT1" },
                 new Models.GrejnoTelo { GrejnoTeloId = 3, Naziv = "Kako god2", Snaga = 740, Tip = "NBT" }
               );
        }
    }
}
