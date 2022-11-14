namespace SecondsTo
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
            this.Title = new System.Windows.Forms.Label();
            this.instructLabel = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(429, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(530, 81);
            this.Title.TabIndex = 0;
            this.Title.Text = "Seconds Converter";
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.instructLabel.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructLabel.Location = new System.Drawing.Point(22, 165);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(626, 54);
            this.instructLabel.TabIndex = 1;
            this.instructLabel.Text = "Please enter a number in seconds:";
            // 
            // userText
            // 
            this.userText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userText.Location = new System.Drawing.Point(714, 165);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(245, 61);
            this.userText.TabIndex = 2;
            // 
            // daysBox
            // 
            this.daysBox.Enabled = false;
            this.daysBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daysBox.Location = new System.Drawing.Point(558, 333);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(153, 61);
            this.daysBox.TabIndex = 3;
            this.daysBox.Text = "0";
            this.daysBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursBox
            // 
            this.hoursBox.Enabled = false;
            this.hoursBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursBox.Location = new System.Drawing.Point(558, 464);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(153, 61);
            this.hoursBox.TabIndex = 4;
            this.hoursBox.Text = "0";
            this.hoursBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minutesBox
            // 
            this.minutesBox.Enabled = false;
            this.minutesBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minutesBox.Location = new System.Drawing.Point(558, 584);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(153, 61);
            this.minutesBox.TabIndex = 5;
            this.minutesBox.Text = "0";
            this.minutesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(770, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(770, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 54);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(761, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 54);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minutes";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.DimGray;
            this.submitButton.Location = new System.Drawing.Point(1012, 160);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(176, 70);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SecondsTo.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.instructLabel);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Seconds Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label instructLabel;
        private TextBox userText;
        private TextBox daysBox;
        private TextBox hoursBox;
        private TextBox minutesBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button submitButton;
    }
}