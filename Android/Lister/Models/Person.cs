using System;
using Assisticant.Fields;

namespace Lister
{
	public class Person
	{
		private Observable<string> _name = new Observable<string>();

		public string Name
		{
			get { return _name.Value; }
			set { _name.Value = value; }
		}
	}
}

