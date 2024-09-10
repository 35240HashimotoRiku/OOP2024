using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {

    public partial class Form1 : Form {
        List<ItemData> items;

        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(tbRssUrl.Text) || !Uri.IsWellFormedUriString(tbRssUrl.Text, UriKind.Absolute)) {
                MessageBox.Show("正しいURLを入力してください。", "エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//エラーメッセージの表示


            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        //  private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
        //      webBrowser1.Navigate(items[lbRssTitle.SelectedIndex].Link);
        //  }

        private void MainNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/top-picks.xml");//主要ニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void KokunaiNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/domestic.xml");//国内ニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void KokusaiNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/world.xml");//国際ニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void KeizaiNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/business.xml");//経済ニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void EntameNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/entertainment.xml");//エンタメニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void SportsNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/sports.xml");//スポーツニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void ItNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/it.xml");//ITニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void KagakuNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/science.xml");//科学ニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void TikiNews_CheckedChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/local.xml");//地域ニュース
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title").Value,
                                Link = item.Element("link").Value,
                            }).ToList();

                lbRssTitle.Items.Clear();//リストボックス削除

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }
    }


    //データ格納用のクラス
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
