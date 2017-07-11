using System;
using System.Windows.Forms;

namespace Hello{
    public class Hello1:Form{
        public Hello1(){
            this.Text = "best 1 hello world";
        }
        public static void Main(){
            Application.Run(new Hello1());
        }
    }
}