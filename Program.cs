using System;
using System.Windows.Forms;

namespace monoForms1 {
    class MainClass : Form {
        public MainClass() {
            this.Text = "标题";
        }
        public static void Main(string[] args) {
            Application.Run(new MainClass());
        }
    }
}
