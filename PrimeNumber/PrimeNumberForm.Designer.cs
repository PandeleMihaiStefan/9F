namespace PrimeNumberDemo
{
    partial class PrimeNumberForm
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
            CheckButton = new Button();
            PrimeNumberTxtBox = new TextBox();
            SuspendLayout();
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(312, 311);
            CheckButton.Margin = new Padding(3, 4, 3, 4);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(167, 84);
            CheckButton.TabIndex = 0;
            CheckButton.Text = "CHECK";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // PrimeNumberTxtBox
            // 
            PrimeNumberTxtBox.Location = new Point(347, 234);
            PrimeNumberTxtBox.Margin = new Padding(3, 4, 3, 4);
            PrimeNumberTxtBox.Name = "PrimeNumberTxtBox";
            PrimeNumberTxtBox.Size = new Size(100, 27);
            PrimeNumberTxtBox.TabIndex = 1;
            // 
            // PrimeNumberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(PrimeNumberTxtBox);
            Controls.Add(CheckButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrimeNumberForm";
            Text = "Prime_Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox PrimeNumberTxtBox;
    }
}
