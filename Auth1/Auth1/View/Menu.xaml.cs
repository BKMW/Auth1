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
	public partial class Menu : MasterDetailPage
    {
       
		public Menu ()
		{
            var vm = new MenuViewModel(this.Navigation);
            this.BindingContext = vm;

            InitializeComponent ();
		}
	}
    
}