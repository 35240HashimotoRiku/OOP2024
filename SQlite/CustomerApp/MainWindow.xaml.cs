using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public partial class MainWindow : Window {
        private List<Customer> _customers;

        public MainWindow() {
            InitializeComponent();

        }

        // 画像byte[]に変換するメソッド
        // 画像byte[]に変換するメソッド
        // 画像byte[]に変換するメソッド
        // 画像byte[]に変換するメソッド
        public byte[] ConvertImageToByteArray(BitmapImage bitmapImage) {
            if (bitmapImage == null) {
                return null; // もしくはデフォルト画像を使いたい場合はここでデフォルト画像を使用
            }

            using (MemoryStream memoryStream = new MemoryStream()) {
                // BitmapImageの画像をMemoryStreamにエンコード
                JpegBitmapEncoder encoder = new JpegBitmapEncoder(); // ここではJPEG形式で保存します
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));

                // MemoryStreamにエンコードされた画像を保存
                encoder.Save(memoryStream);

                // MemoryStreamをバイト配列に変換
                return memoryStream.ToArray();
            }
        }





        // 新しい顧客情報をデータベースに追加
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            // TextBoxから新しい顧客情報を取得
            var newCustomer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                ImagePath = ConvertImageToByteArray((BitmapImage)ImagePath.Source)
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

                // 画像が設定されていれば、画像データを更新
                if (ImagePath.Source != null) {
                    BitmapImage bitmapImage = (BitmapImage)ImagePath.Source;
                    selectedCustomer.ImagePath = ConvertImageToByteArray(bitmapImage);
                } else {
                    selectedCustomer.ImagePath = null;
                }
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
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                // 顧客情報をTextBoxに表示
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
                ImagePath.Source = ConvertByteArrayToBitmapImage(selectedCustomer.ImagePath);
            } else {
                // 顧客が選択されていない場合、TextBoxをクリア
                NameTextBox.Clear();
                PhoneTextBox.Clear();
                AddressTextBox.Clear();
            }
        }

        //画像をクリア
        private void ClearImageButton_Click(object sender, RoutedEventArgs e) {
            ImagePath.Source = null;
        }
        //オールクリア
        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            NameTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            ImagePath.Source = null;
        }



        private void ImagePathButton_Click_2(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "画像を選択"
            };

            if (openFileDialog.ShowDialog() == true) {
                // 画像パスを取得して、Customerオブジェクトにセット
                string imagePath = openFileDialog.FileName;
                ImagePath.Source = new BitmapImage(new Uri(imagePath));
            };
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            ReadDatabase();
        }
        public BitmapImage ConvertByteArrayToBitmapImage(byte[] byteArray) {
            if (byteArray == null || byteArray.Length == 0) {
                // もし byteArray が null か空であれば、空の画像を返す
                return new BitmapImage();
            }

            using (MemoryStream memoryStream = new MemoryStream(byteArray)) {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }


    }
}
