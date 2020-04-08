using System;
using System.Collections.Generic;
using System.Linq;
using SQliteDemo.Entities;

namespace SQliteDemo {
    class Program {
        static void Main(string[] args) {

            var dbContext = new DatabaseContext();

            #region CreateRegion
            //var burna = new Artist() {
            //    RealName = "Kelly",
            //    StageName = "Burna Boy"
            //};

            //dbContext.Add(burna);
            //dbContext.SaveChanges();
            #endregion

            #region RetrieveRegion
            //var burnRetrieved = dbContext.Find<Artist>(1);

            //Console.WriteLine(burnRetrieved.RealName);
            //Console.WriteLine(burnRetrieved.StageName);
            #endregion

            #region UpdateRegion
            //var burna = dbContext.Find<Artist>(1);
            //burna.RealName = "Ndubuisi Jr";
            //dbContext.Update(burna);
            //dbContext.SaveChanges();
            #endregion

            #region DeleteRegion
            //var burna = dbContext.Find<Artist>(1);
            //dbContext.Remove(burna);
            //dbContext.SaveChanges();
            #endregion
            dbContext.Dispose();

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
