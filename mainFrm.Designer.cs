namespace AtropatBaseMathCalc
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.radRectangle = new System.Windows.Forms.RadioButton();
            this.radTriangle = new System.Windows.Forms.RadioButton();
            this.radCircle = new System.Windows.Forms.RadioButton();
            this.grBoxShapes = new System.Windows.Forms.GroupBox();
            this.grBoxCalc = new System.Windows.Forms.GroupBox();
            this.radVolume = new System.Windows.Forms.RadioButton();
            this.radArea = new System.Windows.Forms.RadioButton();
            this.radPeri = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.grBoxShapes.SuspendLayout();
            this.grBoxCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radRectangle
            // 
            this.radRectangle.AutoSize = true;
            this.radRectangle.Location = new System.Drawing.Point(20, 32);
            this.radRectangle.Name = "radRectangle";
            this.radRectangle.Size = new System.Drawing.Size(108, 33);
            this.radRectangle.TabIndex = 0;
            this.radRectangle.TabStop = true;
            this.radRectangle.Text = "Rectangle";
            this.radRectangle.UseVisualStyleBackColor = true;
            this.radRectangle.CheckedChanged += new System.EventHandler(this.radRectangle_CheckedChanged);
            // 
            // radTriangle
            // 
            this.radTriangle.AutoSize = true;
            this.radTriangle.Location = new System.Drawing.Point(20, 110);
            this.radTriangle.Name = "radTriangle";
            this.radTriangle.Size = new System.Drawing.Size(96, 33);
            this.radTriangle.TabIndex = 1;
            this.radTriangle.TabStop = true;
            this.radTriangle.Text = "Triangle";
            this.radTriangle.UseVisualStyleBackColor = true;
            this.radTriangle.CheckedChanged += new System.EventHandler(this.radTriangle_CheckedChanged);
            // 
            // radCircle
            // 
            this.radCircle.AutoSize = true;
            this.radCircle.Location = new System.Drawing.Point(20, 71);
            this.radCircle.Name = "radCircle";
            this.radCircle.Size = new System.Drawing.Size(80, 33);
            this.radCircle.TabIndex = 2;
            this.radCircle.TabStop = true;
            this.radCircle.Text = "Circle";
            this.radCircle.UseVisualStyleBackColor = true;
            this.radCircle.CheckedChanged += new System.EventHandler(this.radCircle_CheckedChanged);
            // 
            // grBoxShapes
            // 
            this.grBoxShapes.Controls.Add(this.radCircle);
            this.grBoxShapes.Controls.Add(this.radRectangle);
            this.grBoxShapes.Controls.Add(this.radTriangle);
            this.grBoxShapes.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxShapes.ForeColor = System.Drawing.Color.Black;
            this.grBoxShapes.Location = new System.Drawing.Point(39, 48);
            this.grBoxShapes.Name = "grBoxShapes";
            this.grBoxShapes.Size = new System.Drawing.Size(252, 236);
            this.grBoxShapes.TabIndex = 3;
            this.grBoxShapes.TabStop = false;
            this.grBoxShapes.Text = "Shapes";
            // 
            // grBoxCalc
            // 
            this.grBoxCalc.Controls.Add(this.radVolume);
            this.grBoxCalc.Controls.Add(this.radArea);
            this.grBoxCalc.Controls.Add(this.radPeri);
            this.grBoxCalc.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCalc.ForeColor = System.Drawing.Color.Black;
            this.grBoxCalc.Location = new System.Drawing.Point(618, 48);
            this.grBoxCalc.Name = "grBoxCalc";
            this.grBoxCalc.Size = new System.Drawing.Size(252, 236);
            this.grBoxCalc.TabIndex = 4;
            this.grBoxCalc.TabStop = false;
            this.grBoxCalc.Text = "Operations";
            // 
            // radVolume
            // 
            this.radVolume.AutoSize = true;
            this.radVolume.Location = new System.Drawing.Point(20, 110);
            this.radVolume.Name = "radVolume";
            this.radVolume.Size = new System.Drawing.Size(92, 33);
            this.radVolume.TabIndex = 2;
            this.radVolume.TabStop = true;
            this.radVolume.Text = "Volume";
            this.radVolume.UseVisualStyleBackColor = true;
            this.radVolume.CheckedChanged += new System.EventHandler(this.radVolume_CheckedChanged);
            // 
            // radArea
            // 
            this.radArea.AutoSize = true;
            this.radArea.Location = new System.Drawing.Point(20, 32);
            this.radArea.Name = "radArea";
            this.radArea.Size = new System.Drawing.Size(69, 33);
            this.radArea.TabIndex = 0;
            this.radArea.TabStop = true;
            this.radArea.Text = "Area";
            this.radArea.UseVisualStyleBackColor = true;
            this.radArea.CheckedChanged += new System.EventHandler(this.radArea_CheckedChanged);
            // 
            // radPeri
            // 
            this.radPeri.AutoSize = true;
            this.radPeri.Location = new System.Drawing.Point(20, 71);
            this.radPeri.Name = "radPeri";
            this.radPeri.Size = new System.Drawing.Size(107, 33);
            this.radPeri.TabIndex = 1;
            this.radPeri.TabStop = true;
            this.radPeri.Text = "Perimeter";
            this.radPeri.UseVisualStyleBackColor = true;
            this.radPeri.CheckedChanged += new System.EventHandler(this.radPeri_CheckedChanged);
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtA.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtA.Location = new System.Drawing.Point(59, 357);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(340, 34);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtB.Location = new System.Drawing.Point(59, 397);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(340, 34);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(28, 359);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 29);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(28, 399);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(27, 29);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "b:";
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.White;
            this.btnRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Location = new System.Drawing.Point(739, 543);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(130, 47);
            this.btnRes.TabIndex = 3;
            this.btnRes.Text = "Calculate";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(29, 439);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 29);
            this.lblC.TabIndex = 11;
            this.lblC.Text = "c:";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtC.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtC.Location = new System.Drawing.Point(59, 437);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(340, 34);
            this.txtC.TabIndex = 2;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRes.Font = new System.Drawing.Font("Arabic Typesetting", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRes.Location = new System.Drawing.Point(12, 545);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(721, 44);
            this.txtRes.TabIndex = 4;
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(405, 359);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 29);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.Image = global::AtropatBaseMathCalc.Properties.Resources.box_calc_r2_removebg_preview_removebg_preview;
            this.picBox.Location = new System.Drawing.Point(297, 36);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(315, 278);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 14;
            this.picBox.TabStop = false;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr.Location = new System.Drawing.Point(321, 513);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(173, 29);
            this.lblErr.TabIndex = 15;
            this.lblErr.Text = "This is not a triangle";
            this.lblErr.Visible = false;
            // 
            // mainFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 603);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.grBoxCalc);
            this.Controls.Add(this.grBoxShapes);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Text = "Geometric Calculator";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.grBoxShapes.ResumeLayout(false);
            this.grBoxShapes.PerformLayout();
            this.grBoxCalc.ResumeLayout(false);
            this.grBoxCalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRectangle;
        private System.Windows.Forms.RadioButton radTriangle;
        private System.Windows.Forms.RadioButton radCircle;
        private System.Windows.Forms.GroupBox grBoxShapes;
        private System.Windows.Forms.GroupBox grBoxCalc;
        private System.Windows.Forms.RadioButton radVolume;
        private System.Windows.Forms.RadioButton radArea;
        private System.Windows.Forms.RadioButton radPeri;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblErr;
    }
}

