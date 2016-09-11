namespace CareGo.Web.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CareGo.Web.Models.CareGoDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CareGo.Web.Models.CareGoDataContext";
        }

        protected override void Seed(CareGo.Web.Models.CareGoDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            // insert cities

            //context.Add(new City { Name = "Vancouver", Details = "" });
            //context.Add(new City { Name = "Victoria", Details = "" });
            //context.Add(new City { Name = "Kelowna", Details = "" });
            //context.Add(new City { Name = "Kamloops", Details = "" });
            //context.Add(new City { Name = "Calgary", Details = "" });
            //context.Add(new City { Name = "Edmonton", Details = "" });
            //context.Add(new City { Name = "Toronto", Details = "" });

            //context.SaveChanges();

            // get individual IDs

            //var vancouverId = 0;
            //var victoriaId = 0;
            //var kelownaId = 0;
            //var kamloopsId = 0;
            //var calgaryId = 0;
            //var edmontonId = 0;
            //var torontoId = 0;

            //vancouverId = context.GetId("Vancouver");
            //victoriaId = context.GetId("Victoria");
            //kelownaId = context.GetId("Kelowna");
            //kamloopsId = context.GetId("Kamloops");
            //calgaryId = context.GetId("Calgary");
            //edmontonId = context.GetId("Edmonton");
            //torontoId = context.GetId("Toronto");

            //// insert vancouver routes

            //context.AddRoutesById(vancouverId, victoriaId);
            //context.AddRoutesById(vancouverId, kelownaId);
            //context.AddRoutesById(vancouverId, kamloopsId);
            //context.AddRoutesById(vancouverId, calgaryId);
            //context.AddRoutesById(vancouverId, edmontonId);
            //context.AddRoutesById(vancouverId, torontoId);

            //// insert victoria routes

            //context.AddRoutesById(victoriaId, vancouverId);
            //context.AddRoutesById(victoriaId, kelownaId);
            //context.AddRoutesById(victoriaId, kamloopsId);
            //context.AddRoutesById(victoriaId, calgaryId);
            //context.AddRoutesById(victoriaId, edmontonId);
            //context.AddRoutesById(victoriaId, torontoId);

            //// insert kelowna routes

            //context.AddRoutesById(kelownaId, vancouverId);
            //context.AddRoutesById(kelownaId, victoriaId);
            //context.AddRoutesById(kelownaId, kamloopsId);
            //context.AddRoutesById(kelownaId, calgaryId);
            //context.AddRoutesById(kelownaId, edmontonId);
            //context.AddRoutesById(kelownaId, torontoId);

            //// insert kamloops routes

            //context.AddRoutesById(kamloopsId, vancouverId);
            //context.AddRoutesById(kamloopsId, victoriaId);
            //context.AddRoutesById(kamloopsId, kelownaId);
            //context.AddRoutesById(kamloopsId, calgaryId);
            //context.AddRoutesById(kamloopsId, edmontonId);
            //context.AddRoutesById(kamloopsId, torontoId);

            //// insert calgary routes

            //context.AddRoutesById(calgaryId, vancouverId);
            //context.AddRoutesById(calgaryId, victoriaId);
            //context.AddRoutesById(calgaryId, kelownaId);
            //context.AddRoutesById(calgaryId, kamloopsId);
            //context.AddRoutesById(calgaryId, edmontonId);
            //context.AddRoutesById(calgaryId, torontoId);

            //// insert edmonton routes

            //context.AddRoutesById(edmontonId, vancouverId);
            //context.AddRoutesById(edmontonId, victoriaId);
            //context.AddRoutesById(edmontonId, kelownaId);
            //context.AddRoutesById(edmontonId, kamloopsId);
            //context.AddRoutesById(edmontonId, calgaryId);
            //context.AddRoutesById(edmontonId, torontoId);

            //// insert toronto routes

            //context.AddRoutesById(torontoId, vancouverId);
            //context.AddRoutesById(torontoId, victoriaId);
            //context.AddRoutesById(torontoId, kelownaId);
            //context.AddRoutesById(torontoId, kamloopsId);
            //context.AddRoutesById(torontoId, calgaryId);
            //context.AddRoutesById(torontoId, edmontonId);

            //// save routes changes

            //context.SaveChanges();
        }
    }
}
