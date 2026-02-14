namespace FitnessTracker
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
            this.txtSportag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nudIdotartam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHelyszin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFelvitel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdotartam)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSportag
            // 
            this.txtSportag.Location = new System.Drawing.Point(45, 69);
            this.txtSportag.Name = "txtSportag";
            this.txtSportag.Size = new System.Drawing.Size(100, 22);
            this.txtSportag.TabIndex = 0;
            this.txtSportag.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "sportag";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(151, 69);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "datum";
            // 
            // nudIdotartam
            // 
            this.nudIdotartam.Location = new System.Drawing.Point(357, 68);
            this.nudIdotartam.Name = "nudIdotartam";
            this.nudIdotartam.Size = new System.Drawing.Size(120, 22);
            this.nudIdotartam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "idotartam Perc";
            // 
            // txtHelyszin
            // 
            this.txtHelyszin.Location = new System.Drawing.Point(483, 67);
            this.txtHelyszin.Name = "txtHelyszin";
            this.txtHelyszin.Size = new System.Drawing.Size(100, 22);
            this.txtHelyszin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "helyszin";
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Location = new System.Drawing.Point(589, 66);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(161, 44);
            this.btnFelvitel.TabIndex = 9;
            this.btnFelvitel.Text = "adatfelvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHelyszin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudIdotartam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSportag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIdotartam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSportag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudIdotartam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHelyszin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFelvitel;
    }
}

