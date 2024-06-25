namespace DateTimeApp {
    public partial class btDayafter : Form {
        public btDayafter() {
            InitializeComponent();
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e) {

        }

        private void btDateCount_Click(object sender, EventArgs e) {

            // tbDisp.Text ="ÅZÅZì˙ñ⁄"
            var today = DateTime.Today;
            TimeSpan diff = today - dtpDate.Value;
            tbDisp.Text = diff.Days + "ì˙ñ⁄";
        }

        private void tbDisp_TextChanged(object sender, EventArgs e) {

        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var past = dtpDate.Value.AddDays(-(double)nudDay.Value);
            tbDisp.Text = past.ToString("D");
        }

        private void btDayafter_Click(object sender, EventArgs e) {
            var past = dtpDate.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = past.ToString("D");
        }

        private void btAge_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            int age = GetAge(dtpDate.Value, today);
            tbDisp.Text = age.ToString("D")+"çÀ";
        }
        public static  int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
