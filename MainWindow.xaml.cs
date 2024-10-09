using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateToDo(object sender, RoutedEventArgs e)//Created an Method to respont to the Evenet Name given in Xaml
        {
            string text = textBox.Text;//Stored into Text

            if (!string.IsNullOrEmpty(text)){//If The Input does not have Content
                TextBlock textStack = new TextBlock//TextBlock to store and modify The Text Saved
                {
                    Text = text,
                    Margin = new Thickness(10),
                    Foreground=new SolidColorBrush(Colors.White)
                };
                
                StackPanel.Children.Add(textStack);//Added The Text to the  StackPanel In Xaml
                textBox.Clear();
            } 

            } 
        }

    }
