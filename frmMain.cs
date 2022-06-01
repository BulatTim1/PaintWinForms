//Timurshin Bulat, 220 group, Geometric figures 3, 30.05.22

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintSaveLoad
{
    public partial class frmMain : Form
    {
        Graphics paper;
        Canvas canvas = new Canvas();

        public frmMain()
        {
            InitializeComponent();
            canvas = new Canvas();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            canvas.Clear();
            paper.Clear(Color.White);
            paper.Dispose();
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm(1))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Figure figure = form.TempFigure;
                    canvas.Add(figure);
                }
            }
            Draw();
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm(3))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Figure figure = form.TempFigure;
                    canvas.Add(figure);
                }
            }
            Draw();
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm(4))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Figure figure = form.TempFigure;
                    canvas.Add(figure);
                }
            }
            Draw();
        }

        private void btnAddTriangle_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm(5))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Figure figure = form.TempFigure;
                    canvas.Add(figure);
                }
            }
            Draw();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveDialog.FileName;
            canvas.Save(filename);
            MessageBox.Show("File saved.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (loadDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = loadDialog.FileName;
            try
            {
                canvas.Load(filename);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Bad savefile.");
            }
            Draw();
        }

        private void frmMain_Paint(Object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            paper = pnlArtBoard.CreateGraphics();

            foreach (var figure in canvas.GetFigures())
            {
                figure.Draw(paper);
            }
        }
}
}
