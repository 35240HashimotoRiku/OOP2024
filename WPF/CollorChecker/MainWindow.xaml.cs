using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor currentColor = new MyColor(); //現在設定している色情報

        public MainWindow() {
            InitializeComponent();
           //αチャンネルの初期値を設定（起動時すぐにストックボタンが押された場合の対応）
           // currentColor.Color = Color.FromArgb(255,0,0,0);
        }
       //MyColor currentColor = new MyColor();

       // private List<MyColor> stockColors = new List<MyColor>();

        //スライドを動かすと呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            // int rvalue = (int) rSlider.Value;
            // int gvalue = (int) gSlider.Value;
            // int bvalue = (int) bSlider.Value;
            // colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)rvalue, (byte)gvalue, (byte)bvalue));
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void STOCK_Click(object sender, RoutedEventArgs e) {
            ListBox.Items.Insert(0, currentColor);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
          // colorArea.Background = new SolidColorBrush((MyColor)ListBox.Items[ListBox.SelectedIndex]);
          // rSlider.Value = ((MyColor)ListBox.Items[ListBox.SelectedIndex]).Color.R;
          // gSlider.Value = ((MyColor)ListBox.Items[ListBox.SelectedIndex]).Color.G;
          // bSlider.Value = ((MyColor)ListBox.Items[ListBox.SelectedIndex]).Color.B;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void StackPanel_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
        }
    }
}
