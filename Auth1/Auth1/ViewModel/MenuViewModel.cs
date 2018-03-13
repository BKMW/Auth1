using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Auth1.Model;
using Xamarin.Forms;

namespace Auth1.ViewModel
{
    class MenuViewModel
    {
        // public List<MenuItem> MenuItems; i can't use list  in mvvm 
       
        #region Fields
        public INavigation navigation;
        public Command<Object> _tapCommand;
        #endregion
        #region fields
        //public ObservableCollection<MenuItem> MenuItems { get; set; }
        //public ObservableCollection<Employee> Employees { get; set; }
        #endregion
        //public Command TapCommand
        //{
        //    get; set;
        //}
        #region Properties

        public ObservableCollection<Employee> Employees { get; set; }

        public Command<Object> TappedCommand
        {
            get { return _tapCommand; }
            set { _tapCommand = value; }
        }

        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }

        #endregion

       
        #region Constructor with parameters

        public MenuViewModel(INavigation _nav)
        {
            Navigation = _nav; ;
            TappedCommand = new Command<Object>(OnTapped);
            Employees = new ObservableCollection<Employee>();
            Random r = new Random();
            foreach (var name in Names)
            {
                var employee = new Employee(name, r.Next(216, 870).ToString() + "-" + r.Next(22222222, 22999999));
                employee.Image = ImageSource.FromResource("Auth1.Images.image" + r.Next(1, 3) + ".png");
                Employees.Add(employee);
            }

        }

        public MenuViewModel()
        {
        }

        #endregion
        #region OnTapped Method Implementation

        public void OnTapped(Object o)
        {
            var nextPage = new Detail();
            nextPage.BindingContext = o;
            Navigation.PushAsync(nextPage);
        }

        #endregion

        #region List of Names and Departments  

        private string[] Names = new string[]
        {
            "Mohamed", "Bachir", "Fawzi", "Imen", "Emna", "Salwa",
        };


        #endregion
        //#region constructor
        //public MenuViewModel()
        //{

        //    //GetMenuItems();
        //    //GetEmployees();


        //}
        //#endregion
        #region fun
        //// fun Get items for menu
        //public void GetMenuItems()
        //{
        //    //  MenuItems = new List<MenuItem> i can't use list  in mvvm 
        //    MenuItems = new ObservableCollection<MenuItem>
        //    {
        // new MenuItem{
        //     Image="Right_Arrow.png",
        //     Title="Add"
        // },
        //  new MenuItem{
        //     Image="Right_Arrow.png",
        //     Title="Update"
        // },
        //   new MenuItem{
        //     Image="Right_Arrow.png",
        //     Title="View"
        // },
        //    new MenuItem{
        //     Image="Right_Arrow.png",
        //     Title="Delete"
        // },

        //};
        //}// end fun GetMenuItems()
        //public void GetEmployees()
        //{
        //    //  MenuItems = new List<MenuItem> i can't use list  in mvvm 
        //    Employees = new ObservableCollection<Employee>
        //    {
        // new Employee{
        //     CIN="",
        //     Name="Muhammed",
        //     Department="Backend",
        //     GSM="",
        // },
        //  new Employee{
        //     CIN="",
        //     Name="Fawzi",
        //     Department="Backend",
        //     GSM="",
        // },
        //   new Employee{
        //     CIN="",
        //     Name="Mounir",
        //     Department="UI",
        //     GSM="",
        // },
        //    new Employee{
        //     CIN="",
        //     Name="Aiman",
        //     Department="UI",
        //     GSM="",
        // },

        //};
        //}// end fun GetEmployees()
        #endregion
    }
}
