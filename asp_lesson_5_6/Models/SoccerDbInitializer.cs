using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp_lesson_5_6.Models
{
    public class SoccerDbInitializer : DropCreateDatabaseAlways<SoccerContext>
    {
        protected override void Seed(SoccerContext db)
        {
            Team t1 = new Team { Name = "Barselona", Coach = "Romerales" };
            Team t2 = new Team { Name = "Real", Coach = "Valenza" };
            db.Teams.Add(t1);
            db.Teams.Add(t2);
            db.SaveChanges();

            db.Players.Add(new Player { Name = "Война и мир", Age = 25, Position = "вратарь", Team = t1 });
            db.Players.Add(new Player { Name = "Отцы и дети", Age = 22, Position = "защитник", Team = t2 });
            db.Players.Add(new Player { Name = "Чайка", Age = 32, Position = "полузащитник", Team = t2 });

            base.Seed(db);
        }
    }
}