
namespace Calculator
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
            this.Display = new System.Windows.Forms.TextBox();
            this.acumulator = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.double_o = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.Window;
            this.Display.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(14, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(254, 42);
            this.Display.TabIndex = 0;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.WordWrap = false;
            // 
            // acumulator
            // 
            this.acumulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.acumulator.Location = new System.Drawing.Point(222, 60);
            this.acumulator.Name = "acumulator";
            this.acumulator.Size = new System.Drawing.Size(46, 46);
            this.acumulator.TabIndex = 1;
            this.acumulator.Text = "AC";
            this.acumulator.UseMnemonic = false;
            this.acumulator.UseVisualStyleBackColor = false;
            this.acumulator.Click += new System.EventHandler(this.Expression_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.Location = new System.Drawing.Point(170, 60);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(46, 46);
            this.delete.TabIndex = 1;
            this.delete.Text = "DEL";
            this.delete.UseMnemonic = false;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Number_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(222, 112);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(46, 46);
            this.divide.TabIndex = 1;
            this.divide.Text = "÷";
            this.divide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Expression_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(170, 164);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(46, 46);
            this.sum.TabIndex = 1;
            this.sum.Text = "+";
            this.sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.Expression_Click);
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multi.Location = new System.Drawing.Point(170, 112);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(46, 46);
            this.multi.TabIndex = 1;
            this.multi.Text = "x";
            this.multi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.Expression_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(222, 164);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 46);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Expression_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal.Location = new System.Drawing.Point(170, 216);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(98, 46);
            this.equal.TabIndex = 0;
            this.equal.Text = "=";
            this.equal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.Expression_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seven.Location = new System.Drawing.Point(14, 61);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(46, 46);
            this.seven.TabIndex = 2;
            this.seven.Text = "7";
            this.seven.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Number_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eight.Location = new System.Drawing.Point(66, 61);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(46, 46);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Number_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nine.Location = new System.Drawing.Point(118, 61);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(46, 46);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Number_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.six.Location = new System.Drawing.Point(118, 113);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(46, 46);
            this.six.TabIndex = 2;
            this.six.Text = "6";
            this.six.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Number_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.five.Location = new System.Drawing.Point(66, 112);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(46, 46);
            this.five.TabIndex = 2;
            this.five.Text = "5";
            this.five.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Number_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.four.Location = new System.Drawing.Point(14, 113);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(46, 46);
            this.four.TabIndex = 2;
            this.four.Text = "4";
            this.four.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Number_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.two.Location = new System.Drawing.Point(66, 164);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(46, 46);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Number_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.one.Location = new System.Drawing.Point(14, 164);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(46, 46);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Number_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.three.Location = new System.Drawing.Point(118, 165);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(46, 46);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Number_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(14, 216);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(46, 46);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Number_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(66, 216);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(46, 46);
            this.dot.TabIndex = 2;
            this.dot.Text = ".";
            this.dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.Number_Click);
            // 
            // double_o
            // 
            this.double_o.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.double_o.Location = new System.Drawing.Point(118, 217);
            this.double_o.Name = "double_o";
            this.double_o.Size = new System.Drawing.Size(46, 46);
            this.double_o.TabIndex = 2;
            this.double_o.Text = "00";
            this.double_o.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.double_o.UseVisualStyleBackColor = true;
            this.double_o.Click += new System.EventHandler(this.Number_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 272);
            this.Controls.Add(this.double_o);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.acumulator);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button acumulator;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button double_o;
    }
}

