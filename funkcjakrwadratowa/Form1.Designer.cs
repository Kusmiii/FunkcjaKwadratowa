namespace funkcjakrwadratowa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.abox = new System.Windows.Forms.TextBox();
            this.bbox = new System.Windows.Forms.TextBox();
            this.cbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.TextBox();
            this.x1Box = new System.Windows.Forms.TextBox();
            this.x2Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.napis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abox
            // 
            this.abox.Location = new System.Drawing.Point(295, 331);
            this.abox.Name = "abox";
            this.abox.Size = new System.Drawing.Size(100, 23);
            this.abox.TabIndex = 0;
            // 
            // bbox
            // 
            this.bbox.Location = new System.Drawing.Point(478, 331);
            this.bbox.Name = "bbox";
            this.bbox.Size = new System.Drawing.Size(100, 23);
            this.bbox.TabIndex = 1;
            // 
            // cbox
            // 
            this.cbox.Location = new System.Drawing.Point(664, 331);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(100, 23);
            this.cbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "c";
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(443, 191);
            this.d.Name = "d";
            this.d.ReadOnly = true;
            this.d.Size = new System.Drawing.Size(183, 23);
            this.d.TabIndex = 6;
            // 
            // x1Box
            // 
            this.x1Box.Location = new System.Drawing.Point(388, 257);
            this.x1Box.Name = "x1Box";
            this.x1Box.ReadOnly = true;
            this.x1Box.Size = new System.Drawing.Size(100, 23);
            this.x1Box.TabIndex = 7;
            // 
            // x2Box
            // 
            this.x2Box.Location = new System.Drawing.Point(578, 257);
            this.x2Box.Name = "x2Box";
            this.x2Box.ReadOnly = true;
            this.x2Box.Size = new System.Drawing.Size(100, 23);
            this.x2Box.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "x1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "x2";
            // 
            // napis
            // 
            this.napis.Location = new System.Drawing.Point(443, 162);
            this.napis.Name = "napis";
            this.napis.ReadOnly = true;
            this.napis.Size = new System.Drawing.Size(183, 23);
            this.napis.TabIndex = 11;
            this.napis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Policz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Delta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 537);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.napis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x2Box);
            this.Controls.Add(this.x1Box);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.bbox);
            this.Controls.Add(this.abox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox abox;
        private TextBox bbox;
        private TextBox cbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox d;
        private TextBox x1Box;
        private TextBox x2Box;
        private Label label4;
        private Label label5;
        private TextBox napis;
        private Button button1;
        private Label label6;
    }
}