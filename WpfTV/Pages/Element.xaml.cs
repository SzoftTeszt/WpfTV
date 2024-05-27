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
    /// Interaction logic for Element.xaml
    /// </summary>
    public partial class Element : UserControl
    {
       

        public static DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Element));

        public string Title { get {
                return (string)GetValue(TitleProperty);
            }
            set {
                SetValue(TitleProperty, value); }
        
        } 
        
        public static DependencyProperty KindProperty =
            DependencyProperty.Register("Kind", typeof(string), typeof(Element));

        public string Kind { get {
                return (string)GetValue(KindProperty);
            }
            set {
                SetValue(KindProperty, value); }
        
        }
        public Element()
        {
           
            InitializeComponent();
            //this.Kind = "Wifi";
            //this.Title = "Network Settings";
            this.DataContext = this;
        }
    }
}
