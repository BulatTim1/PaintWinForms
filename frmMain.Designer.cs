//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22

namespace PaintSaveLoad
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlArtBoard = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddTriangle = new System.Windows.Forms.Button();
            this.btnAddRectangle = new System.Windows.Forms.Button();
            this.btnAddCircle = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArtBoard
            // 
            this.pnlArtBoard.BackColor = System.Drawing.SystemColors.Window;
            this.pnlArtBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArtBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlArtBoard.Name = "pnlArtBoard";
            this.pnlArtBoard.Size = new System.Drawing.Size(629, 450);
            this.pnlArtBoard.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnLoad);
            this.panelControls.Controls.Add(this.btnSave);
            this.panelControls.Controls.Add(this.btnAddTriangle);
            this.panelControls.Controls.Add(this.btnAddRectangle);
            this.panelControls.Controls.Add(this.btnAddCircle);
            this.panelControls.Controls.Add(this.btnAddLine);
            this.panelControls.Controls.Add(this.btnClear);
            this.panelControls.Controls.Add(this.btnDraw);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls.Location = new System.Drawing.Point(629, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(171, 450);
            this.panelControls.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(38, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click) + new System.EventHandler(this.btnDraw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddTriangle
            // 
            this.btnAddTriangle.Location = new System.Drawing.Point(29, 224);
            this.btnAddTriangle.Name = "btnAddTriangle";
            this.btnAddTriangle.Size = new System.Drawing.Size(94, 23);
            this.btnAddTriangle.TabIndex = 5;
            this.btnAddTriangle.Text = "Add Triangle";
            this.btnAddTriangle.UseVisualStyleBackColor = true;
            this.btnAddTriangle.Click += new System.EventHandler(this.btnAddTriangle_Click) + new System.EventHandler(this.btnDraw_Click);
            // 
            // btnAddRectangle
            // 
            this.btnAddRectangle.Location = new System.Drawing.Point(29, 195);
            this.btnAddRectangle.Name = "btnAddRectangle";
            this.btnAddRectangle.Size = new System.Drawing.Size(94, 23);
            this.btnAddRectangle.TabIndex = 4;
            this.btnAddRectangle.Text = "Add Rectangle";
            this.btnAddRectangle.UseVisualStyleBackColor = true;
            this.btnAddRectangle.Click += new System.EventHandler(this.btnAddRectangle_Click) + new System.EventHandler(this.btnDraw_Click);
            // 
            // btnAddCircle
            // 
            this.btnAddCircle.Location = new System.Drawing.Point(38, 166);
            this.btnAddCircle.Name = "btnAddCircle";
            this.btnAddCircle.Size = new System.Drawing.Size(75, 23);
            this.btnAddCircle.TabIndex = 3;
            this.btnAddCircle.Text = "Add Circle";
            this.btnAddCircle.UseVisualStyleBackColor = true;
            this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click) + new System.EventHandler(this.btnDraw_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(38, 137);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(75, 23);
            this.btnAddLine.TabIndex = 2;
            this.btnAddLine.Text = "Add Line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click) + new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "New";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click) + new System.EventHandler(this.btnDraw_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(38, 108);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Visible = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "save";
            this.saveDialog.FileName = "canvas";
            // 
            // loadDialog
            // 
            this.loadDialog.DefaultExt = "save";
            this.loadDialog.FileName = "canvas";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlArtBoard);
            this.Controls.Add(this.panelControls);
            this.Name = "frmMain";
            this.Text = "Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDraw_Click);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArtBoard;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddTriangle;
        private System.Windows.Forms.Button btnAddRectangle;
        private System.Windows.Forms.Button btnAddCircle;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog loadDialog;
    }
}

