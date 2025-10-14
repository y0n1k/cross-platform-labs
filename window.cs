using System;
using System.Windows.Forms;
public class HelloForm
{
    public static int Main()
    {
        Form fm = new Form();
        Button btn = new Button();
        btn.Text = "Click me";
        btn.Top = 150;
        btn.Left = 100;

        btn.Click += (sender, e) =>
        {
            MessageBox.Show("Deleting System32 folder...");
        };
        fm.Controls.Add(btn);
        fm.ShowDialog();
        return 0;
    }
}