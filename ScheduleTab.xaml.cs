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
    public partial class ScheduleTab : UserControl
    {
        public ScheduleTab()
        {
            InitializeComponent();
        }

        private void Once_Click(object sender, RoutedEventArgs e)
        {
            OneTimeGroup.IsEnabled = true;
            DailyBasicGroup.IsEnabled = false;
            WeeklyGroup.IsEnabled = false;
            MonthlyGroup.IsEnabled = false;
            StartsGroup.IsEnabled = true;
        }
        private void Daily_Click(object sender, RoutedEventArgs e)
        {
            OneTimeGroup.IsEnabled = false;
            DailyBasicGroup.IsEnabled = true;
            WeeklyGroup.IsEnabled = false;
            MonthlyGroup.IsEnabled = false;
            StartsGroup.IsEnabled = true;
        }
        private void Weekly_Click(object sender, RoutedEventArgs e)
        {
            OneTimeGroup.IsEnabled = false;
            DailyBasicGroup.IsEnabled = true;
            WeeklyGroup.IsEnabled = true;
            MonthlyGroup.IsEnabled = false;
            StartsGroup.IsEnabled = true;
        }
        private void Monthly_Click(object sender, RoutedEventArgs e)
        {
            OneTimeGroup.IsEnabled = false;
            DailyBasicGroup.IsEnabled = false;
            WeeklyGroup.IsEnabled = false;
            MonthlyGroup.IsEnabled = true;
            StartsGroup.IsEnabled = true;
        }
    }
}
