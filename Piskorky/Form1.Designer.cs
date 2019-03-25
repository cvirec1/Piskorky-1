namespace Piskorky
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
            this.dgwPlayground = new System.Windows.Forms.DataGridView();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbNumPlayer = new System.Windows.Forms.ComboBox();
            this.cbWin = new System.Windows.Forms.ComboBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbNumPlayer = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cbPlayer2 = new System.Windows.Forms.ComboBox();
            this.cbPlayer3 = new System.Windows.Forms.ComboBox();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.lbPlayer3 = new System.Windows.Forms.Label();
            this.cbPlayer4 = new System.Windows.Forms.ComboBox();
            this.lbPlayer4 = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayground)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPlayground
            // 
            this.dgwPlayground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPlayground.ColumnHeadersHeight = 6;
            this.dgwPlayground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwPlayground.ColumnHeadersVisible = false;
            this.dgwPlayground.Location = new System.Drawing.Point(164, 12);
            this.dgwPlayground.Name = "dgwPlayground";
            this.dgwPlayground.RowHeadersVisible = false;
            this.dgwPlayground.RowHeadersWidth = 10;
            this.dgwPlayground.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwPlayground.Size = new System.Drawing.Size(654, 350);
            this.dgwPlayground.TabIndex = 3;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5",
            "6x6",
            "7x7"});
            this.cbSize.Location = new System.Drawing.Point(25, 37);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 4;
            // 
            // cbNumPlayer
            // 
            this.cbNumPlayer.FormattingEnabled = true;
            this.cbNumPlayer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNumPlayer.Location = new System.Drawing.Point(25, 184);
            this.cbNumPlayer.Name = "cbNumPlayer";
            this.cbNumPlayer.Size = new System.Drawing.Size(121, 21);
            this.cbNumPlayer.TabIndex = 5;
            this.cbNumPlayer.SelectedIndexChanged += new System.EventHandler(this.cbNumPlayer_SelectedIndexChanged);
            // 
            // cbWin
            // 
            this.cbWin.FormattingEnabled = true;
            this.cbWin.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbWin.Location = new System.Drawing.Point(25, 341);
            this.cbWin.Name = "cbWin";
            this.cbWin.Size = new System.Drawing.Size(121, 21);
            this.cbWin.TabIndex = 6;
            this.cbWin.SelectedIndexChanged += new System.EventHandler(this.cbWin_SelectedIndexChanged);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(22, 12);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(109, 13);
            this.lbSize.TabIndex = 7;
            this.lbSize.Text = "PLAYGROUND SIZE";
            // 
            // lbNumPlayer
            // 
            this.lbNumPlayer.AutoSize = true;
            this.lbNumPlayer.Location = new System.Drawing.Point(22, 159);
            this.lbNumPlayer.Name = "lbNumPlayer";
            this.lbNumPlayer.Size = new System.Drawing.Size(99, 13);
            this.lbNumPlayer.TabIndex = 8;
            this.lbNumPlayer.Text = "NUMBER PLAYER";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(22, 315);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(79, 13);
            this.lbNumber.TabIndex = 9;
            this.lbNumber.Text = "WIN NUMBER";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.Location = new System.Drawing.Point(164, 386);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(654, 23);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbPlayer1
            // 
            this.cbPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlayer1.FormattingEnabled = true;
            this.cbPlayer1.Items.AddRange(new object[] {
            "x",
            "c",
            "v",
            "b"});
            this.cbPlayer1.Location = new System.Drawing.Point(838, 37);
            this.cbPlayer1.Name = "cbPlayer1";
            this.cbPlayer1.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer1.TabIndex = 11;
            // 
            // cbPlayer2
            // 
            this.cbPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlayer2.FormattingEnabled = true;
            this.cbPlayer2.Items.AddRange(new object[] {
            "x",
            "c",
            "v",
            "b"});
            this.cbPlayer2.Location = new System.Drawing.Point(838, 134);
            this.cbPlayer2.Name = "cbPlayer2";
            this.cbPlayer2.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer2.TabIndex = 12;
            this.cbPlayer2.Visible = false;
            // 
            // cbPlayer3
            // 
            this.cbPlayer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlayer3.FormattingEnabled = true;
            this.cbPlayer3.Items.AddRange(new object[] {
            "x",
            "c",
            "v",
            "b"});
            this.cbPlayer3.Location = new System.Drawing.Point(838, 239);
            this.cbPlayer3.Name = "cbPlayer3";
            this.cbPlayer3.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer3.TabIndex = 13;
            this.cbPlayer3.Visible = false;
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.Location = new System.Drawing.Point(835, 12);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(45, 13);
            this.lbPlayer1.TabIndex = 14;
            this.lbPlayer1.Text = "Player 1";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.Location = new System.Drawing.Point(835, 109);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(42, 13);
            this.lbPlayer2.TabIndex = 15;
            this.lbPlayer2.Text = "Player2";
            this.lbPlayer2.Visible = false;
            // 
            // lbPlayer3
            // 
            this.lbPlayer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer3.AutoSize = true;
            this.lbPlayer3.Location = new System.Drawing.Point(835, 208);
            this.lbPlayer3.Name = "lbPlayer3";
            this.lbPlayer3.Size = new System.Drawing.Size(45, 13);
            this.lbPlayer3.TabIndex = 16;
            this.lbPlayer3.Text = "Player 3";
            this.lbPlayer3.Visible = false;
            // 
            // cbPlayer4
            // 
            this.cbPlayer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlayer4.FormattingEnabled = true;
            this.cbPlayer4.Items.AddRange(new object[] {
            "x",
            "c",
            "v",
            "b"});
            this.cbPlayer4.Location = new System.Drawing.Point(838, 341);
            this.cbPlayer4.Name = "cbPlayer4";
            this.cbPlayer4.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer4.TabIndex = 17;
            this.cbPlayer4.Visible = false;
            // 
            // lbPlayer4
            // 
            this.lbPlayer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer4.AutoSize = true;
            this.lbPlayer4.Location = new System.Drawing.Point(838, 315);
            this.lbPlayer4.Name = "lbPlayer4";
            this.lbPlayer4.Size = new System.Drawing.Size(45, 13);
            this.lbPlayer4.TabIndex = 18;
            this.lbPlayer4.Text = "Player 4";
            this.lbPlayer4.Visible = false;
            // 
            // lblDebug
            // 
            this.lblDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(845, 411);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(35, 13);
            this.lblDebug.TabIndex = 19;
            this.lblDebug.Text = "label1";
            this.lblDebug.Visible = false;
            // 
            // lblTick
            // 
            this.lblTick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTick.AutoSize = true;
            this.lblTick.Location = new System.Drawing.Point(845, 386);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(35, 13);
            this.lblTick.TabIndex = 20;
            this.lblTick.Text = "label1";
            this.lblTick.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 433);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lbPlayer4);
            this.Controls.Add(this.cbPlayer4);
            this.Controls.Add(this.lbPlayer3);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.cbPlayer3);
            this.Controls.Add(this.cbPlayer2);
            this.Controls.Add(this.cbPlayer1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbNumPlayer);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.cbWin);
            this.Controls.Add(this.cbNumPlayer);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.dgwPlayground);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwPlayground;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbNumPlayer;
        private System.Windows.Forms.ComboBox cbWin;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbNumPlayer;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cbPlayer1;
        private System.Windows.Forms.ComboBox cbPlayer2;
        private System.Windows.Forms.ComboBox cbPlayer3;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label lbPlayer3;
        private System.Windows.Forms.ComboBox cbPlayer4;
        private System.Windows.Forms.Label lbPlayer4;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblTick;
    }
}

