using System;
using System.Drawing;
using System.Windows.Forms;

public class Hello2 : Form {
    public Hello2() {
        this.Text = "简单示例";
        this.Size = new Size(400, 300);

        Button button = new Button();
        button.Location = new Point(30, 20);
        button.Text = "close"; //汉字有乱码
        button.Click += new EventHandler(this.onClick);
        button.MouseEnter += new EventHandler(this.onEnter);
        this.Controls.Add(button);
        this.CenterToScreen();
    }

    void onClick(Object sender, EventArgs e) {
        this.Close();
    }

    void onEnter(Object sender, EventArgs e) {
        Console.WriteLine("mouse enter");
    }
}

public class MainClass {
    public static void Main() {
        Application.Run(new Hello2());
    }
}