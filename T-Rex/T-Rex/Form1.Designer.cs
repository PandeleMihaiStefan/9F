namespace T_Rex
{
    partial class TrexRunner
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
            this.components = new System.ComponentModel.Container();
            this.Obstacle2PictureBox = new System.Windows.Forms.PictureBox();
            this.TrexPictureBox = new System.Windows.Forms.PictureBox();
            this.Obstacle1PictureBox = new System.Windows.Forms.PictureBox();
            this.FloorPictureBox = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Obstacle2PictureBox
            // 
            this.Obstacle2PictureBox.Image = global::T_Rex.Properties.Resources.obstacle_2;
            this.Obstacle2PictureBox.Location = new System.Drawing.Point(643, 369);
            this.Obstacle2PictureBox.Name = "Obstacle2PictureBox";
            this.Obstacle2PictureBox.Size = new System.Drawing.Size(32, 33);
            this.Obstacle2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle2PictureBox.TabIndex = 0;
            this.Obstacle2PictureBox.TabStop = false;
            this.Obstacle2PictureBox.Tag = "obstacle";
            this.Obstacle2PictureBox.Click += new System.EventHandler(this.Obstacle2PictureBox_Click);
            // 
            // TrexPictureBox
            // 
            this.TrexPictureBox.Image = global::T_Rex.Properties.Resources.running;
            this.TrexPictureBox.Location = new System.Drawing.Point(87, 350);
            this.TrexPictureBox.Name = "TrexPictureBox";
            this.TrexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.TrexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TrexPictureBox.TabIndex = 1;
            this.TrexPictureBox.TabStop = false;
            this.TrexPictureBox.Click += new System.EventHandler(this.TrexPictureBox_Click);
            // 
            // Obstacle1PictureBox
            // 
            this.Obstacle1PictureBox.Image = global::T_Rex.Properties.Resources.obstacle_1;
            this.Obstacle1PictureBox.Location = new System.Drawing.Point(735, 356);
            this.Obstacle1PictureBox.Name = "Obstacle1PictureBox";
            this.Obstacle1PictureBox.Size = new System.Drawing.Size(23, 46);
            this.Obstacle1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle1PictureBox.TabIndex = 2;
            this.Obstacle1PictureBox.TabStop = false;
            this.Obstacle1PictureBox.Tag = "obstacle";
            this.Obstacle1PictureBox.Click += new System.EventHandler(this.Obstacle1PictureBox_Click);
            // 
            // FloorPictureBox
            // 
            this.FloorPictureBox.BackColor = System.Drawing.Color.Black;
            this.FloorPictureBox.Location = new System.Drawing.Point(-8, 408);
            this.FloorPictureBox.Name = "FloorPictureBox";
            this.FloorPictureBox.Size = new System.Drawing.Size(811, 49);
            this.FloorPictureBox.TabIndex = 3;
            this.FloorPictureBox.TabStop = false;
            this.FloorPictureBox.Click += new System.EventHandler(this.FloorPictureBox_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(43, 34);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(53, 16);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score:0";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // TrexRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.FloorPictureBox);
            this.Controls.Add(this.Obstacle1PictureBox);
            this.Controls.Add(this.TrexPictureBox);
            this.Controls.Add(this.Obstacle2PictureBox);
            this.Name = "TrexRunner";
            this.Text = "T-Rex Runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Obstacle2PictureBox;
        private System.Windows.Forms.PictureBox TrexPictureBox;
        private System.Windows.Forms.PictureBox Obstacle1PictureBox;
        private System.Windows.Forms.PictureBox FloorPictureBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}

