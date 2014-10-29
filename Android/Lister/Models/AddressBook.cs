using System;
using System.Collections.Generic;
using Assisticant.Collections;

namespace Lister
{
	public class AddressBook
	{
		private ObservableList<Person> _people = new ObservableList<Person>(
			new List<Person> {
				new Person { Name = "Sargon" },
				new Person { Name = "Hammurabi" },
				new Person { Name = "Ashurbanipal" }
			});

		public IEnumerable<Person> People
		{
			get { return _people; }
		}

		public Person NewPerson()
		{
			Person person = new Person ();
			_people.Add (person);
			return person;
		}
	}
}

