
namespace Snake
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
            this.SnakeBoard = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lblScored = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // SnakeBoard
            // 
            this.SnakeBoard.BackColor = System.Drawing.SystemColors.Info;
            this.SnakeBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SnakeBoard.Location = new System.Drawing.Point(31, 33);
            this.SnakeBoard.Name = "SnakeBoard";
            this.SnakeBoard.Size = new System.Drawing.Size(500, 350);
            this.SnakeBoard.TabIndex = 0;
            this.SnakeBoard.TabStop = false;
            this.SnakeBoard.Click += new System.EventHandler(this.SnakeBoard_Click);
            this.SnakeBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.SnakeBoard_Paint);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Score.Location = new System.Drawing.Point(95, 387);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(21, 24);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "0";
            // 
            // lblScored
            // 
            this.lblScored.AutoSize = true;
            this.lblScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScored.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblScored.Location = new System.Drawing.Point(27, 386);
            this.lblScored.Name = "lblScored";
            this.lblScored.Size = new System.Drawing.Size(71, 24);
            this.lblScored.TabIndex = 2;
            this.lblScored.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(237, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Snake";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.Color.Lime;
            this.btn_PlayAgain.Location = new System.Drawing.Point(233, 184);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(92, 24);
            this.btn_PlayAgain.TabIndex = 4;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Visible = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(184, 222);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(253, 25);
            this.lbl_msg.TabIndex = 5;
            this.lbl_msg.Text = "Press Any Key To Start.!!";
            this.lbl_msg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 429);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScored);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.SnakeBoard);
            this.MaximumSize = new System.Drawing.Size(562, 468);
            this.MinimumSize = new System.Drawing.Size(562, 468);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.PictureBox SnakeBoard;
    private System.Windows.Forms.Label lbl_Score;
    private System.Windows.Forms.Label lblScored;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_PlayAgain;
    private System.Windows.Forms.Label lbl_msg;
  }
}

