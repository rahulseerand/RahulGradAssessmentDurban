
namespace GradAssessment
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
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnQ1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(128, 14);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(158, 23);
            this.txtPlayer1.TabIndex = 0;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(128, 80);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(158, 23);
            this.txtPlayer2.TabIndex = 1;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(3, 14);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(98, 15);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Enter Player one :";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(3, 80);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(98, 15);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Enter Player two :";
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(211, 126);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(75, 23);
            this.btnQ1.TabIndex = 4;
            this.btnQ1.Text = "Submit";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPlayer1);
            this.panel1.Controls.Add(this.btnQ1);
            this.panel1.Controls.Add(this.txtPlayer1);
            this.panel1.Controls.Add(this.lblPlayer2);
            this.panel1.Controls.Add(this.txtPlayer2);
            this.panel1.Location = new System.Drawing.Point(93, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 159);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPath);
            this.panel2.Controls.Add(this.lblPath);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.btnQ2);
            this.panel2.Location = new System.Drawing.Point(93, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 110);
            this.panel2.TabIndex = 6;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(60, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(226, 23);
            this.txtPath.TabIndex = 7;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(17, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 15);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Path :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(317, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.Location = new System.Drawing.Point(197, 64);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(75, 23);
            this.btnQ2.TabIndex = 5;
            this.btnQ2.Text = "Upload";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.btnQ2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Question 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Question 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
    }
}

