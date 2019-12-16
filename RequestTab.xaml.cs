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

    public partial class RequestTab : UserControl
    {
        public RequestTab()
        {
            InitializeComponent();

            CounterDefault ReqNameText_CounterDefault = new CounterDefault { Number = ReqNameText.MaxLength.ToString() };
            ReqNameLabelLength.Content = ReqNameText_CounterDefault;
            CounterDefault ReqDescText_CounterDefault = new CounterDefault { Number = ReqDescText.MaxLength.ToString() };
            ReqDescLabelLength.Content = ReqDescText_CounterDefault;
            CounterDefault CommentText_CounterDefault = new CounterDefault { Number = CommentText.MaxLength.ToString() };
            CommentLabelLength.Content = CommentText_CounterDefault;
            CounterDefault AdminText_CounterDefault = new CounterDefault { Number = AdminText.MaxLength.ToString() };
            IfALength.Content = AdminText_CounterDefault;
        }

        #region Counters
        private void ReqNameText_Changed(object sender, TextChangedEventArgs e)
        {
            Counter ReqNameText_Counter = new Counter(ReqNameText, ReqNameLabelLength);
        }

        private void ReqDescText_Changed(object sender, TextChangedEventArgs e)
        {
            Counter ReqDescText_Counter = new Counter(ReqDescText, ReqDescLabelLength);
        }

        private void CommentText_Changed(object sender, TextChangedEventArgs e)
        {
            Counter CommentText_Counter = new Counter(CommentText, CommentLabelLength);
        }

        private void AdminText_Changed(object sender, TextChangedEventArgs e)
        {
            Counter AdminText_Counter = new Counter(AdminText, IfALength);
        }
        #endregion
    }
}
