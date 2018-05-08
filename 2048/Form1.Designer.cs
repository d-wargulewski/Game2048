namespace _2048
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.t_screen = new System.Windows.Forms.PictureBox();
            this.D1 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.button_newGame = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // t_screen
            // 
            this.t_screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.t_screen.Location = new System.Drawing.Point(12, 164);
            this.t_screen.Name = "t_screen";
            this.t_screen.Size = new System.Drawing.Size(330, 330);
            this.t_screen.TabIndex = 17;
            this.t_screen.TabStop = false;
            this.t_screen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.t_screen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.D1.Enabled = false;
            this.D1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.D1.Location = new System.Drawing.Point(18, 413);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(75, 75);
            this.D1.TabIndex = 12;
            this.D1.UseCompatibleTextRendering = true;
            this.D1.UseVisualStyleBackColor = false;
            this.D1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.D1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.D2.Enabled = false;
            this.D2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.D2.Location = new System.Drawing.Point(99, 413);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(75, 75);
            this.D2.TabIndex = 13;
            this.D2.UseCompatibleTextRendering = true;
            this.D2.UseVisualStyleBackColor = false;
            this.D2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.D2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.D3.Enabled = false;
            this.D3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.D3.Location = new System.Drawing.Point(180, 413);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(75, 75);
            this.D3.TabIndex = 14;
            this.D3.UseCompatibleTextRendering = true;
            this.D3.UseVisualStyleBackColor = false;
            this.D3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.D3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.D4.Enabled = false;
            this.D4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.D4.Location = new System.Drawing.Point(261, 413);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(75, 75);
            this.D4.TabIndex = 15;
            this.D4.UseCompatibleTextRendering = true;
            this.D4.UseVisualStyleBackColor = false;
            this.D4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.D4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // C4
            // 
            this.C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.C4.Enabled = false;
            this.C4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C4.Location = new System.Drawing.Point(261, 332);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(75, 75);
            this.C4.TabIndex = 11;
            this.C4.UseCompatibleTextRendering = true;
            this.C4.UseVisualStyleBackColor = false;
            this.C4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.C4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.C3.Enabled = false;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C3.Location = new System.Drawing.Point(180, 332);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 10;
            this.C3.UseCompatibleTextRendering = true;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.C3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.C2.Enabled = false;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C2.Location = new System.Drawing.Point(99, 332);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 9;
            this.C2.UseCompatibleTextRendering = true;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.C2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.C1.Enabled = false;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C1.Location = new System.Drawing.Point(18, 332);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 8;
            this.C1.UseCompatibleTextRendering = true;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.C1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.B1.Enabled = false;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B1.Location = new System.Drawing.Point(18, 251);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseCompatibleTextRendering = true;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.B1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.B2.Enabled = false;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B2.Location = new System.Drawing.Point(99, 251);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 6;
            this.B2.UseCompatibleTextRendering = true;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.B2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.B3.Enabled = false;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B3.Location = new System.Drawing.Point(180, 251);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 5;
            this.B3.UseCompatibleTextRendering = true;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.B3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.B4.Enabled = false;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B4.Location = new System.Drawing.Point(261, 251);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(75, 75);
            this.B4.TabIndex = 7;
            this.B4.UseCompatibleTextRendering = true;
            this.B4.UseVisualStyleBackColor = false;
            this.B4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.B4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.A4.Enabled = false;
            this.A4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A4.Location = new System.Drawing.Point(261, 170);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(75, 75);
            this.A4.TabIndex = 3;
            this.A4.UseCompatibleTextRendering = true;
            this.A4.UseVisualStyleBackColor = false;
            this.A4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.A4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.A3.Enabled = false;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(180, 170);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 2;
            this.A3.UseCompatibleTextRendering = true;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.A3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.A2.Enabled = false;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2.Location = new System.Drawing.Point(99, 170);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 1;
            this.A2.UseCompatibleTextRendering = true;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.A2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.A1.Enabled = false;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(18, 170);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 0;
            this.A1.UseCompatibleTextRendering = true;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TouchPanel_MouseDown);
            this.A1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.touchPanel_MouseUp);
            // 
            // button_newGame
            // 
            this.button_newGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.button_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newGame.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_newGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.button_newGame.Location = new System.Drawing.Point(12, 12);
            this.button_newGame.Name = "button_newGame";
            this.button_newGame.Size = new System.Drawing.Size(139, 70);
            this.button_newGame.TabIndex = 18;
            this.button_newGame.Text = "New game";
            this.button_newGame.UseCompatibleTextRendering = true;
            this.button_newGame.UseVisualStyleBackColor = false;
            this.button_newGame.Click += new System.EventHandler(this.NewGameClick);
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.scoreButton.Enabled = false;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.scoreButton.Location = new System.Drawing.Point(157, 12);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(185, 70);
            this.scoreButton.TabIndex = 19;
            this.scoreButton.Text = "Score: 0";
            this.scoreButton.UseCompatibleTextRendering = true;
            this.scoreButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 88);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(94, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 64);
            this.label1.TabIndex = 25;
            this.label1.Text = "Use your arrow (or WSAD keys)\r\nto move the tiles.\r\nWhen two tiles with the same\r\n" +
    "number touch, they merge into one!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(355, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.button_newGame);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.t_screen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 543);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(371, 543);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._2048_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.t_screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox t_screen;
        private System.Windows.Forms.Button D1;
        private System.Windows.Forms.Button D2;
        private System.Windows.Forms.Button D3;
        private System.Windows.Forms.Button D4;
        private System.Windows.Forms.Button C4;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button A4;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button button_newGame;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
    }
}

