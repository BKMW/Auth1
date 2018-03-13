using Auth1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Auth1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
       
        public Login ()
		{
            var vm = new LoginViewModel();
            this.BindingContext = vm;
           
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert(vm.title, vm.message, "OK");
           // vm.DisplayInvalidLoginPrompt1 += () => DisplayAlert("Error", "Welcome", "OK");

            InitializeComponent ();
		}

      

    }
}