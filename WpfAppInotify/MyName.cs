using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfAppInotify
{
    class MyName : INotifyPropertyChanged
    {
        public string firstName;
        public string secondName;
        public string fullName;
        public MyName(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                 OnPropertyChanged("Fullname");
                //RaisePropertyChanged();
            }
        }

        public string SecondName
        {
            get { return secondName; }
            set
            {
                secondName = value;
                 OnPropertyChanged("Fullname");
               // RaisePropertyChanged();
            }
        }

        public string Fullname
        {
            get { return fullName=firstName+ " " + secondName; }
            set
            {
                fullName = value;

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
         public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName]string propertyName = null) =>
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        //public void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null) =>
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
