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
            var str = now.ToString("ggyy�NM��d��(dddd)", culture);

            tbDisp.Text = now.ToString("yyyy/MM/dd hh:mm") + "\r\n" +
                          now.ToString("yyyy�NMM��dd���@HH��mm��ss�b") + "\r\n" +
                          now.ToString(str);
        }

        private void btEx_2_Click(object sender, EventArgs e) {
            var now = DateTime.Today;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                var str1 = string.Format("{0:yy/MM/dd}�̗��T��{1}:", now, (DayOfWeek)dayofweek);
                var str2 = string.Format("{0:yy/MM/dd(ddd)}", NextWeek(now, (DayOfWeek)dayofweek));

                tbDisp.Text = str1 + NextWeek(now, (DayOfWeek)dayofweek) + "\r\n";
                //���T�̓��t���擾�i�߂�l���󂯎�邱�Ɓj
                // NextWeek(dateTime,(DayOfWeek)dayofweek);

            }

        }

        private void tbDisp_TextChanged(object sender, EventArgs e) {

        }
        //�������Ŏw�肵�����t�̗��T�̃C���X�^���X��ԋp����B�������A�������Ŏw�肵��
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var nextweek = date.AddDays(7);
            var day = dayOfWeek - (int)date.DayOfWeek;
            return nextweek.AddDays((double)day);
        }

        private void bt8_3(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = String.Format("�������Ԃ�{0}�~���b�ł���",duration.TotalMilliseconds);
            tbDisp.Text = str;
        }
    }

    class TimeWatch {
        private DateTime _time;

        public void Start() {
            _time = DateTime.Now;


        }
        public TimeSpan Stop() {
            return DateTime.Now - _time;
        }

    }
}
