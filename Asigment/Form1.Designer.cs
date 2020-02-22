namespace Asigment
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLongerDistance = new System.Windows.Forms.TextBox();
            this.lblLongerTime = new System.Windows.Forms.TextBox();
            this.lblShorterDistance = new System.Windows.Forms.TextBox();
            this.lblShorterTime = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.lblCSS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWorkoutDistance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWorkingTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNSS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTSS = new System.Windows.Forms.TextBox();
            this.lblMonthOfTraining = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblWeeksInTheMonth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Long Swim Distance: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Long Swim Time (s): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Short Swim Distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Short Swim Time (s): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Critical Swim Speed (CSS): ";
            // 
            // lblLongerDistance
            // 
            this.lblLongerDistance.Location = new System.Drawing.Point(317, 30);
            this.lblLongerDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLongerDistance.Name = "lblLongerDistance";
            this.lblLongerDistance.Size = new System.Drawing.Size(137, 22);
            this.lblLongerDistance.TabIndex = 5;
            this.lblLongerDistance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblLongerTime
            // 
            this.lblLongerTime.Location = new System.Drawing.Point(316, 74);
            this.lblLongerTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLongerTime.Name = "lblLongerTime";
            this.lblLongerTime.Size = new System.Drawing.Size(137, 22);
            this.lblLongerTime.TabIndex = 6;
            // 
            // lblShorterDistance
            // 
            this.lblShorterDistance.Location = new System.Drawing.Point(316, 137);
            this.lblShorterDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblShorterDistance.Name = "lblShorterDistance";
            this.lblShorterDistance.Size = new System.Drawing.Size(137, 22);
            this.lblShorterDistance.TabIndex = 7;
            // 
            // lblShorterTime
            // 
            this.lblShorterTime.Location = new System.Drawing.Point(316, 188);
            this.lblShorterTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblShorterTime.Name = "lblShorterTime";
            this.lblShorterTime.Size = new System.Drawing.Size(137, 22);
            this.lblShorterTime.TabIndex = 8;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(458, 237);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(140, 23);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // lblCSS
            // 
            this.lblCSS.Location = new System.Drawing.Point(316, 330);
            this.lblCSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCSS.Name = "lblCSS";
            this.lblCSS.Size = new System.Drawing.Size(163, 22);
            this.lblCSS.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name: ";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(57, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 22);
            this.lblName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Workout Distance (metres): ";
            // 
            // lblWorkoutDistance
            // 
            this.lblWorkoutDistance.Location = new System.Drawing.Point(609, 30);
            this.lblWorkoutDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWorkoutDistance.Name = "lblWorkoutDistance";
            this.lblWorkoutDistance.Size = new System.Drawing.Size(163, 22);
            this.lblWorkoutDistance.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Working Time (seconds): ";
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.Location = new System.Drawing.Point(609, 75);
            this.lblWorkingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(165, 22);
            this.lblWorkingTime.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 385);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Normalized Swim Speed (NSS): ";
            // 
            // lblNSS
            // 
            this.lblNSS.Location = new System.Drawing.Point(609, 418);
            this.lblNSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNSS.Name = "lblNSS";
            this.lblNSS.Size = new System.Drawing.Size(165, 22);
            this.lblNSS.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 385);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Intensity Factor (IF): ";
            // 
            // lblIF
            // 
            this.lblIF.Location = new System.Drawing.Point(316, 418);
            this.lblIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblIF.Name = "lblIF";
            this.lblIF.Size = new System.Drawing.Size(163, 22);
            this.lblIF.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 298);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Training Stress Score (TSS): ";
            // 
            // lblTSS
            // 
            this.lblTSS.Location = new System.Drawing.Point(609, 330);
            this.lblTSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTSS.Name = "lblTSS";
            this.lblTSS.Size = new System.Drawing.Size(165, 22);
            this.lblTSS.TabIndex = 23;
            // 
            // lblMonthOfTraining
            // 
            this.lblMonthOfTraining.Location = new System.Drawing.Point(57, 114);
            this.lblMonthOfTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMonthOfTraining.Name = "lblMonthOfTraining";
            this.lblMonthOfTraining.Size = new System.Drawing.Size(137, 22);
            this.lblMonthOfTraining.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Motnh Of Training: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "How many Weeks has the month?";
            // 
            // lblWeeksInTheMonth
            // 
            this.lblWeeksInTheMonth.Location = new System.Drawing.Point(57, 212);
            this.lblWeeksInTheMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWeeksInTheMonth.Name = "lblWeeksInTheMonth";
            this.lblWeeksInTheMonth.Size = new System.Drawing.Size(137, 22);
            this.lblWeeksInTheMonth.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 709);
            this.Controls.Add(this.lblWeeksInTheMonth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMonthOfTraining);
            this.Controls.Add(this.lblTSS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblIF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNSS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblWorkingTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblWorkoutDistance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCSS);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.lblShorterTime);
            this.Controls.Add(this.lblShorterDistance);
            this.Controls.Add(this.lblLongerTime);
            this.Controls.Add(this.lblLongerDistance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblLongerDistance;
        private System.Windows.Forms.TextBox lblLongerTime;
        private System.Windows.Forms.TextBox lblShorterDistance;
        private System.Windows.Forms.TextBox lblShorterTime;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox lblCSS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblWorkoutDistance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lblWorkingTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblNSS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lblIF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lblTSS;
        private System.Windows.Forms.TextBox lblMonthOfTraining;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lblWeeksInTheMonth;
    }
}

