using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmVersion : Form {
        public fmVersion() {
            InitializeComponent();
        }

        private void btVersionOk_Click(object sender, EventArgs e) {
            Close();
        }
       
private void fmVersion_Load(object sender, EventArgs e) {
            var assm = Assembly.GetExecutingAssembly();
            var ver = assm.GetName().Version;
            lbVersion.Text = "version" + ver.ToString();
        }
    }
}
