using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Assisticant.Binding;

namespace Lister
{
	[Activity (Label = "Lister", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private AddressBookViewModel _viewModel =
			new AddressBookViewModel (new AddressBook (), new PersonSelection());
		private BindingManager _bindings = new BindingManager();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			_bindings.Initialize (this);

			_bindings.BindItems (
				FindViewById<ListView> (Resource.Id.listPeople),
				() => _viewModel.People,
				Android.Resource.Layout.SimpleListItem1,
				(view, person, bindingManager) =>
				{
					bindingManager.BindText(
						view.FindViewById<TextView>(Android.Resource.Id.Text1),
						() => person.Name);
				});
			_bindings.BindText (
				FindViewById<EditText> (Resource.Id.editName),
				() => _viewModel.NewName,
				s => _viewModel.NewName = s);
			_bindings.BindCommand (
				FindViewById<Button> (Resource.Id.buttonAdd),
				() => _viewModel.AddPerson (),
				() => _viewModel.CanAddPerson);
		}
	}
}


