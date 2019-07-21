using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityRunningTeam.Models;


namespace UniversityRunningTeam.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Athletes.
            if (context.Athletes.Any())
            {
                return;   // DB has been seeded
            }

            var Athletes = new Athlete[]
            {
            new Athlete{FirstName="Carson",LastName="Alexander",Gender=Gender.Male,Dob=DateTime.Parse("1995-05-30"),Weight=140,Height=50},
            new Athlete{FirstName="Meredith",LastName="Alonso",Gender=Gender.Male,Dob=DateTime.Parse("1992-07-5"),Weight=160,Height=60},
            new Athlete{FirstName="Arturo",LastName="Anand",Gender=Gender.Male,Dob=DateTime.Parse("1993-02-15"),Weight=165,Height=55},
            new Athlete{FirstName="Gytis",LastName="JELLISON",Gender=Gender.Female,Dob=DateTime.Parse("1992-02-27"),Weight=125,Height=47},
            new Athlete{FirstName="Yan",MiddleName="Lee", LastName="Li",Gender=Gender.Male,Dob=DateTime.Parse("1992-08-24"),Weight=140,Height=73},
            new Athlete{FirstName="Peggy",MiddleName="Laura", LastName="Justice",Gender=Gender.Female,Dob=DateTime.Parse("1991-08-03"),Weight=230,Height=73},
            new Athlete{FirstName="Laura",MiddleName="Nicole", LastName="Norman",Gender=Gender.Female,Dob=DateTime.Parse("1993-04-03"),Weight=135,Height=67},
            new Athlete{FirstName="Tom",MiddleName="Marvolo", LastName="Riddle",Gender=Gender.Male,Dob=DateTime.Parse("1995-04-11"),Weight=145,Height=76},
            new Athlete{FirstName="Carl",LastName="Gibbons",Gender=Gender.Male,Dob=DateTime.Parse("1969-05-30"),Weight=212,Height=70},
            new Athlete{FirstName="Jackson ",LastName="Smith ",Gender=Gender.Male,Dob=DateTime.Parse("1995-05-30"),Weight=140,Height=50},
            new Athlete{FirstName="Sebastian ",LastName="Smith ",Gender=Gender.Male,Dob=DateTime.Parse("1992-07-5"),Weight=160,Height=60},
            new Athlete{FirstName="Aiden ",LastName="Smith ",Gender=Gender.Male,Dob=DateTime.Parse("1991-02-15"),Weight=165,Height=55},
            new Athlete{FirstName="Matthew ",LastName="Smith ",Gender=Gender.Female,Dob=DateTime.Parse("1992-02-20"),Weight=125,Height=47},
            new Athlete{FirstName="Samuel ",MiddleName="Colt   ", LastName="CarolsunlutzenBurhSchmity",Gender=Gender.Male,Dob=DateTime.Parse("1992-08-29"),Weight=140,Height=73},
            new Athlete{FirstName="David ",MiddleName="Archer ", LastName="Wheat",Gender=Gender.Female,Dob=DateTime.Parse("1998-08-03"),Weight=230,Height=73},
            new Athlete{FirstName="Joseph ",MiddleName="Omar ", LastName="Desk",Gender=Gender.Female,Dob=DateTime.Parse("1997-04-03"),Weight=135,Height=67},
            new Athlete{FirstName="Tom",MiddleName="Aidan ", LastName="Oliveoil",Gender=Gender.Male,Dob=DateTime.Parse("1995-04-11"),Weight=145,Height=76},
            new Athlete{FirstName="Carter ",LastName="Gibbons",Gender=Gender.Male,Dob=DateTime.Parse("1969-05-30"),Weight=212,Height=70},
            new Athlete{FirstName="Harper",LastName="WhiteHouse",Gender=Gender.Male,Dob=DateTime.Parse("1995-05-30"),Weight=140,Height=50},
            new Athlete{FirstName="Meredith",LastName="Ammoury",Gender=Gender.Male,Dob=DateTime.Parse("1992-07-5"),Weight=160,Height=60},
            new Athlete{FirstName="Evelyn",LastName="Swartzburg",Gender=Gender.Male,Dob=DateTime.Parse("1993-02-13"),Weight=165,Height=55},
            new Athlete{FirstName="Abigail",LastName="Disndy",Gender=Gender.Female,Dob=DateTime.Parse("1992-02-17"),Weight=125,Height=47},
            new Athlete{FirstName="Emily",MiddleName="Ememin", LastName="Li",Gender=Gender.Male,Dob=DateTime.Parse("1992-08-21"),Weight=140,Height=73},
            new Athlete{FirstName="Elizabeth",LastName="Kalifia",Gender=Gender.Female,Dob=DateTime.Parse("1991-08-03"),Weight=230,Height=73},
            new Athlete{FirstName="Mila", LastName="Prettyman",Gender=Gender.Female,Dob=DateTime.Parse("1993-04-23"),Weight=135,Height=67},
            new Athlete{FirstName="Ella", LastName="Larson",Gender=Gender.Male,Dob=DateTime.Parse("1995-04-22"),Weight=145,Height=76},
            new Athlete{FirstName="Avery",LastName="Thayne",Gender=Gender.Male,Dob=DateTime.Parse("1969-05-02"),Weight=212,Height=70},
            new Athlete{FirstName="Riley",LastName="Ocean",Gender=Gender.Male,Dob=DateTime.Parse("1995-05-03"),Weight=140,Height=50},
            new Athlete{FirstName="Nora",LastName="Excalaber",Gender=Gender.Male,Dob=DateTime.Parse("1992-07-15"),Weight=160,Height=60},
            new Athlete{FirstName="Eleanor",LastName="Ansley",Gender=Gender.Male,Dob=DateTime.Parse("1993-02-15"),Weight=165,Height=55},
            new Athlete{FirstName="Hannah",LastName="Barzee",Gender=Gender.Female,Dob=DateTime.Parse("1992-02-26"),Weight=125,Height=47},
            new Athlete{FirstName="Mason ",MiddleName="Bryson ", LastName="Li",Gender=Gender.Male,Dob=DateTime.Parse("1992-08-14"),Weight=167,Height=72},
            new Athlete{FirstName="Damian ",MiddleName="Sawyer ", LastName="Jenson",Gender=Gender.Female,Dob=DateTime.Parse("1991-08-05"),Weight=213,Height=73},
            new Athlete{FirstName="Silas ",MiddleName="Nicole", LastName="Raia",Gender=Gender.Female,Dob=DateTime.Parse("1993-04-03"),Weight=189,Height=78},
            new Athlete{FirstName="Chase ",MiddleName="Declan ", LastName="Riddle",Gender=Gender.Male,Dob=DateTime.Parse("1995-04-11"),Weight=202,Height=76},
            new Athlete{FirstName="Carl ",LastName="Gibbons",Gender=Gender.Male,Dob=DateTime.Parse("1969-05-30"),Weight=200,Height=70}
            };
            foreach (Athlete s in Athletes)
            {
                context.Athletes.Add(s);
            }
            context.SaveChanges();

            var Coachs = new Coach[]
           {
                new Coach { FirstName = "Kim",MiddleName="Amber", LastName = "Abercrombie", HireDate = DateTime.Parse("1995-03-11") },
                new Coach { FirstName = "Fadi", MiddleName="Aliku",LastName = "Fakhouri", HireDate = DateTime.Parse("2002-07-06") },
                new Coach { FirstName = "Tim",LastName = "Thayne", HireDate = DateTime.Parse("1998-07-01") },
                new Coach { FirstName = "Candace", LastName = "Kapoor", HireDate = DateTime.Parse("2001-01-15") },
                new Coach { FirstName = "Roger", LastName = "Zheng", HireDate = DateTime.Parse("2004-02-12") }
           };
            foreach (Coach i in Coachs)
            {
                context.Coaches.Add(i);
            }
            context.SaveChanges();

            var Fields = new Field[]
            {
                 new Field { Name = "Running",     Budget = 357000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    CoachID  = Coachs.Single( i => i.LastName == "Thayne").ID },
                new Field { Name = "Throwing", Budget = 0909000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    CoachID  = Coachs.Single( i => i.LastName == "Fakhouri").ID },
                new Field { Name = "Jumping", Budget = 250000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    CoachID  = Coachs.Single( i => i.LastName == "Thayne").ID }

            };

            foreach (Field d in Fields)
            {
                context.Fields.Add(d);
            }
            context.SaveChanges();

            var Events = new Event[]
            {
            new Event{EventID=1001,Title="100 Meters", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=1002,Title="200 Meters", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=1003,Title="400 Meters",FieldID = Fields.Single( s => s.Name == "Running").FieldID },
            new Event{EventID=1004,Title="1500 Meters", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=1005,Title="3000 Meters", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=1006,Title="400 Meters",FieldID = Fields.Single( s => s.Name == "Running").FieldID },
            new Event{EventID=1007,Title="100 Meter Hurdles", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=1008,Title="400 Meters Hurdles", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=1009,Title="4X100 Meter Relay", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=1010,Title="4X400 Meters Relay", FieldID = Fields.Single( s => s.Name == "Running").FieldID},
            new Event{EventID=2001,Title="High Jump",FieldID = Fields.Single( s => s.Name == "Jumping").FieldID},
            new Event{EventID=2002,Title="Pole Vault",FieldID = Fields.Single( s => s.Name == "Jumping").FieldID},
            new Event{EventID=2003,Title="Triple Jump",FieldID = Fields.Single( s => s.Name == "Jumping").FieldID},
            new Event{EventID=3001,Title="Discus Throw",FieldID = Fields.Single( s => s.Name == "Throwing").FieldID},
            new Event{EventID=3002,Title="Hammer Throw", FieldID = Fields.Single( s => s.Name == "Throwing").FieldID},
            new Event{EventID=3003,Title="Shot Put", FieldID = Fields.Single( s => s.Name == "Throwing").FieldID},
            new Event{EventID=3004,Title="Javelin Throw", FieldID = Fields.Single( s => s.Name == "Throwing").FieldID}


            };
            foreach (Event c in Events)
            {
                context.Events.Add(c);
            }
            context.SaveChanges();

            var EventCoach = new EventAssignment[]
             {
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "100 Meters" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Kapoor").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "200 Meters" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Kapoor").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "400 Meters" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Kapoor").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "1500 Meters" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Abercrombie").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "3000 Meters" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Abercrombie").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "100 Meter Hurdles" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Zheng").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "400 Meters Hurdles" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Zheng").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "4X100 Meter Relay" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Zheng").ID
                    },
                new EventAssignment {
                    EventID = Events.Single(c => c.Title == "4X400 Meter Relay" ).EventID,
                    CoachID = Coachs.Single(i => i.LastName == "Zheng").ID
                    },
                new EventAssignment {
                  EventID = Events.Single(c => c.Title == "High Jump" ).EventID,
                  CoachID = Coachs.Single(i => i.LastName == "Fakhouri").ID
                },
                new EventAssignment {
                  EventID = Events.Single(c => c.Title == "Pole Vault" ).EventID,
                  CoachID = Coachs.Single(i => i.LastName == "Fakhouri").ID
                  },
                new EventAssignment {
                  EventID = Events.Single(c => c.Title == "Triple Jump" ).EventID,
                  CoachID = Coachs.Single(i => i.LastName == "Fakhouri").ID
                  },
                new EventAssignment {
                  EventID = Events.Single(c => c.Title == "Discus Throw" ).EventID,
                  CoachID = Coachs.Single(i => i.LastName == "Thayne").ID
                  },
                new EventAssignment {
                  EventID = Events.Single(c => c.Title == "Hammer Throw" ).EventID,
                  CoachID = Coachs.Single(i => i.LastName == "Thayne").ID
                  },
                new EventAssignment {
                  EventID = Events.Single(c => c.Title == "Shot Put" ).EventID,
                  CoachID = Coachs.Single(i => i.LastName == "Thayne").ID
                  },
                new EventAssignment {
                  EventID = Events.Single(c => c.Title == "Javelin Throw" ).EventID,
                  CoachID = Coachs.Single(i => i.LastName == "Thayne").ID
                  }
             };

    

            foreach (EventAssignment ci in EventCoach)
            {
                context.EventAssignments.Add(ci);
            }
            context.SaveChanges();

            var trials = new Trial[]
            {
             //first
            new Trial{AthleteID=35,EventID=1001,Place=Place.First},
            new Trial{AthleteID=35,EventID=1002,Place=Place.First},
            new Trial{AthleteID=35,EventID=1003,Place=Place.First},
            new Trial{AthleteID=33,EventID=1004,Place=Place.First},
            new Trial{AthleteID=5,EventID=1005,Place=Place.First},
            new Trial{AthleteID=24,EventID=1006,Place=Place.First},
            new Trial{AthleteID=13,EventID=1007,Place=Place.First},
            new Trial{AthleteID=23,EventID=1008,Place=Place.First},
            new Trial{AthleteID=14,EventID=1009,Place=Place.First},
            new Trial{AthleteID=13,EventID=1010,Place=Place.First},
            new Trial{AthleteID=10,EventID=2001,Place=Place.First},
            new Trial{AthleteID=31,EventID=2002,Place=Place.First},
            new Trial{AthleteID=27,EventID=2003,Place=Place.First},
            new Trial{AthleteID=9,EventID=3001,Place=Place.First},
            new Trial{AthleteID=5,EventID=3002,Place=Place.First},
            new Trial{AthleteID=7,EventID=3003,Place=Place.First},
            new Trial{AthleteID=16,EventID=3004,Place=Place.First},
            new Trial{AthleteID=35,EventID=1001,Place=Place.Second},
            new Trial{AthleteID=35,EventID=1002,Place=Place.Second},
            new Trial{AthleteID=35,EventID=1003,Place=Place.Second},
            new Trial{AthleteID=35,EventID=1004,Place=Place.Second},
            new Trial{AthleteID=35,EventID=1005,Place=Place.Second},
            new Trial{AthleteID=24,EventID=1006,Place=Place.Second},
            new Trial{AthleteID=8,EventID=1007,Place=Place.Second},
            new Trial{AthleteID=33,EventID=1008,Place=Place.Second},
            new Trial{AthleteID=12,EventID=1009,Place=Place.Second},
            new Trial{AthleteID=10,EventID=1010,Place=Place.Second},
            new Trial{AthleteID=11,EventID=2001,Place=Place.Second},
            new Trial{AthleteID=12,EventID=2002,Place=Place.Second},
            new Trial{AthleteID=13,EventID=2003,Place=Place.Second},
            new Trial{AthleteID=14,EventID=3001,Place=Place.Second},
            new Trial{AthleteID=15,EventID=3002,Place=Place.Second},
            new Trial{AthleteID=16,EventID=3003,Place=Place.Second}, 
            new Trial{AthleteID=16,EventID=3004,Place=Place.Second},
            new Trial{AthleteID=35,EventID=1001,Place=Place.Third},
            new Trial{AthleteID=35,EventID=1002,Place=Place.Third},
            new Trial{AthleteID=35,EventID=1003,Place=Place.Third},
            new Trial{AthleteID=35,EventID=1004,Place=Place.Third},
            new Trial{AthleteID=35,EventID=1005,Place=Place.Third},
            new Trial{AthleteID=24,EventID=1006,Place=Place.Third},
            new Trial{AthleteID=27,EventID=1007,Place=Place.Third},
            new Trial{AthleteID=33,EventID=1008,Place=Place.Third},
            new Trial{AthleteID=23,EventID=1009,Place=Place.Third},
            new Trial{AthleteID=10,EventID=1010,Place=Place.Third},
            new Trial{AthleteID=11,EventID=2001,Place=Place.Third},
            new Trial{AthleteID=12,EventID=2002,Place=Place.Third},
            new Trial{AthleteID=13,EventID=2003,Place=Place.Third},
            new Trial{AthleteID=14,EventID=3001,Place=Place.Third},
            new Trial{AthleteID=15,EventID=3002,Place=Place.Third},
            new Trial{AthleteID=16,EventID=3003,Place=Place.Third}, 
            new Trial{AthleteID=16,EventID=3004,Place=Place.Third}, 
            new Trial{AthleteID=35,EventID=1001},
            new Trial{AthleteID=35,EventID=1002},
            new Trial{AthleteID=35,EventID=1003},
            new Trial{AthleteID=35,EventID=1004},
            new Trial{AthleteID=35,EventID=1005},
            new Trial{AthleteID=24,EventID=1006},
            new Trial{AthleteID=25,EventID=1007},
            new Trial{AthleteID=33,EventID=1008},
            new Trial{AthleteID=25,EventID=1009},
            new Trial{AthleteID=10,EventID=1010},
            new Trial{AthleteID=11,EventID=2001},
            new Trial{AthleteID=12,EventID=2002},
            new Trial{AthleteID=13,EventID=2003},
            new Trial{AthleteID=14,EventID=3001},
            new Trial{AthleteID=15,EventID=3002},
            new Trial{AthleteID=16,EventID=3003}, 
            new Trial{AthleteID=16,EventID=3004}
            };
            foreach (Trial e in trials)
            {
                var enrollmentInDataBase = context.Trials.Where(
                    s =>
                            s.Athlete.ID == e.AthleteID &&
                            s.Event.EventID == e.EventID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Trials.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}


