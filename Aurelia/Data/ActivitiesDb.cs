using System;
using System.Collections.Generic;
using System.Linq;

using Aurelia.Models;

namespace Aurelia.Data
{
	// mocking EF context getting data from db and populating models
	public static class ActivitiesDb
	{
		public static List<User> Users = new List<User>
		{
			new User {
				UID = 1,
				Email = "interview@infor.com",
				Pword = "interview" }
		};

		public static List<Job> Jobs = new List<Job>
		{
			new Job { UID = 1, Name = "Easy" },
			new Job { UID = 2, Name = "Medium" },
			new Job { UID = 3, Name = "Hard" }
		};

		public static List<Person> People = new List<Person>
		{
			new Person {
				UID = 1,
				Name = "Amanda Phillips",
				Job_ID = Jobs.FirstOrDefault(j => j.Name == "Easy").UID,
				Job = Jobs.FirstOrDefault(j => j.Name == "Easy")
			},
			new Person {
				UID = 2,
				Name = "Wesley Graves",
				Job_ID = Jobs.FirstOrDefault(j => j.Name == "Medium").UID,
				Job = Jobs.FirstOrDefault(j => j.Name == "Medium")
			},
			new Person {
				UID = 3,
				Name = "Allison Tucker",
				Job_ID = Jobs.FirstOrDefault(j => j.Name == "Hard").UID,
				Job = Jobs.FirstOrDefault(j => j.Name == "Hard")
			},
			new Person {
				UID = 4,
				Name = "Jason Wade",
				Job_ID = Jobs.FirstOrDefault(j => j.Name == "Medium").UID,
				Job = Jobs.FirstOrDefault(j => j.Name == "Medium")
			}
		};

		public static List<Shift> Shifts = new List<Shift>
		{
			new Shift { UID = 1, Name = "Morning" },
			new Shift { UID = 2, Name = "Afternoon" },
			new Shift { UID = 3, Name = "Evening" },
			new Shift { UID = 4, Name = "Overnight" }
		};

		public static List<Activity> Get()
		{
			return new List<Activity>
			{
				new Activity
				{
					UID = 1,
					Date = new DateTime(2016, 07, 20),
					Person_ID = People.FirstOrDefault(p => p.Name == "Amanda Phillips").UID,
					Person = People.FirstOrDefault(p => p.Name == "Amanda Phillips"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Morning").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Morning"),
					Start = new DateTime( 2016, 07, 20, 0, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 6, 0, 0)
				},
				new Activity
				{
					UID = 2,
					Date = new DateTime(2016, 07, 20),
					Person_ID = People.FirstOrDefault(p => p.Name == "Wesley Graves").UID,
					Person = People.FirstOrDefault((p) => p.Name == "Wesley Graves"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Afternoon").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Afternoon"),
					Start = new DateTime( 2016, 07, 20, 6, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 12, 0, 0)
				},
				new Activity
				{
					UID = 3,
					Date = new DateTime(2016, 07, 20),
					Person_ID = People.FirstOrDefault(p => p.Name == "Allison Tucker").UID,
					Person = People.FirstOrDefault((p) => p.Name == "Allison Tucker"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Evening").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Evening"),
					Start = new DateTime( 2016, 07, 20, 12, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 18, 0, 0)
				},
				new Activity
				{
					UID = 4,
					Date = new DateTime(2016, 07, 20),
					Person_ID = People.FirstOrDefault(p => p.Name == "Jason Wade").UID,
					Person = People.FirstOrDefault((p) => p.Name == "Jason Wade"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Overnight").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Overnight"),
					Start = new DateTime( 2016, 07, 20, 18, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 23, 59, 59)
				},
				new Activity
				{
					UID = 5,
					Date = new DateTime(2016, 07, 21),
					Person_ID = People.FirstOrDefault(p => p.Name == "Amanda Phillips").UID,
					Person = People.FirstOrDefault(p => p.Name == "Amanda Phillips"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Morning").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Morning"),
					Start = new DateTime( 2016, 07, 20, 0, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 6, 0, 0)
				},
				new Activity
				{
					UID = 6,
					Date = new DateTime(2016, 07, 21),
					Person_ID = People.FirstOrDefault(p => p.Name == "Wesley Graves").UID,
					Person = People.FirstOrDefault((p) => p.Name == "Wesley Graves"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Afternoon").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Afternoon"),
					Start = new DateTime( 2016, 07, 20, 6, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 12, 0, 0)
				},
				new Activity
				{
					UID = 7,
					Date = new DateTime(2016, 07, 21),
					Person_ID = People.FirstOrDefault(p => p.Name == "Allison Tucker").UID,
					Person = People.FirstOrDefault((p) => p.Name == "Allison Tucker"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Evening").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Evening"),
					Start = new DateTime( 2016, 07, 20, 12, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 18, 0, 0)
				},
				new Activity
				{
					UID = 8,
					Date = new DateTime(2016, 07, 21),
					Person_ID = People.FirstOrDefault(p => p.Name == "Jason Wade").UID,
					Person = People.FirstOrDefault(p => p.Name == "Jason Wade"),
					Shift_ID = Shifts.FirstOrDefault(s => s.Name == "Overnight").UID,
					Shift = Shifts.FirstOrDefault(s => s.Name == "Overnight"),
					Start = new DateTime( 2016, 07, 20, 18, 0, 0),
					Stop = new DateTime( 2016, 07, 20, 23, 59, 59)
				},
			};

		}
	}
}