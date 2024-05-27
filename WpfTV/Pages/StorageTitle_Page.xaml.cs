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

namespace WpfTV.Pages
{
    /// <summary>
    /// Interaction logic for StorageTitle_Page.xaml
    /// </summary>
    public partial class StorageTitle_Page : UserControl
    {
        public static DependencyProperty TitleProperty =
           DependencyProperty.Register("Title", typeof(string), typeof(StorageTitle_Page));

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }

        }

        public Brush Color {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public static DependencyProperty ColorProperty =
         DependencyProperty.Register("Color", typeof(Brush), typeof(StorageTitle_Page));



        public StorageTitle_Page()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
