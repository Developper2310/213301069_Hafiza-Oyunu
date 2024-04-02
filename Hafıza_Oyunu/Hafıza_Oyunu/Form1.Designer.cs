namespace Hafıza_Oyunu
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Kurabiye = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(374, 367);
            button1.Name = "button1";
            button1.Size = new Size(199, 93);
            button1.TabIndex = 0;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(374, 334);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 1;
            label1.Text = "Oyuna başlamak için Tıklayın";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(238, 9);
            label2.Name = "label2";
            label2.Size = new Size(464, 74);
            label2.TabIndex = 2;
            label2.Text = "HAFIZA OYUNU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(314, 83);
            label3.Name = "label3";
            label3.Size = new Size(318, 32);
            label3.TabIndex = 3;
            label3.Text = "Present By YFU Studios";
            // 
            // Kurabiye
            // 
            Kurabiye.AutoSize = true;
            Kurabiye.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            Kurabiye.ForeColor = Color.Red;
            Kurabiye.Location = new Point(326, 486);
            Kurabiye.Name = "Kurabiye";
            Kurabiye.Size = new Size(306, 28);
            Kurabiye.TabIndex = 4;
            Kurabiye.Text = "Şimdi Kurabiye Ödüllü";
            Kurabiye.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(914, 523);
            Controls.Add(Kurabiye);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Kurabiye;
    }
}