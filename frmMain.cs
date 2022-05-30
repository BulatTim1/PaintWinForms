//Timurshin Bulat, 220 group, Geometric figures 3, 30.05.22

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            paper = pnlArtBoard.CreateGraphics();

            foreach(var figure in canvas.GetFigures())
            {
                figure.Draw(paper);
            }
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
                    string figureStr = form.TheValue;
                    var figure = canvas.Unserizalize(figureStr);
                    canvas.Add(figure);
                }
            }
            btnDraw_Click(sender, e);
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm(3))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string figureStr = form.TheValue;
                    var figure = canvas.Unserizalize(figureStr);
                    canvas.Add(figure);
                }
            }
            btnDraw_Click(sender, e);
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm(4))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string figureStr = form.TheValue;
                    var figure = canvas.Unserizalize(figureStr);
                    canvas.Add(figure);
                }
            }
            btnDraw_Click(sender, e);
        }

        private void btnAddTriangle_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm(5))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string figureStr = form.TheValue;
                    var figure = canvas.Unserizalize(figureStr);
                    canvas.Add(figure);
                }
            }
            btnDraw_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveDialog.FileName;
            canvas.Save(filename);
            MessageBox.Show("Файл сохранен");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (loadDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = loadDialog.FileName;
            canvas.Load(filename);
            btnDraw_Click(sender, e);
        }

        private void frmMain_ResizeEnd(Object sender, EventArgs e)
        {
            btnDraw_Click(sender, e);
        }
    }
}
