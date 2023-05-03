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

namespace WPF_Event_BubblingTunneling
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<string> list = new List<string>();
        public MainWindow() {
            InitializeComponent();
        }
        public void SetBubblingTextBox() {
            txtBubbling.Text = string.Join(">", list);
            ClearList();
        }
        public void SetTunnelingTextBox() {
            txtTunneling.Text = string.Join(">", list);
            ClearList();
        }

        private async void ClearList() {
            await Task.Delay(100);
            list.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            list.Add("Button_Gray");
            SetBubblingTextBox();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e) {
            list.Add("Border_Blue");
            SetBubblingTextBox();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e) {
            list.Add("Rectangle_Red");
            SetBubblingTextBox();
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            list.Add("Button_Gray");
            SetTunnelingTextBox();
        }

        private void Border_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            list.Add("Border_Blue");
            SetTunnelingTextBox();
        }

        private void Rectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            list.Add("Rectangle_Red");
            SetTunnelingTextBox();
        }
    }
}
