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
        public Style Enabled;
        public Style Disabled;

        public ScheduleTab()
        {
            InitializeComponent();
            
            ResourceDictionary res = (ResourceDictionary)Application.LoadComponent(new Uri("ScheduleDictionary.xaml", UriKind.Relative));
            Style style = new Style();
            Enabled = (Style)res["GroupBoxEnabled"];
            Disabled = (Style)res["GroupBoxDisabled"];
        }

        private void Once_Click(object sender, RoutedEventArgs e)
        {
            
            OneTimeGroup.Style = Enabled;
            DailyBasicGroup.Style = Disabled;
            WeeklyGroup.Style = Disabled;
            MonthlyGroup.Style = Disabled;
            StartsGroup.Style = Enabled;
        }
        private void Daily_Click(object sender, RoutedEventArgs e)
        {
            OneTimeGroup.Style = Disabled;
            DailyBasicGroup.Style = Enabled;
            WeeklyGroup.Style = Disabled;
            MonthlyGroup.Style = Disabled;
            StartsGroup.Style = Enabled;
        }
        private void Weekly_Click(object sender, RoutedEventArgs e)
        {
            OneTimeGroup.Style = Disabled;
            DailyBasicGroup.Style = Enabled;
            WeeklyGroup.Style = Enabled;
            MonthlyGroup.Style = Disabled;
            StartsGroup.Style = Enabled;
        }
        private void Monthly_Click(object sender, RoutedEventArgs e)
        {
            OneTimeGroup.Style = Disabled;
            DailyBasicGroup.Style = Disabled;
            WeeklyGroup.Style = Disabled;
            MonthlyGroup.Style = Enabled;
            StartsGroup.Style = Enabled;
        } 
    }
}
