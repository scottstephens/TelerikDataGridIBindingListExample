using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikDataGridIBindingListExample
{
    public class StudentObject : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private float height;
        private float weight;
        private int? age;

        public StudentObject() { }

        public StudentObject(string iFname, string iLname, float iHeight, float iWeight, int? iAge)
        {
            this.firstName = iFname;
            this.lastName = iLname;
            this.height = iHeight;
            this.weight = iWeight;
            this.age = iAge;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (this.firstName != value)
                {
                    this.firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (this.lastName != value)
                {
                    this.lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (this.age != value)
                {
                    this.age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public float Height
        {
            get { return this.height; }
            set
            {
                if (this.height != value)
                {
                    this.height = value;
                    OnPropertyChanged("Height");
                }
            }
        }

        public float Weight
        {
            get { return this.weight; }
            set
            {
                if (this.weight != value)
                {
                    this.weight = value;
                    OnPropertyChanged("Weight");
                }
            }
        }

        #region INotifyPropertyChanged Members 

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        #endregion
    }
}
