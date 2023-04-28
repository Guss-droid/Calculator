namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OperatorInput = new System.Windows.Forms.TextBox();
            this.InputValue2 = new System.Windows.Forms.TextBox();
            this.InputValue1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputResult = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 359);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(600, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 255);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(800, 255);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button24);
            this.panel8.Controls.Add(this.button23);
            this.panel8.Controls.Add(this.button22);
            this.panel8.Controls.Add(this.button21);
            this.panel8.Controls.Add(this.button20);
            this.panel8.Controls.Add(this.eraser);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(433, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 235);
            this.panel8.TabIndex = 3;
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Top;
            this.button24.Location = new System.Drawing.Point(0, 195);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(150, 39);
            this.button24.TabIndex = 7;
            this.button24.Text = "=";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Top;
            this.button23.Location = new System.Drawing.Point(0, 156);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(150, 39);
            this.button23.TabIndex = 6;
            this.button23.Text = "/";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Top;
            this.button22.Location = new System.Drawing.Point(0, 117);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(150, 39);
            this.button22.TabIndex = 5;
            this.button22.Text = "*";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Top;
            this.button21.Location = new System.Drawing.Point(0, 78);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(150, 39);
            this.button21.TabIndex = 4;
            this.button21.Text = "-";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Top;
            this.button20.Location = new System.Drawing.Point(0, 39);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(150, 39);
            this.button20.TabIndex = 3;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // eraser
            // 
            this.eraser.Dock = System.Windows.Forms.DockStyle.Top;
            this.eraser.Location = new System.Drawing.Point(0, 0);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(150, 39);
            this.eraser.TabIndex = 2;
            this.eraser.Text = "DEL";
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button17);
            this.panel7.Controls.Add(this.button16);
            this.panel7.Controls.Add(this.button15);
            this.panel7.Controls.Add(this.button13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(301, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(132, 235);
            this.panel7.TabIndex = 2;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.Location = new System.Drawing.Point(0, 117);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(132, 39);
            this.button17.TabIndex = 5;
            this.button17.Text = "3";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Top;
            this.button16.Location = new System.Drawing.Point(0, 78);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(132, 39);
            this.button16.TabIndex = 4;
            this.button16.Text = "6";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.Location = new System.Drawing.Point(0, 39);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(132, 39);
            this.button15.TabIndex = 3;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button12);
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(156, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 235);
            this.panel6.TabIndex = 1;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.Location = new System.Drawing.Point(0, 156);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(145, 39);
            this.button12.TabIndex = 6;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.Location = new System.Drawing.Point(0, 117);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(145, 39);
            this.button11.TabIndex = 5;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.Location = new System.Drawing.Point(0, 78);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(145, 39);
            this.button10.TabIndex = 4;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.Location = new System.Drawing.Point(0, 39);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 39);
            this.button9.TabIndex = 3;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 39);
            this.button7.TabIndex = 1;
            this.button7.Text = "CE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.deleteCount);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 235);
            this.panel5.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.addNumberToCount);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OperatorInput);
            this.panel2.Controls.Add(this.InputValue2);
            this.panel2.Controls.Add(this.InputValue1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.InputResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 104);
            this.panel2.TabIndex = 0;
            // 
            // OperatorInput
            // 
            this.OperatorInput.Location = new System.Drawing.Point(399, 12);
            this.OperatorInput.Name = "OperatorInput";
            this.OperatorInput.Size = new System.Drawing.Size(20, 20);
            this.OperatorInput.TabIndex = 4;
            // 
            // InputValue2
            // 
            this.InputValue2.Location = new System.Drawing.Point(425, 11);
            this.InputValue2.Name = "InputValue2";
            this.InputValue2.Size = new System.Drawing.Size(209, 20);
            this.InputValue2.TabIndex = 3;
            // 
            // InputValue1
            // 
            this.InputValue1.Location = new System.Drawing.Point(184, 11);
            this.InputValue1.Name = "InputValue1";
            this.InputValue1.Size = new System.Drawing.Size(209, 20);
            this.InputValue1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora";
            // 
            // InputResult
            // 
            this.InputResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputResult.Location = new System.Drawing.Point(0, 84);
            this.InputResult.Name = "InputResult";
            this.InputResult.Size = new System.Drawing.Size(800, 20);
            this.InputResult.TabIndex = 0;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(132, 39);
            this.button13.TabIndex = 1;
            this.button13.Text = ",";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputResult;
        private System.Windows.Forms.TextBox OperatorInput;
        private System.Windows.Forms.TextBox InputValue2;
        private System.Windows.Forms.TextBox InputValue1;
        private System.Windows.Forms.Button button13;
    }
}

