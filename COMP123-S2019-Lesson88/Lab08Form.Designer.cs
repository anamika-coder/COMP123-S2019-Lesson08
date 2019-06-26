namespace COMP123_S2019_Lesson88
{
    partial class Lab08Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.labelage = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab08";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.AgeTextBox);
            this.InfoGroupBox.Controls.Add(this.labelage);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.InfoGroupBox.Location = new System.Drawing.Point(12, 91);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(593, 200);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(174, 87);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(413, 30);
            this.AgeTextBox.TabIndex = 3;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelage.Location = new System.Drawing.Point(6, 84);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(149, 31);
            this.labelage.TabIndex = 2;
            this.labelage.Text = "Enter Age :";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(174, 31);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(413, 30);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NameLabel.Location = new System.Drawing.Point(6, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(173, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Name: ";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubmitButton.Location = new System.Drawing.Point(432, 343);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(167, 54);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OutputLabel.Location = new System.Drawing.Point(18, 349);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(408, 48);
            this.OutputLabel.TabIndex = 4;
            // 
            // Lab08Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Lab08Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lab08Form_Load);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

