using System;
using System.Windows.Forms;

//mcs -pkg:dotnet Hello.cs
namespace monoForms1 {
    class Hello : Form {
        public Hello() {
            this.Text = "标题";
        }
        public static void Main(string[] args) {
            Application.Run(new Hello());
        }
    }
}
