namespace WinFormsCalculator
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.decimal1 = new System.Windows.Forms.Button();
            this.clear1 = new System.Windows.Forms.Button();
            this.plus1 = new System.Windows.Forms.Button();
            this.minus1 = new System.Windows.Forms.Button();
            this.times1 = new System.Windows.Forms.Button();
            this.divide1 = new System.Windows.Forms.Button();
            this.equals1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(330, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number1.Location = new System.Drawing.Point(12, 198);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(78, 36);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(UniversalClick);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number2.Location = new System.Drawing.Point(96, 198);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(78, 36);
            this.number2.TabIndex = 2;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(UniversalClick);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number3.Location = new System.Drawing.Point(180, 198);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(78, 36);
            this.number3.TabIndex = 3;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(UniversalClick);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number4.Location = new System.Drawing.Point(12, 156);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(78, 36);
            this.number4.TabIndex = 4;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(UniversalClick);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number5.Location = new System.Drawing.Point(96, 156);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(78, 36);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(UniversalClick);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number6.Location = new System.Drawing.Point(180, 156);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(78, 36);
            this.number6.TabIndex = 6;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(UniversalClick);
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number7.Location = new System.Drawing.Point(12, 114);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(78, 36);
            this.number7.TabIndex = 7;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(UniversalClick);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number8.Location = new System.Drawing.Point(96, 114);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(78, 36);
            this.number8.TabIndex = 8;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(UniversalClick);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number9.Location = new System.Drawing.Point(180, 114);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(78, 36);
            this.number9.TabIndex = 9;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(UniversalClick);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.number0.Location = new System.Drawing.Point(12, 240);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(162, 36);
            this.number0.TabIndex = 0;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(UniversalClick);
            // 
            // decimal1
            // 
            this.decimal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decimal1.Location = new System.Drawing.Point(180, 240);
            this.decimal1.Name = "decimal1";
            this.decimal1.Size = new System.Drawing.Size(78, 36);
            this.decimal1.TabIndex = 10;
            this.decimal1.Text = ".";
            this.decimal1.UseVisualStyleBackColor = true;
            this.decimal1.Click += new System.EventHandler(UniversalClick);
            // 
            // clear1
            // 
            this.clear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.clear1.Location = new System.Drawing.Point(180, 72);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(78, 36);
            this.clear1.TabIndex = 10;
            this.clear1.Text = "C";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(UniversalClick);
            // 
            // plus1
            // 
            this.plus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plus1.Location = new System.Drawing.Point(264, 72);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(78, 36);
            this.plus1.TabIndex = 10;
            this.plus1.Text = "+";
            this.plus1.UseVisualStyleBackColor = true;
            this.plus1.Click += new System.EventHandler(UniversalClick);
            // 
            // minus1
            // 
            this.minus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.minus1.Location = new System.Drawing.Point(264, 114);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(78, 36);
            this.minus1.TabIndex = 10;
            this.minus1.Text = "-";
            this.minus1.UseVisualStyleBackColor = true;
            this.minus1.Click += new System.EventHandler(UniversalClick);
            // 
            // times1
            // 
            this.times1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.times1.Location = new System.Drawing.Point(264, 156);
            this.times1.Name = "times1";
            this.times1.Size = new System.Drawing.Size(78, 36);
            this.times1.TabIndex = 10;
            this.times1.Text = "*";
            this.times1.UseVisualStyleBackColor = true;
            this.times1.Click += new System.EventHandler(UniversalClick);
            // 
            // divide1
            // 
            this.divide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.divide1.Location = new System.Drawing.Point(264, 198);
            this.divide1.Name = "divide1";
            this.divide1.Size = new System.Drawing.Size(78, 36);
            this.divide1.TabIndex = 10;
            this.divide1.Text = "/";
            this.divide1.UseVisualStyleBackColor = true;
            this.divide1.Click += new System.EventHandler(UniversalClick);
            // 
            // equals1
            // 
            this.equals1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equals1.Location = new System.Drawing.Point(264, 240);
            this.equals1.Name = "equals1";
            this.equals1.Size = new System.Drawing.Size(78, 36);
            this.equals1.TabIndex = 10;
            this.equals1.Text = "=";
            this.equals1.UseVisualStyleBackColor = true;
            this.equals1.Click += new System.EventHandler(UniversalClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 292);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.equals1);
            this.Controls.Add(this.divide1);
            this.Controls.Add(this.times1);
            this.Controls.Add(this.minus1);
            this.Controls.Add(this.plus1);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.decimal1);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "WinForms Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button decimal1;
        private System.Windows.Forms.Button divide1;
        private System.Windows.Forms.Button equals1;
        private System.Windows.Forms.Button minus1;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button plus1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button times1;
    }
}

