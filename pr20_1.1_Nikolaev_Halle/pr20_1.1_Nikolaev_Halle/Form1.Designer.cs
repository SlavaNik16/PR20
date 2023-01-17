namespace pr20_1._1_Nikolaev_Halle
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartBut = new System.Windows.Forms.Button();
            this.StopBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pr20_1._1_Nikolaev_Halle.Properties.Resources.бег3;
            this.pictureBox1.Location = new System.Drawing.Point(155, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartBut
            // 
            this.StartBut.BackColor = System.Drawing.Color.Lime;
            this.StartBut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBut.Location = new System.Drawing.Point(12, 12);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(137, 33);
            this.StartBut.TabIndex = 1;
            this.StartBut.Text = "Старт";
            this.StartBut.UseVisualStyleBackColor = false;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // StopBut
            // 
            this.StopBut.BackColor = System.Drawing.Color.Red;
            this.StopBut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBut.Location = new System.Drawing.Point(275, 12);
            this.StopBut.Name = "StopBut";
            this.StopBut.Size = new System.Drawing.Size(137, 33);
            this.StopBut.TabIndex = 2;
            this.StopBut.Text = "Стоп";
            this.StopBut.UseVisualStyleBackColor = false;
            this.StopBut.Click += new System.EventHandler(this.StopBut_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 176);
            this.Controls.Add(this.StopBut);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Анимация движения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button StartBut;
        private Button StopBut;
        private System.Windows.Forms.Timer timer1;
    }
}