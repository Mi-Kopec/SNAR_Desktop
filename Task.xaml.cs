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

    public partial class Task : UserControl
    {
        public Task()
        {
            InitializeComponent();
        }
        
        private void TxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            Counter ScheduleMainCounter = new Counter(txtInput, lblLength);
        }

    }
}
