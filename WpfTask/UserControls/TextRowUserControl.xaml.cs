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

namespace WpfTask.UserControls
{
    /// <summary>
    /// Interaction logic for TextRowUserControl.xaml
    /// </summary>
    public partial class TextRowUserControl : UserControl
    {
        public static readonly DependencyProperty LabelToDisplayProperty =
        DependencyProperty.Register(
            nameof(LabelToDisplay),
            typeof(string),
            typeof(TextRowUserControl));

        public string LabelToDisplay
        {
            get { return (string)GetValue(LabelToDisplayProperty); }
            set { SetValue(LabelToDisplayProperty, value); }
        }

        public static readonly DependencyProperty ContentToDisplayProperty =
        DependencyProperty.Register(
            nameof(ContentToDisplay),
            typeof(string),
            typeof(TextRowUserControl));

        public string ContentToDisplay
        {
            get { return (string)GetValue(ContentToDisplayProperty); }
            set { SetValue(ContentToDisplayProperty, value); }
        }

        public TextRowUserControl()
        {
            InitializeComponent();
        }
    }
}
