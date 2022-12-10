using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseDown += Form1_MouseDown;

        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            label1.Text = "NO";
            Debug.WriteLine("Cool!");
            label1.Text = "YES";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= "OK";
        }
    }
}