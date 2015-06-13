namespace ShapeGame
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grbPlay = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayMessage = new System.Windows.Forms.Label();
            this.ptcGameShape2 = new System.Windows.Forms.PictureBox();
            this.ptcGameShape1 = new System.Windows.Forms.PictureBox();
            this.ptcGameNatural2 = new System.Windows.Forms.PictureBox();
            this.ptcGameShape3 = new System.Windows.Forms.PictureBox();
            this.ptcGameNatural3 = new System.Windows.Forms.PictureBox();
            this.ptcGameNatural1 = new System.Windows.Forms.PictureBox();
            this.grbLearn = new System.Windows.Forms.GroupBox();
            this.ptcNatural1 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblShapeName = new System.Windows.Forms.Label();
            this.ptcNatural3 = new System.Windows.Forms.PictureBox();
            this.ptcNatural2 = new System.Windows.Forms.PictureBox();
            this.ptcShape = new System.Windows.Forms.PictureBox();
            this.tmrHelp = new System.Windows.Forms.Timer(this.components);
            this.btnEndGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grbPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameShape2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameShape1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameNatural2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameShape3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameNatural3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameNatural1)).BeginInit();
            this.grbLearn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNatural1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNatural3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNatural2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcShape)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMode.Location = new System.Drawing.Point(0, 0);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(784, 66);
            this.btnChangeMode.TabIndex = 1;
            this.btnChangeMode.Text = "تغير للتدريب";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 66);
            this.panel1.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grbPlay);
            this.pnlMain.Controls.Add(this.grbLearn);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 66);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 495);
            this.pnlMain.TabIndex = 4;
            // 
            // grbPlay
            // 
            this.grbPlay.Controls.Add(this.lblTime);
            this.grbPlay.Controls.Add(this.lblPlayMessage);
            this.grbPlay.Controls.Add(this.ptcGameShape2);
            this.grbPlay.Controls.Add(this.ptcGameShape1);
            this.grbPlay.Controls.Add(this.ptcGameNatural2);
            this.grbPlay.Controls.Add(this.ptcGameShape3);
            this.grbPlay.Controls.Add(this.ptcGameNatural3);
            this.grbPlay.Controls.Add(this.ptcGameNatural1);
            this.grbPlay.Controls.Add(this.btnEndGame);
            this.grbPlay.Controls.Add(this.btnStart);
            this.grbPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPlay.Location = new System.Drawing.Point(0, 0);
            this.grbPlay.Name = "grbPlay";
            this.grbPlay.Size = new System.Drawing.Size(784, 495);
            this.grbPlay.TabIndex = 5;
            this.grbPlay.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(353, 438);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 25);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(353, 218);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "ابدء";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayMessage
            // 
            this.lblPlayMessage.AutoSize = true;
            this.lblPlayMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayMessage.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPlayMessage.Location = new System.Drawing.Point(222, 25);
            this.lblPlayMessage.Name = "lblPlayMessage";
            this.lblPlayMessage.Size = new System.Drawing.Size(315, 25);
            this.lblPlayMessage.TabIndex = 4;
            this.lblPlayMessage.Text = "أسحب الصور تحت أو فوق الشكل المناسب.";
            // 
            // ptcGameShape2
            // 
            this.ptcGameShape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcGameShape2.Location = new System.Drawing.Point(281, 66);
            this.ptcGameShape2.Name = "ptcGameShape2";
            this.ptcGameShape2.Size = new System.Drawing.Size(198, 122);
            this.ptcGameShape2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcGameShape2.TabIndex = 3;
            this.ptcGameShape2.TabStop = false;
            // 
            // ptcGameShape1
            // 
            this.ptcGameShape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcGameShape1.Location = new System.Drawing.Point(494, 66);
            this.ptcGameShape1.Name = "ptcGameShape1";
            this.ptcGameShape1.Size = new System.Drawing.Size(198, 122);
            this.ptcGameShape1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcGameShape1.TabIndex = 1;
            this.ptcGameShape1.TabStop = false;
            // 
            // ptcGameNatural2
            // 
            this.ptcGameNatural2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcGameNatural2.Location = new System.Drawing.Point(281, 279);
            this.ptcGameNatural2.Name = "ptcGameNatural2";
            this.ptcGameNatural2.Size = new System.Drawing.Size(198, 122);
            this.ptcGameNatural2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcGameNatural2.TabIndex = 3;
            this.ptcGameNatural2.TabStop = false;
            // 
            // ptcGameShape3
            // 
            this.ptcGameShape3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcGameShape3.Location = new System.Drawing.Point(66, 66);
            this.ptcGameShape3.Name = "ptcGameShape3";
            this.ptcGameShape3.Size = new System.Drawing.Size(198, 122);
            this.ptcGameShape3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcGameShape3.TabIndex = 2;
            this.ptcGameShape3.TabStop = false;
            // 
            // ptcGameNatural3
            // 
            this.ptcGameNatural3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcGameNatural3.Location = new System.Drawing.Point(66, 279);
            this.ptcGameNatural3.Name = "ptcGameNatural3";
            this.ptcGameNatural3.Size = new System.Drawing.Size(198, 122);
            this.ptcGameNatural3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcGameNatural3.TabIndex = 2;
            this.ptcGameNatural3.TabStop = false;
            // 
            // ptcGameNatural1
            // 
            this.ptcGameNatural1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcGameNatural1.Location = new System.Drawing.Point(494, 279);
            this.ptcGameNatural1.Name = "ptcGameNatural1";
            this.ptcGameNatural1.Size = new System.Drawing.Size(198, 122);
            this.ptcGameNatural1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcGameNatural1.TabIndex = 1;
            this.ptcGameNatural1.TabStop = false;
            // 
            // grbLearn
            // 
            this.grbLearn.Controls.Add(this.ptcNatural1);
            this.grbLearn.Controls.Add(this.btnNext);
            this.grbLearn.Controls.Add(this.btnPrev);
            this.grbLearn.Controls.Add(this.lblShapeName);
            this.grbLearn.Controls.Add(this.ptcNatural3);
            this.grbLearn.Controls.Add(this.ptcNatural2);
            this.grbLearn.Controls.Add(this.ptcShape);
            this.grbLearn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbLearn.Location = new System.Drawing.Point(0, 0);
            this.grbLearn.Name = "grbLearn";
            this.grbLearn.Size = new System.Drawing.Size(784, 495);
            this.grbLearn.TabIndex = 4;
            this.grbLearn.TabStop = false;
            this.grbLearn.Text = "لاحظ وتعلم الاشكال";
            this.grbLearn.Visible = false;
            // 
            // ptcNatural1
            // 
            this.ptcNatural1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcNatural1.Location = new System.Drawing.Point(496, 228);
            this.ptcNatural1.Name = "ptcNatural1";
            this.ptcNatural1.Size = new System.Drawing.Size(198, 122);
            this.ptcNatural1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNatural1.TabIndex = 0;
            this.ptcNatural1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(138, 407);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(128, 45);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "الشكل التالي";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(496, 407);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(128, 45);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "الشكل السابق";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblShapeName
            // 
            this.lblShapeName.AutoSize = true;
            this.lblShapeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShapeName.ForeColor = System.Drawing.Color.Red;
            this.lblShapeName.Location = new System.Drawing.Point(372, 181);
            this.lblShapeName.Name = "lblShapeName";
            this.lblShapeName.Size = new System.Drawing.Size(0, 25);
            this.lblShapeName.TabIndex = 1;
            // 
            // ptcNatural3
            // 
            this.ptcNatural3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcNatural3.Location = new System.Drawing.Point(68, 228);
            this.ptcNatural3.Name = "ptcNatural3";
            this.ptcNatural3.Size = new System.Drawing.Size(198, 122);
            this.ptcNatural3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNatural3.TabIndex = 0;
            this.ptcNatural3.TabStop = false;
            // 
            // ptcNatural2
            // 
            this.ptcNatural2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcNatural2.Location = new System.Drawing.Point(283, 228);
            this.ptcNatural2.Name = "ptcNatural2";
            this.ptcNatural2.Size = new System.Drawing.Size(198, 122);
            this.ptcNatural2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNatural2.TabIndex = 0;
            this.ptcNatural2.TabStop = false;
            // 
            // ptcShape
            // 
            this.ptcShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptcShape.Location = new System.Drawing.Point(283, 36);
            this.ptcShape.Name = "ptcShape";
            this.ptcShape.Size = new System.Drawing.Size(198, 122);
            this.ptcShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcShape.TabIndex = 0;
            this.ptcShape.TabStop = false;
            // 
            // tmrHelp
            // 
            this.tmrHelp.Interval = 1000;
            this.tmrHelp.Tick += new System.EventHandler(this.tmrHelp_Tick);
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(353, 218);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(75, 23);
            this.btnEndGame.TabIndex = 5;
            this.btnEndGame.Text = "انهاء";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
                // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لعبة الاشكال";
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.grbPlay.ResumeLayout(false);
            this.grbPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameShape2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameShape1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameNatural2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameShape3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameNatural3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGameNatural1)).EndInit();
            this.grbLearn.ResumeLayout(false);
            this.grbLearn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNatural1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNatural3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNatural2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcShape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grbLearn;
        private System.Windows.Forms.PictureBox ptcNatural1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblShapeName;
        private System.Windows.Forms.PictureBox ptcNatural3;
        private System.Windows.Forms.PictureBox ptcNatural2;
        private System.Windows.Forms.PictureBox ptcShape;
        private System.Windows.Forms.GroupBox grbPlay;
        private System.Windows.Forms.Label lblPlayMessage;
        private System.Windows.Forms.PictureBox ptcGameShape2;
        private System.Windows.Forms.PictureBox ptcGameShape1;
        private System.Windows.Forms.PictureBox ptcGameNatural2;
        private System.Windows.Forms.PictureBox ptcGameShape3;
        private System.Windows.Forms.PictureBox ptcGameNatural3;
        private System.Windows.Forms.PictureBox ptcGameNatural1;
        private System.Windows.Forms.Timer tmrHelp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEndGame;
    }
}

