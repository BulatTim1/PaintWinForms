//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
namespace PaintSaveLoad
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelAX = new System.Windows.Forms.Label();
            this.labelAY = new System.Windows.Forms.Label();
            this.labelBXorRadius = new System.Windows.Forms.Label();
            this.labelBY = new System.Windows.Forms.Label();
            this.labelCX = new System.Windows.Forms.Label();
            this.labelCY = new System.Windows.Forms.Label();
            this.labelFillColor = new System.Windows.Forms.Label();
            this.colorDialogFillColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogStrokeColor = new System.Windows.Forms.ColorDialog();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelStrokeColor = new System.Windows.Forms.Label();
            this.labelStrokeWidth = new System.Windows.Forms.Label();
            this.btnFillColorDialog = new System.Windows.Forms.Button();
            this.btnStrokeColorDialog = new System.Windows.Forms.Button();
            this.numAX = new System.Windows.Forms.NumericUpDown();
            this.numAY = new System.Windows.Forms.NumericUpDown();
            this.numBXorRadius = new System.Windows.Forms.NumericUpDown();
            this.numBY = new System.Windows.Forms.NumericUpDown();
            this.numCX = new System.Windows.Forms.NumericUpDown();
            this.numCY = new System.Windows.Forms.NumericUpDown();
            this.numStrokeWidth = new System.Windows.Forms.NumericUpDown();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXorRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrokeWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelAX
            // 
            this.labelAX.AutoSize = true;
            this.labelAX.Location = new System.Drawing.Point(3, 0);
            this.labelAX.Name = "labelAX";
            this.labelAX.Size = new System.Drawing.Size(70, 15);
            this.labelAX.TabIndex = 3;
            this.labelAX.Text = "First Point X";
            // 
            // labelAY
            // 
            this.labelAY.AutoSize = true;
            this.labelAY.Location = new System.Drawing.Point(3, 28);
            this.labelAY.Name = "labelAY";
            this.labelAY.Size = new System.Drawing.Size(70, 15);
            this.labelAY.TabIndex = 4;
            this.labelAY.Text = "First Point Y";
            // 
            // labelBXorRadius
            // 
            this.labelBXorRadius.AutoSize = true;
            this.labelBXorRadius.Location = new System.Drawing.Point(3, 57);
            this.labelBXorRadius.Name = "labelBXorRadius";
            this.labelBXorRadius.Size = new System.Drawing.Size(87, 15);
            this.labelBXorRadius.TabIndex = 5;
            this.labelBXorRadius.Text = "Second Point X";
            this.labelBXorRadius.Visible = false;
            // 
            // labelBY
            // 
            this.labelBY.AutoSize = true;
            this.labelBY.Location = new System.Drawing.Point(3, 89);
            this.labelBY.Name = "labelBY";
            this.labelBY.Size = new System.Drawing.Size(87, 15);
            this.labelBY.TabIndex = 6;
            this.labelBY.Text = "Second Point Y";
            this.labelBY.Visible = false;
            // 
            // labelCX
            // 
            this.labelCX.AutoSize = true;
            this.labelCX.Location = new System.Drawing.Point(3, 120);
            this.labelCX.Name = "labelCX";
            this.labelCX.Size = new System.Drawing.Size(75, 15);
            this.labelCX.TabIndex = 7;
            this.labelCX.Text = "Third Point X";
            this.labelCX.Visible = false;
            // 
            // labelCY
            // 
            this.labelCY.AutoSize = true;
            this.labelCY.Location = new System.Drawing.Point(3, 151);
            this.labelCY.Name = "labelCY";
            this.labelCY.Size = new System.Drawing.Size(75, 15);
            this.labelCY.TabIndex = 8;
            this.labelCY.Text = "Third Point Y";
            this.labelCY.Visible = false;
            // 
            // labelFillColor
            // 
            this.labelFillColor.AutoSize = true;
            this.labelFillColor.Location = new System.Drawing.Point(3, 181);
            this.labelFillColor.Name = "labelFillColor";
            this.labelFillColor.Size = new System.Drawing.Size(54, 15);
            this.labelFillColor.TabIndex = 9;
            this.labelFillColor.Text = "Fill Color";
            this.labelFillColor.Visible = false;
            // 
            // colorDialogFillColor
            // 
            this.colorDialogFillColor.AnyColor = true;
            this.colorDialogFillColor.Color = System.Drawing.Color.Transparent;
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.30233F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.69767F));
            this.tablePanel.Controls.Add(this.labelCY, 0, 5);
            this.tablePanel.Controls.Add(this.labelFillColor, 0, 6);
            this.tablePanel.Controls.Add(this.labelAX, 0, 0);
            this.tablePanel.Controls.Add(this.labelAY, 0, 1);
            this.tablePanel.Controls.Add(this.labelBXorRadius, 0, 2);
            this.tablePanel.Controls.Add(this.labelBY, 0, 3);
            this.tablePanel.Controls.Add(this.labelCX, 0, 4);
            this.tablePanel.Controls.Add(this.labelStrokeColor, 0, 7);
            this.tablePanel.Controls.Add(this.labelStrokeWidth, 0, 8);
            this.tablePanel.Controls.Add(this.btnFillColorDialog, 1, 6);
            this.tablePanel.Controls.Add(this.btnStrokeColorDialog, 1, 7);
            this.tablePanel.Controls.Add(this.numAX, 1, 0);
            this.tablePanel.Controls.Add(this.numAY, 1, 1);
            this.tablePanel.Controls.Add(this.numBXorRadius, 1, 2);
            this.tablePanel.Controls.Add(this.numBY, 1, 3);
            this.tablePanel.Controls.Add(this.numCX, 1, 4);
            this.tablePanel.Controls.Add(this.numCY, 1, 5);
            this.tablePanel.Controls.Add(this.numStrokeWidth, 1, 8);
            this.tablePanel.Location = new System.Drawing.Point(28, 12);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 9;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tablePanel.Size = new System.Drawing.Size(316, 284);
            this.tablePanel.TabIndex = 10;
            // 
            // labelStrokeColor
            // 
            this.labelStrokeColor.AutoSize = true;
            this.labelStrokeColor.Location = new System.Drawing.Point(3, 210);
            this.labelStrokeColor.Name = "labelStrokeColor";
            this.labelStrokeColor.Size = new System.Drawing.Size(72, 15);
            this.labelStrokeColor.TabIndex = 10;
            this.labelStrokeColor.Text = "Stroke Color";
            // 
            // labelStrokeWidth
            // 
            this.labelStrokeWidth.AutoSize = true;
            this.labelStrokeWidth.Location = new System.Drawing.Point(3, 239);
            this.labelStrokeWidth.Name = "labelStrokeWidth";
            this.labelStrokeWidth.Size = new System.Drawing.Size(75, 15);
            this.labelStrokeWidth.TabIndex = 11;
            this.labelStrokeWidth.Text = "Stroke Width";
            // 
            // btnFillColorDialog
            // 
            this.btnFillColorDialog.Location = new System.Drawing.Point(158, 184);
            this.btnFillColorDialog.Name = "btnFillColorDialog";
            this.btnFillColorDialog.Size = new System.Drawing.Size(100, 23);
            this.btnFillColorDialog.TabIndex = 17;
            this.btnFillColorDialog.Text = "Pick Color";
            this.btnFillColorDialog.UseVisualStyleBackColor = true;
            this.btnFillColorDialog.Visible = false;
            this.btnFillColorDialog.Click += new System.EventHandler(this.btnFillColorDialog_Click);
            // 
            // btnStrokeColorDialog
            // 
            this.btnStrokeColorDialog.Location = new System.Drawing.Point(158, 213);
            this.btnStrokeColorDialog.Name = "btnStrokeColorDialog";
            this.btnStrokeColorDialog.Size = new System.Drawing.Size(100, 23);
            this.btnStrokeColorDialog.TabIndex = 18;
            this.btnStrokeColorDialog.Text = "Pick Color";
            this.btnStrokeColorDialog.UseVisualStyleBackColor = true;
            this.btnStrokeColorDialog.Click += new System.EventHandler(this.btnStrokeColorDialog_Click);
            // 
            // numAX
            // 
            this.numAX.Location = new System.Drawing.Point(158, 3);
            this.numAX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAX.Name = "numAX";
            this.numAX.Size = new System.Drawing.Size(120, 23);
            this.numAX.TabIndex = 19;
            // 
            // numAY
            // 
            this.numAY.Location = new System.Drawing.Point(158, 31);
            this.numAY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAY.Name = "numAY";
            this.numAY.Size = new System.Drawing.Size(120, 23);
            this.numAY.TabIndex = 20;
            // 
            // numBXorRadius
            // 
            this.numBXorRadius.Location = new System.Drawing.Point(158, 60);
            this.numBXorRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBXorRadius.Name = "numBXorRadius";
            this.numBXorRadius.Size = new System.Drawing.Size(120, 23);
            this.numBXorRadius.TabIndex = 21;
            this.numBXorRadius.Visible = false;
            // 
            // numBY
            // 
            this.numBY.Location = new System.Drawing.Point(158, 92);
            this.numBY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBY.Name = "numBY";
            this.numBY.Size = new System.Drawing.Size(120, 23);
            this.numBY.TabIndex = 22;
            this.numBY.Visible = false;
            // 
            // numCX
            // 
            this.numCX.Location = new System.Drawing.Point(158, 123);
            this.numCX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCX.Name = "numCX";
            this.numCX.Size = new System.Drawing.Size(120, 23);
            this.numCX.TabIndex = 23;
            this.numCX.Visible = false;
            // 
            // numCY
            // 
            this.numCY.Location = new System.Drawing.Point(158, 154);
            this.numCY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCY.Name = "numCY";
            this.numCY.Size = new System.Drawing.Size(120, 23);
            this.numCY.TabIndex = 24;
            this.numCY.Visible = false;
            // 
            // numStrokeWidth
            // 
            this.numStrokeWidth.Location = new System.Drawing.Point(158, 242);
            this.numStrokeWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStrokeWidth.Name = "numStrokeWidth";
            this.numStrokeWidth.Size = new System.Drawing.Size(120, 23);
            this.numStrokeWidth.TabIndex = 25;
            this.numStrokeWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AddForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 340);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddForm";
            this.Text = "Add Figure";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXorRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrokeWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelAX;
        private System.Windows.Forms.Label labelAY;
        private System.Windows.Forms.Label labelBXorRadius;
        private System.Windows.Forms.Label labelBY;
        private System.Windows.Forms.Label labelCX;
        private System.Windows.Forms.Label labelCY;
        private System.Windows.Forms.Label labelFillColor;
        private System.Windows.Forms.ColorDialog colorDialogFillColor;
        private System.Windows.Forms.ColorDialog colorDialogStrokeColor;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Label labelStrokeColor;
        private System.Windows.Forms.Label labelStrokeWidth;
        private System.Windows.Forms.Button btnFillColorDialog;
        private System.Windows.Forms.Button btnStrokeColorDialog;
        private System.Windows.Forms.NumericUpDown numAX;
        private System.Windows.Forms.NumericUpDown numAY;
        private System.Windows.Forms.NumericUpDown numBXorRadius;
        private System.Windows.Forms.NumericUpDown numBY;
        private System.Windows.Forms.NumericUpDown numCX;
        private System.Windows.Forms.NumericUpDown numCY;
        private System.Windows.Forms.NumericUpDown numStrokeWidth;
    }
}