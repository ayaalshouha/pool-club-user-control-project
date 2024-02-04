namespace Pool_Club_UserControl_Project
{
    partial class CustomMesssageBoxForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimeConsumed = new System.Windows.Forms.Label();
            this.lblTotalSeconds = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTableTitle);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.lblHourlyRate);
            this.groupBox1.Controls.Add(this.lblTotalSeconds);
            this.groupBox1.Controls.Add(this.lblTimeConsumed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Summery";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Consumed: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Seconds: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hourly Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Fees:";
            // 
            // lblTimeConsumed
            // 
            this.lblTimeConsumed.AutoSize = true;
            this.lblTimeConsumed.Location = new System.Drawing.Point(231, 60);
            this.lblTimeConsumed.Name = "lblTimeConsumed";
            this.lblTimeConsumed.Size = new System.Drawing.Size(44, 20);
            this.lblTimeConsumed.TabIndex = 5;
            this.lblTimeConsumed.Text = "[???]";
            // 
            // lblTotalSeconds
            // 
            this.lblTotalSeconds.AutoSize = true;
            this.lblTotalSeconds.Location = new System.Drawing.Point(231, 103);
            this.lblTotalSeconds.Name = "lblTotalSeconds";
            this.lblTotalSeconds.Size = new System.Drawing.Size(44, 20);
            this.lblTotalSeconds.TabIndex = 6;
            this.lblTotalSeconds.Text = "[???]";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(231, 146);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(44, 20);
            this.lblHourlyRate.TabIndex = 7;
            this.lblHourlyRate.Text = "[???]";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(231, 189);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(44, 20);
            this.lblTotalFees.TabIndex = 8;
            this.lblTotalFees.Text = "[???]";
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTableTitle.Location = new System.Drawing.Point(315, 11);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(119, 22);
            this.lblTableTitle.TabIndex = 9;
            this.lblTableTitle.Text = "Table Title: ";
            // 
            // CustomMesssageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 289);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMesssageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMesssageBoxForm";
            this.Load += new System.EventHandler(this.CustomMesssageBoxForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblTotalSeconds;
        private System.Windows.Forms.Label lblTimeConsumed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTableTitle;
    }
}