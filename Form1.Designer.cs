namespace FlappyBird
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
            this.Scoretext = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Pipebottom = new System.Windows.Forms.PictureBox();
            this.ErminBird = new System.Windows.Forms.PictureBox();
            this.Pipetop = new System.Windows.Forms.PictureBox();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErminBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipetop)).BeginInit();
            this.SuspendLayout();
            // 
            // Scoretext
            // 
            this.Scoretext.AutoSize = true;
            this.Scoretext.Font = new System.Drawing.Font("Leelawadee", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretext.Location = new System.Drawing.Point(12, 9);
            this.Scoretext.Name = "Scoretext";
            this.Scoretext.Size = new System.Drawing.Size(203, 57);
            this.Scoretext.TabIndex = 4;
            this.Scoretext.Text = "Score: 0";
            this.Scoretext.Click += new System.EventHandler(this.label1_Click);
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-5, 874);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(794, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // Pipebottom
            // 
            this.Pipebottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.Pipebottom.Location = new System.Drawing.Point(497, 563);
            this.Pipebottom.Name = "Pipebottom";
            this.Pipebottom.Size = new System.Drawing.Size(141, 423);
            this.Pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipebottom.TabIndex = 2;
            this.Pipebottom.TabStop = false;
            // 
            // ErminBird
            // 
            this.ErminBird.Image = global::FlappyBird.Properties.Resources._1;
            this.ErminBird.Location = new System.Drawing.Point(34, 347);
            this.ErminBird.Name = "ErminBird";
            this.ErminBird.Size = new System.Drawing.Size(131, 105);
            this.ErminBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ErminBird.TabIndex = 1;
            this.ErminBird.TabStop = false;
            this.ErminBird.Click += new System.EventHandler(this.Flappybird_Click);
            // 
            // Pipetop
            // 
            this.Pipetop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.Pipetop.Location = new System.Drawing.Point(497, -7);
            this.Pipetop.Name = "Pipetop";
            this.Pipetop.Size = new System.Drawing.Size(141, 344);
            this.Pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipetop.TabIndex = 0;
            this.Pipetop.TabStop = false;
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.Gametimerevent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(776, 961);
            this.Controls.Add(this.Scoretext);
            this.Controls.Add(this.ErminBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Pipebottom);
            this.Controls.Add(this.Pipetop);
            this.Name = "Form1";
            this.Text = "Flappybird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GAmekeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErminBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipetop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pipetop;
        private System.Windows.Forms.PictureBox ErminBird;
        private System.Windows.Forms.PictureBox Pipebottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label Scoretext;
        private System.Windows.Forms.Timer Gametimer;
    }
}

