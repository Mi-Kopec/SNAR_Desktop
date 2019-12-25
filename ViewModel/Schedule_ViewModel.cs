using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SNAR_sheet.Schedule_Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SNAR_sheet.Schedule_ViewModel
{
    public class Schedule_ViewModel : INotifyPropertyChanged
    {
        public Schedule_ViewModel()
        {
            // populate Hours list
            var HoursList = new List<Number>();
            for (int i = 1; i <= 24; i++)
            {
                HoursList.Add(new Number() { Name = i });
            }

            // populate Minutes list
            var MinutesList = new List<Number>();
            for (int i = 1; i <= 60; i++)
            {
                MinutesList.Add(new Number() { Name = i });
            }

            this.Units = new List<Unit>()
            {
                new Unit(){ Name = "Hours", Numbers = HoursList},
                new Unit(){ Name = "Minutes", Numbers = MinutesList}

            };

            //set default Unit selection:
            this.SelectedUnit = this.Units[0];
        }

        public IList<Unit> Units
        {
            get;
            private set;
        }

        public ICollection<Number> Numbers
        {
            get;
            private set;
        }

        private Unit _selectedUnit;
        public Unit SelectedUnit
        {
            get
            {
                return _selectedUnit;
            }
            set
            {
                _selectedUnit = value;
                OnPropertyChanged("SelectedUnit");
                this.Numbers = _selectedUnit.Numbers;
                OnPropertyChanged("Numbers");
            }
        }

        public Number SelectedNumber
        {
            get;
            set;
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}