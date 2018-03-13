using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Auth1.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Action DisplayInvalidLoginPrompt;
        public string title = "";
        public string message = "";
        // public Action DisplayInvalidLoginPrompt1;
        private String _login;
        public String Login
        { 
            get { return _login; }
            set
            {
                _login = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Login"));
            }
        }

       
        private String _password;
        public String Password    
        {
            get { return _password; }
            set
            {
                _password = value; 
                PropertyChanged(this, new PropertyChangedEventArgs("Password")); 
            }
        }
        public ICommand SubmitCommand
        { protected set; get; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (_login != "root" || _password != "root")
            {
                title = "failed";
                message = "failed";
                DisplayInvalidLoginPrompt();
            }
            else
            {
                //title = "welcome";
                //message = "welcome";
                //DisplayInvalidLoginPrompt();
                //seconde methode ...
                //Page page = new Page();
                //page.DisplayAlert("welcome2", "welcome2", "ok");
                Application.Current.MainPage.Navigation.PushModalAsync(new View.Menu());
                //Application.Current.MainPage.Navigation.PushModalAsync("page") ; 
            }
        }
    }
}
