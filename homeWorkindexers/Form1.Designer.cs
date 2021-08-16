
namespace homeWorkindexers
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
            this.button1 = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.TextBox();
            this.Tempture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "ShibakuTENSEEE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(663, 163);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(125, 27);
            this.Day.TabIndex = 1;
            this.Day.TextChanged += new System.EventHandler(this.Day_TextChanged);
            // 
            // Tempture
            // 
            this.Tempture.Location = new System.Drawing.Point(663, 207);
            this.Tempture.Name = "Tempture";
            this.Tempture.Size = new System.Drawing.Size(125, 27);
            this.Tempture.TabIndex = 2;
            this.Tempture.TextChanged += new System.EventHandler(this.Tempture_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(808, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(808, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weather";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 714);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tempture);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox Tempture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

