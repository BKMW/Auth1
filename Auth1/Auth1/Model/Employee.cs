using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Auth1.Model
{
    class Employee : INotifyPropertyChanged
    {

        #region properties
        private int _ID;
        private string _CIN;
        private string _Name;
        private string _Department;
        private string _GSM;
        private ImageSource _Image;

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged("ID");
            }
        }
        public string CIN
        {
            get { return _CIN; }
            set
            {
                _CIN = value;
                OnPropertyChanged("CIN");
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Department
        {
            get { return _Department; }
            set
            {
                _Department = value;
                OnPropertyChanged("Department");
            }
        }
        public string GSM
        {
            get { return _GSM; }
            set
            {
                _GSM = value;
                OnPropertyChanged("GSM");
            }
        }
        public ImageSource Image
        {
            get { return _Image; }
            set
            {
                _Image = value;
                OnPropertyChanged("Image");
            }
        }
        #endregion
        #region constructor
        public Employee(string Name, string GSM, string Department="", string CIN="")
        {
            _GSM = GSM;
            _Name = Name;
            _Department = Department;
            _CIN = CIN;
        }

        //public Employee(string name, string v)
        //{
        //    Name = name;
        //    this.v = v;
        //}
        #endregion
        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
