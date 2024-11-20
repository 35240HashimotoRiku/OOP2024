using CustomerApp.Objects;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public partial class MainWindow : Window {
        private List<Customer> _customers;

        public MainWindow() {
            InitializeComponent();
            // ウィンドウが読み込まれたときに画像を挿入
            InsertImage1();
            ReadDatabase(); // データベースを読み込んでリスト表示
        }

        // 画像①を埋め込む
        private void InsertImage1() {
            // 画像リソースのパス（プロジェクト名.名前空間.画像ファイル名）
            string path1 = "CustomerApp.Resources.image1.jpg"; //画像ファイル先を指定

            BitmapImage bmpImg = new BitmapImage();
            bmpImg.BeginInit();

            // アセンブリを取得
            Assembly assembly = Assembly.GetExecutingAssembly();

            // 埋め込まれた画像リソースのストリームを取得
            Stream stream = assembly.GetManifestResourceStream(path1);
            if (stream != null) {
                bmpImg.StreamSource = stream;
                bmpImg.EndInit();

                // XAMLのImageコントロールに画像をセット
                
            } else {
                MessageBox.Show("画像リソースが見つかりません。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // 新しい顧客情報をデータベースに追加
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var newCustomer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(newCustomer);
            }

            ReadDatabase();
        }

        // 顧客情報を更新
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                selectedCustomer.Name = NameTextBox.Text;
                selectedCustomer.Phone = PhoneTextBox.Text;
                selectedCustomer.Address = AddressTextBox.Text;

                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Update(selectedCustomer);
                }

                ReadDatabase();
            } else {
                MessageBox.Show("更新する顧客を選択してください。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // 顧客リストをデータベースから読み込む
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
                CustomerListView.ItemsSource = _customers;
            }
        }

        // 顧客情報を検索
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        // 顧客情報を削除
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する顧客を選択してください", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
            }

            ReadDatabase();
        }

        // 顧客が選択された時にTextBoxに顧客情報を表示
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
            } else {
                NameTextBox.Clear();
                PhoneTextBox.Clear();
                AddressTextBox.Clear();
            }
        }
    }
}
