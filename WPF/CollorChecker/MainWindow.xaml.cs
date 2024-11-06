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
        MyColor[] colorsTable; //色のデータ

        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定（起動時すぐにストックボタンが押された場合の対応）
            // currentColor.Color = Color.FromArgb(255,0,0,0);
            DataContext = colorsTable = GetColorList();
        }
        //MyColor currentColor = new MyColor();

        // private List<MyColor> stockColors = new List<MyColor>();

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

    
    //スライドを動かすと呼ばれるイベントハンドラ
    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            // int rvalue = (int) rSlider.Value;
            // int gvalue = (int) gSlider.Value;
            // int bvalue = (int) bSlider.Value;
            // colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)rvalue, (byte)gvalue, (byte)bvalue));
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            //currentColor.Name = colorsTable.Where(c => c.Equals(currentColor.Color)).Select(x=>x.Name).FirstOrDefault();

            int i;
            for (i = 0; i< colorsTable.Length; i++) {
                if (colorsTable[i].Color.Equals(currentColor.Color)) {
                    currentColor.Name = colorsTable[i].Name;
                    break;
                }
            }
            if (i == colorsTable.Length) {
                ColorSelctComboBox.SelectedIndex = i;
            } else {
                ColorSelctComboBox.SelectedIndex = 0;
            }
            ColorSelctComboBox.SelectedIndex = i;
            colorArea.Background = new SolidColorBrush(currentColor.Color);

        }

        private void STOCK_Click(object sender, RoutedEventArgs e) {
            //すでに登録している場合は登録しない
            if (!StockList.Items.Contains((MyColor)currentColor)){
                StockList.Items.Insert(0, currentColor);
            }else { 
                MessageBox.Show("すでに登録済みです","ColorChecker",MessageBoxButton.OK,MessageBoxImage.Error);
            }
           
        }

        private void StockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try {
                colorArea.Background = new SolidColorBrush(((MyColor)StockList.Items[StockList.SelectedIndex]).Color);
                setSliderValue(((MyColor)StockList.Items[StockList.SelectedIndex]).Color);
            }
            catch (Exception) {

            }
            
        }

        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)ColorSelctComboBox.Items[ColorSelctComboBox.SelectedIndex]).Color);
            setSliderValue(((MyColor)ColorSelctComboBox.Items[ColorSelctComboBox.SelectedIndex]).Color);
        }

        private void DELETE_Click(object sender, RoutedEventArgs e) {
            StockList.Items.RemoveAt(StockList.SelectedIndex);
        }
    }
}
