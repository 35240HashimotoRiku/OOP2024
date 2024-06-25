using System.Globalization;

namespace Exercise01_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx_1_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = now.ToString("ggyy”NMŒd“ú(dddd)", culture);

            tbDisp.Text = now.ToString("yyyy/MM/dd hh:mm") + "\r\n"+
                          now.ToString("yyyy”NMMŒdd“ú@HHmm•ªss•b") + "\r\n"+
                          now.ToString(str);
        }

        private void btEx_2_Click(object sender, EventArgs e) {

        }

        private void tbDisp_TextChanged(object sender, EventArgs e) {

        }

        
    }
}
