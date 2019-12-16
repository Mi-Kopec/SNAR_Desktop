using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SNAR_sheet
{
    public class Counter
    {
        public TextBox InputTextbox { get; set; }
        public Label CounterLabel { get; set; }
        public Counter(TextBox InputTextbox, Label CounterLabel)
        {
            int NB;
            var tempText = InputTextbox.Text;
            NB = (InputTextbox.MaxLength - tempText.Length);
            CounterNumber counterNumber = new CounterNumber { Number = NB.ToString() };
            CounterLabel.Content = counterNumber;
            if (NB == 0)
            {
                CounterLabel.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
        class CounterNumber
        {
            public string Number { get; set; }
            public override string ToString()
            {
                return "[" + Number + "]";
            }
        } 
    }
}
