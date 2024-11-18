using CustomerApp.Objects;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CustomerApp {
    public partial class MainWindow : Window {
        private List<Customer> _customers;

        public MainWindow() {
            InitializeComponent();
        }

        // 新しい顧客情報をデータベースに追加
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            // TextBoxから新しい顧客情報を取得
            var newCustomer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text
            };

            // 顧客情報をデータベースに保存
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(newCustomer);
            }

            // 顧客リストを再読込
            ReadDatabase();
        }

        // 選択された顧客情報を更新
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                // TextBoxの内容で顧客情報を更新
                selectedCustomer.Name = NameTextBox.Text;
                selectedCustomer.Phone = PhoneTextBox.Text;
                selectedCustomer.Address = AddressTextBox.Text;

                // データベースに更新内容を反映
                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Update(selectedCustomer);
                }

                // 顧客リストを再読込
                ReadDatabase();
            } else {
                MessageBox.Show("更新する顧客を選択してください。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // 顧客リストをデータベースから読み込んで表示
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
                CustomerListView.ItemsSource = _customers;
            }
        }

        // 顧客リストを検索してフィルタリング
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

            // 顧客情報をデータベースから削除
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
            }

            // 顧客リストを再読込
            ReadDatabase();
        }

        // ウィンドウが読み込まれた時に顧客リストを表示
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase();
        }

        // 顧客が選択された時、TextBoxに顧客情報を表示
        private void CustomerListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                // 顧客情報をTextBoxに表示
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
            } else {
                // 顧客が選択されていない場合、TextBoxをクリア
                NameTextBox.Clear();
                PhoneTextBox.Clear();
                AddressTextBox.Clear();
            }
        }
    }
}
