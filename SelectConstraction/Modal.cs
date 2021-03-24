using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectConstraction {
    public partial class Modal : Form {
        public string _password;
        public string password;
        public Modal(string _password) {
            InitializeComponent();
            this._password = _password;
        }

        private void button1_Click(object sender, EventArgs e) {
            password = textBox1.Text;
            this.Dispose();
        }

        public bool CorrectPassword() {
            if (password == _password)
                return true;
            else
                return false;
        }
    }
}
