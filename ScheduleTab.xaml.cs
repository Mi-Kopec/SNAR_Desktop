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
            Style = new Style();
            Enabled = (Style)res["GroupBoxEnabled"];
            Disabled = (Style)res["GroupBoxDisabled"];

            OneTimeGroup.Style = Enabled;
            DailyBasicGroup.Style = Disabled;
            WeeklyGroup.Style = Disabled;
            MonthlyGroup.Style = Disabled;
            StartsGroup.Style = Enabled;

            OElist.ItemsSource = new string[] {"Hours", "Minutes"};

            MonthlyTheNum.ItemsSource = new string[] {"First", "Secound", "Third", "Last"};
            MonthlyTheDay.ItemsSource = new string[] {"Sunday", "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        }

        #region Main
        private void SchNameText_Changed(object sender, TextChangedEventArgs e)
        {
            Counter SchNameText_Counter = new Counter(SchNameText, SchNameTextLength);
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
        #endregion

        #region One-time occurrence

        #endregion

        #region Daily frequency 
        private void OOA_Click(object sender, RoutedEventArgs e)
        {
            OccursOnceAt.IsEnabled = true;
            OEupdown.IsEnabled = false;
            OElist.IsEnabled = false;
        }
        private void OE_Click(object sender, RoutedEventArgs e)
        {
            OccursOnceAt.IsEnabled = false;
            OEupdown.IsEnabled = true;
            OElist.IsEnabled = true;
        }
        public void BindingOEupdown(object sender, RoutedEventArgs e)
        {
            if(OElist.SelectedIndex == 0)
            {
                OEupdown.ItemsSource = new string[] { "raz", "dwa", "trzy" };
            }
            else
            {
                OEupdown.ItemsSource = new string[] { "m1", "m2", "m3" };
            }
        }
        #endregion

        #region Frequency
        #endregion

        #region Monthly
        private void Day_Click(object sender, RoutedEventArgs e)
        {
            MonthlyDayNum.Enabled = true;
            MonthlyDayMon.Enabled = true;
            MonthlyLabel.IsEnabled = true;
            MonthlyLabel2.IsEnabled = true;
            MonthlyTheNum.IsEnabled = false;
            MonthlyTheDay.IsEnabled = false;
        }

        private void The_Click(object sender, RoutedEventArgs e)
        {
            MonthlyDayNum.Enabled = false;
            MonthlyDayMon.Enabled = false;
            MonthlyLabel.IsEnabled = false;
            MonthlyLabel2.IsEnabled = false;
            MonthlyTheNum.IsEnabled = true;
            MonthlyTheDay.IsEnabled = true;
        }
        #endregion

        #region Starts from

        #endregion

        
    }
}
