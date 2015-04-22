using System;
using System.Drawing;
using System.Windows.Forms;

namespace JohnBryce
{
    public partial class MainForm : JohnBryce.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShapesTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int indicator = rnd.Next(1, 5);
            switch (indicator)
            {
                case 1:
                    Square square = new Square(new Coordinate(rnd.Next(300, ClientRectangle.Width - 300), rnd.Next(300, ClientRectangle.Height - 300)),
                        Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), rnd.Next(11), rnd.Next(600));
                    Graphics s = CreateGraphics();
                    square.Draw(s);
                    break;
                case 2:
                    Rectangle rectangle = new Rectangle(new Coordinate(rnd.Next(300, ClientRectangle.Width - 300), rnd.Next(300, ClientRectangle.Height - 300)),
                        Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), rnd.Next(11), rnd.Next(600), rnd.Next(600));
                    Graphics r = CreateGraphics();
                    rectangle.Draw(r);
                    break;
                case 3:
                    Circle circle = new Circle(new Coordinate(rnd.Next(300, ClientRectangle.Width - 300), rnd.Next(300, ClientRectangle.Height - 300)),
                    Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), rnd.Next(11), rnd.Next(300));
                    Graphics c = CreateGraphics();
                    circle.Draw(c);
                    break;
                default:
                    Elipse elipse = new Elipse(new Coordinate(rnd.Next(300, ClientRectangle.Width - 300), rnd.Next(300, ClientRectangle.Height - 300)),
                            Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), rnd.Next(11), rnd.Next(300), rnd.Next(300));
                    Graphics el = CreateGraphics();
                    elipse.Draw(el);
                    break;
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void שנהאתצבעהרקעToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = backGroundColorDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
                BackColor = backGroundColorDialog.Color;
        }

        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void הצגחלוןעזרהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hlf = new HelpForm();
            hlf.Show();
        }

        private void אודותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abf = new AboutForm();
            abf.Show();
        }
    }
}
