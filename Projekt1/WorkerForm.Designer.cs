
namespace Projekt1
{
    partial class WorkerForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.titleMovieBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Client/Worker";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // titleMovieBox
            // 
            this.titleMovieBox.Location = new System.Drawing.Point(270, 189);
            this.titleMovieBox.Name = "titleMovieBox";
            this.titleMovieBox.Size = new System.Drawing.Size(200, 20);
            this.titleMovieBox.TabIndex = 4;
            this.titleMovieBox.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(217, 141);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 10;
            this.durationLabel.Text = "Duration";
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(270, 141);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(200, 20);
            this.DurationBox.TabIndex = 11;
            this.DurationBox.Text = "00:00";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(270, 236);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(200, 20);
            this.TimeBox.TabIndex = 12;
            this.TimeBox.Text = "00:00";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(270, 285);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 20);
            this.DateBox.TabIndex = 13;
            this.DateBox.Text = "01.01.2022";
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleMovieBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox titleMovieBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.TextBox DateBox;
    }
}