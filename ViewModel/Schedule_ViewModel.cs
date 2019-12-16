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
            this.Units = new List<Unit>()
      {
        new Unit(){ Name = "Minutes",
        Numbers = new List<Number>()
        {
          new Number(){ Name = 1 },
          new Number(){ Name = 2 },
          new Number(){ Name = 3 }
        }},
        new Unit(){ Name = "Minutes",
        Numbers = new List<Number>()
        {
            new Number(){ Name = 1234 },
        }},
        new Unit(){ Name = "Secounds",
        Numbers = new List<Number>()
        {
          new Number(){ Name = 1 },
          new Number(){ Name = 2 },
          new Number(){ Name = 3 },
          new Number(){ Name = 4 },
          new Number(){ Name = 5 },
          new Number(){ Name = 6 },
        }}
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
