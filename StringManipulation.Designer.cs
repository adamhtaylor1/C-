namespace StringManip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backwardsLabel = new System.Windows.Forms.Label();
            this.capsLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.charLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(164, 12);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(467, 20);
            this.inputTextbox.TabIndex = 0;
            this.inputTextbox.Text = "HankySpanky";
            this.inputTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Text :";
            // 
            // backwardsLabel
            // 
            this.backwardsLabel.AutoSize = true;
            this.backwardsLabel.Location = new System.Drawing.Point(164, 39);
            this.backwardsLabel.Name = "backwardsLabel";
            this.backwardsLabel.Size = new System.Drawing.Size(60, 13);
            this.backwardsLabel.TabIndex = 2;
            this.backwardsLabel.Text = "Backwards";
            // 
            // capsLabel
            // 
            this.capsLabel.AutoSize = true;
            this.capsLabel.Location = new System.Drawing.Point(164, 52);
            this.capsLabel.Name = "capsLabel";
            this.capsLabel.Size = new System.Drawing.Size(47, 13);
            this.capsLabel.TabIndex = 3;
            this.capsLabel.Text = "Random";
            this.capsLabel.Click += new System.EventHandler(this.reverseLabel_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(681, 365);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(90, 63);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "&Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Location = new System.Drawing.Point(164, 65);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(54, 13);
            this.charLabel.TabIndex = 5;
            this.charLabel.Text = "Numerical";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 156);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StringManip.Properties.Resources.bruvh;
            this.pictureBox2.Location = new System.Drawing.Point(530, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 263);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.capsLabel);
            this.Controls.Add(this.backwardsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backwardsLabel;
        private System.Windows.Forms.Label capsLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

