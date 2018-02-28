namespace ball_hitter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.plank = new System.Windows.Forms.PictureBox();
            this.vertikalus = new System.Windows.Forms.Timer(this.components);
            this.horizantalus = new System.Windows.Forms.Timer(this.components);
            this.gaudykle = new System.Windows.Forms.Timer(this.components);
            this.game_over_panel = new System.Windows.Forms.Panel();
            this.game_over_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plank)).BeginInit();
            this.game_over_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(137, 60);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(75, 70);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // plank
            // 
            this.plank.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.plank.Location = new System.Drawing.Point(148, 651);
            this.plank.Name = "plank";
            this.plank.Size = new System.Drawing.Size(227, 16);
            this.plank.TabIndex = 1;
            this.plank.TabStop = false;
            // 
            // vertikalus
            // 
            this.vertikalus.Enabled = true;
            this.vertikalus.Interval = 1;
            this.vertikalus.Tick += new System.EventHandler(this.vertikalus_Tick);
            // 
            // horizantalus
            // 
            this.horizantalus.Enabled = true;
            this.horizantalus.Interval = 1;
            this.horizantalus.Tick += new System.EventHandler(this.horizantalus_Tick);
            // 
            // gaudykle
            // 
            this.gaudykle.Enabled = true;
            this.gaudykle.Interval = 1;
            this.gaudykle.Tick += new System.EventHandler(this.gaudykle_Tick);
            // 
            // game_over_panel
            // 
            this.game_over_panel.BackColor = System.Drawing.Color.Red;
            this.game_over_panel.Controls.Add(this.game_over_label);
            this.game_over_panel.Location = new System.Drawing.Point(280, 185);
            this.game_over_panel.Name = "game_over_panel";
            this.game_over_panel.Size = new System.Drawing.Size(669, 252);
            this.game_over_panel.TabIndex = 2;
            this.game_over_panel.Visible = false;
            // 
            // game_over_label
            // 
            this.game_over_label.AutoSize = true;
            this.game_over_label.Font = new System.Drawing.Font("Lithos Pro Regular", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over_label.ForeColor = System.Drawing.Color.White;
            this.game_over_label.Location = new System.Drawing.Point(141, 88);
            this.game_over_label.Name = "game_over_label";
            this.game_over_label.Size = new System.Drawing.Size(411, 70);
            this.game_over_label.TabIndex = 0;
            this.game_over_label.Text = "GAME OVER";
            this.game_over_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.game_over_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1217, 669);
            this.Controls.Add(this.game_over_panel);
            this.Controls.Add(this.plank);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plank)).EndInit();
            this.game_over_panel.ResumeLayout(false);
            this.game_over_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox plank;
        private System.Windows.Forms.Timer vertikalus;
        private System.Windows.Forms.Timer horizantalus;
        private System.Windows.Forms.Timer gaudykle;
        private System.Windows.Forms.Panel game_over_panel;
        private System.Windows.Forms.Label game_over_label;
    }
}

