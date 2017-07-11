using System;
using System.Windows.Forms;

public class Hello2 : Form {
    public Hello2() {
        this.Text = "最好的窗口示例啊";
    }
    public static void Main() {
        Application.Run(new Hello2());
    }
}