//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintSaveLoad
{
    public partial class frmMain : Form
    {
        Graphics paper;
        readonly Canvas canvas = new Canvas();

        public frmMain()
        {
            InitializeComponent();
            canvas = new Canvas();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }

        /// <param name="type">
        /// Don't use 0 - Figure
        /// 1 - Line
        /// Don't use 2 - FilledFigure
        /// 3 - Circle
        /// 4 - Rectangle
        /// 5 - Triangle
        /// </param>
        private void btnClick(int type)
        {
            using (var form = new AddForm(type))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Figure figure = form.TempFigure;
                    canvas.Add(figure);
                }
            }
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
            btnClick(1);
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            btnClick(3);
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            btnClick(4);
        }

        private void btnAddTriangle_Click(object sender, EventArgs e)
        {
            btnClick(5);
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
