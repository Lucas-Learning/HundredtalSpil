namespace HundredtalSpil
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
            this.textAdd10 = new System.Windows.Forms.TextBox();
            this.textRemove10 = new System.Windows.Forms.TextBox();
            this.textAdd1 = new System.Windows.Forms.TextBox();
            this.textRemove1 = new System.Windows.Forms.TextBox();
            this.RandomNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAdd10
            // 
            this.textAdd10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdd10.Location = new System.Drawing.Point(588, 55);
            this.textAdd10.Name = "textAdd10";
            this.textAdd10.Size = new System.Drawing.Size(125, 44);
            this.textAdd10.TabIndex = 0;
            this.textAdd10.Text = "0";
            this.textAdd10.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textAdd10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdd10_KeyPress);
            // 
            // textRemove10
            // 
            this.textRemove10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRemove10.Location = new System.Drawing.Point(588, 271);
            this.textRemove10.Name = "textRemove10";
            this.textRemove10.Size = new System.Drawing.Size(125, 44);
            this.textRemove10.TabIndex = 1;
            this.textRemove10.Text = "0";
            this.textRemove10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRemove10_KeyPress);
            // 
            // textAdd1
            // 
            this.textAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdd1.Location = new System.Drawing.Point(762, 167);
            this.textAdd1.Name = "textAdd1";
            this.textAdd1.Size = new System.Drawing.Size(125, 44);
            this.textAdd1.TabIndex = 2;
            this.textAdd1.Text = "0";
            this.textAdd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdd1_KeyPress);
            // 
            // textRemove1
            // 
            this.textRemove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRemove1.Location = new System.Drawing.Point(423, 167);
            this.textRemove1.Name = "textRemove1";
            this.textRemove1.Size = new System.Drawing.Size(125, 44);
            this.textRemove1.TabIndex = 3;
            this.textRemove1.Text = "0";
            this.textRemove1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRemove1_KeyPress);
            // 
            // RandomNumber
            // 
            this.RandomNumber.AutoSize = true;
            this.RandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomNumber.Location = new System.Drawing.Point(618, 172);
            this.RandomNumber.Name = "RandomNumber";
            this.RandomNumber.Size = new System.Drawing.Size(63, 33);
            this.RandomNumber.TabIndex = 4;
            this.RandomNumber.Text = "N/A";
            this.RandomNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1099, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Points:";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(1145, 70);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(13, 13);
            this.Points.TabIndex = 6;
            this.Points.Text = "0";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(1025, 420);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 7;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandomNumber);
            this.Controls.Add(this.textRemove1);
            this.Controls.Add(this.textAdd1);
            this.Controls.Add(this.textRemove10);
            this.Controls.Add(this.textAdd10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAdd10;
        private System.Windows.Forms.TextBox textRemove10;
        private System.Windows.Forms.TextBox textAdd1;
        private System.Windows.Forms.TextBox textRemove1;
        private System.Windows.Forms.Label RandomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button button1;
    }
}

