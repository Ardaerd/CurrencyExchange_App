namespace CurrencyExchange_App
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
            this.comboBox_Currency_2 = new System.Windows.Forms.ComboBox();
            this.Currency_2 = new System.Windows.Forms.NumericUpDown();
            this.Currency_1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Currency_1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Currency_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Currency_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Currency_2
            // 
            this.comboBox_Currency_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Currency_2.FormattingEnabled = true;
            this.comboBox_Currency_2.Location = new System.Drawing.Point(199, 250);
            this.comboBox_Currency_2.Name = "comboBox_Currency_2";
            this.comboBox_Currency_2.Size = new System.Drawing.Size(78, 30);
            this.comboBox_Currency_2.TabIndex = 0;
            this.comboBox_Currency_2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Currency_2_SelectedIndexChanged);
            // 
            // Currency_2
            // 
            this.Currency_2.DecimalPlaces = 2;
            this.Currency_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currency_2.Location = new System.Drawing.Point(84, 250);
            this.Currency_2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Currency_2.Name = "Currency_2";
            this.Currency_2.Size = new System.Drawing.Size(109, 28);
            this.Currency_2.TabIndex = 3;
            this.Currency_2.ValueChanged += new System.EventHandler(this.Currency_2_ValueChanged);
            // 
            // Currency_1
            // 
            this.Currency_1.DecimalPlaces = 2;
            this.Currency_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currency_1.Location = new System.Drawing.Point(84, 24);
            this.Currency_1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Currency_1.Name = "Currency_1";
            this.Currency_1.Size = new System.Drawing.Size(109, 28);
            this.Currency_1.TabIndex = 5;
            this.Currency_1.ValueChanged += new System.EventHandler(this.Currency_1_ValueChanged);
            // 
            // comboBox_Currency_1
            // 
            this.comboBox_Currency_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Currency_1.FormattingEnabled = true;
            this.comboBox_Currency_1.Location = new System.Drawing.Point(199, 24);
            this.comboBox_Currency_1.Name = "comboBox_Currency_1";
            this.comboBox_Currency_1.Size = new System.Drawing.Size(78, 30);
            this.comboBox_Currency_1.TabIndex = 4;
            this.comboBox_Currency_1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Currency_1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(406, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Currency_1);
            this.Controls.Add(this.comboBox_Currency_1);
            this.Controls.Add(this.Currency_2);
            this.Controls.Add(this.comboBox_Currency_2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Currency_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Currency_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Currency_2;
        private System.Windows.Forms.NumericUpDown Currency_2;
        private System.Windows.Forms.NumericUpDown Currency_1;
        private System.Windows.Forms.ComboBox comboBox_Currency_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

