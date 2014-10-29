using System;
using Assisticant.Fields;

namespace Lister
{
	public class PersonSelection
	{
		private Observable<string> _newName = new Observable<string>();

		public string NewName
		{
			get
			{
				return _newName.Value;
			}
			set
			{
				_newName.Value = value;
			}
		}
	}
}

