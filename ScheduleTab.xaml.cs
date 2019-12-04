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
            /*
            ResourceDictionary res = (ResourceDictionary)Application.LoadComponent(new Uri("ScheduleDictionary.xaml", UriKind.Relative));
            Style style = new Style();

            OneTimeGroup.Style = (Style)res["GroupBoxEnabled"];
            DailyBasicGroup.Style = (Style)res["GroupBoxDisabled"];
            WeeklyGroup.Style = (Style)res["GroupBoxDisabled"];
            MonthlyGroup.Style = (Style)res["GroupBoxDisabled"];
            StartsGroup.Style = (Style)res["GroupBoxEnabled"];
            */
        }

        private void Once_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary res = (ResourceDictionary)Application.LoadComponent(new Uri("ScheduleDictionary.xaml", UriKind.Relative));
            Style style = new Style();

            OneTimeGroup.Style = (Style)res["GroupBoxEnabled"];
            DailyBasicGroup.Style = (Style)res["GroupBoxDisabled"];
            WeeklyGroup.Style = (Style)res["GroupBoxDisabled"];
            MonthlyGroup.Style = (Style)res["GroupBoxDisabled"];
            StartsGroup.Style = (Style)res["GroupBoxEnabled"];
        }
        private void Daily_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary res = (ResourceDictionary)Application.LoadComponent(new Uri("ScheduleDictionary.xaml", UriKind.Relative));
            Style style = new Style();

            OneTimeGroup.Style = (Style)res["GroupBoxDisabled"];
            DailyBasicGroup.Style = (Style)res["GroupBoxEnabled"];
            WeeklyGroup.Style = (Style)res["GroupBoxDisabled"];
            MonthlyGroup.Style = (Style)res["GroupBoxDisabled"];
            StartsGroup.Style = (Style)res["GroupBoxEnabled"];
        }
        private void Weekly_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary res = (ResourceDictionary)Application.LoadComponent(new Uri("ScheduleDictionary.xaml", UriKind.Relative));
            Style style = new Style();

            OneTimeGroup.Style = (Style)res["GroupBoxDisabled"];
            DailyBasicGroup.Style = (Style)res["GroupBoxEnabled"];
            WeeklyGroup.Style = (Style)res["GroupBoxEnabled"];
            MonthlyGroup.Style = (Style)res["GroupBoxDisabled"];
            StartsGroup.Style = (Style)res["GroupBoxEnabled"];
        }
        private void Monthly_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary res = (ResourceDictionary)Application.LoadComponent(new Uri("ScheduleDictionary.xaml", UriKind.Relative));
            Style style = new Style();

            OneTimeGroup.Style = (Style)res["GroupBoxDisabled"];
            DailyBasicGroup.Style = (Style)res["GroupBoxDisabled"];
            WeeklyGroup.Style = (Style)res["GroupBoxDisabled"];
            MonthlyGroup.Style = (Style)res["GroupBoxEnabled"];
            StartsGroup.Style = (Style)res["GroupBoxEnabled"];
        } 
    }
}
