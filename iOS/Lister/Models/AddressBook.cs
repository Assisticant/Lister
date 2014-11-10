using System;
using Assisticant.Collections;
using System.Collections.Generic;

namespace Lister
{
	public class AddressBook
	{
		private ObservableList<Person> _people = new ObservableList<Person>(
			new List<Person> {
			new Person { Name = "Cliff" },
			new Person { Name = "Bill" },
			new Person { Name = "Allen" }
			}
		);

		public IEnumerable<Person> People
		{
			get { return _people; }
		}

		public Person NewPerson()
		{
			Person person = new Person();
			_people.Add( person );
			return person;
		}
	}
}

