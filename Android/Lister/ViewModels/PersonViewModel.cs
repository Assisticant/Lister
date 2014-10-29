using System;

namespace Lister
{
	public class PersonViewModel
	{
		private readonly Person _person;

		public PersonViewModel(Person person)
		{
			_person = person;
		}

		public string Name
		{
			get { return _person.Name; }
		}
	}
}

