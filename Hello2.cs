using System;
using System.Drawing;
using System.Windows.Forms;

public class Hello2 : Form {
    public Hello2() {
        this.Text = "最好的窗口示例啊";
        this.Size = new Size(400,300);
    }
}

public class MainClass {
    public static void Main() {
        Application.Run(new Hello2());
    }
}