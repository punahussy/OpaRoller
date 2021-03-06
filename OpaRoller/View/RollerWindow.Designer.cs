﻿namespace OpaRoller
{
    partial class RollerWindow
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
            this.components = new System.ComponentModel.Container();
            this.RollBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.AddD4 = new System.Windows.Forms.Button();
            this.D4Amount = new System.Windows.Forms.Label();
            this.AddD6 = new System.Windows.Forms.Button();
            this.D6Amount = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DelD4 = new System.Windows.Forms.Button();
            this.DelD6 = new System.Windows.Forms.Button();
            this.AddD20 = new System.Windows.Forms.Button();
            this.D20Amount = new System.Windows.Forms.Label();
            this.DelD20 = new System.Windows.Forms.Button();
            this.AddD8 = new System.Windows.Forms.Button();
            this.D8Amount = new System.Windows.Forms.Label();
            this.DelD8 = new System.Windows.Forms.Button();
            this.DelD12 = new System.Windows.Forms.Button();
            this.D12Amount = new System.Windows.Forms.Label();
            this.AddD12 = new System.Windows.Forms.Button();
            this.show_frame_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RollBtn
            // 
            this.RollBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RollBtn.Location = new System.Drawing.Point(90, 12);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(92, 48);
            this.RollBtn.TabIndex = 0;
            this.RollBtn.Text = "Roll";
            this.RollBtn.UseVisualStyleBackColor = false;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(12, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(50, 48);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 60;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // AddD4
            // 
            this.AddD4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddD4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddD4.Location = new System.Drawing.Point(203, 12);
            this.AddD4.Name = "AddD4";
            this.AddD4.Size = new System.Drawing.Size(92, 48);
            this.AddD4.TabIndex = 0;
            this.AddD4.Text = "D4";
            this.AddD4.UseVisualStyleBackColor = false;
            this.AddD4.Click += new System.EventHandler(this.AddDice);
            // 
            // D4Amount
            // 
            this.D4Amount.AutoSize = true;
            this.D4Amount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.D4Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D4Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.D4Amount.Location = new System.Drawing.Point(203, 63);
            this.D4Amount.Name = "D4Amount";
            this.D4Amount.Size = new System.Drawing.Size(30, 32);
            this.D4Amount.TabIndex = 2;
            this.D4Amount.Text = "0";
            // 
            // AddD6
            // 
            this.AddD6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddD6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddD6.Location = new System.Drawing.Point(319, 12);
            this.AddD6.Name = "AddD6";
            this.AddD6.Size = new System.Drawing.Size(92, 48);
            this.AddD6.TabIndex = 0;
            this.AddD6.Text = "D6";
            this.AddD6.UseVisualStyleBackColor = false;
            this.AddD6.Click += new System.EventHandler(this.AddDice);
            // 
            // D6Amount
            // 
            this.D6Amount.AutoSize = true;
            this.D6Amount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.D6Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D6Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.D6Amount.Location = new System.Drawing.Point(319, 63);
            this.D6Amount.Name = "D6Amount";
            this.D6Amount.Size = new System.Drawing.Size(30, 32);
            this.D6Amount.TabIndex = 2;
            this.D6Amount.Text = "0";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ResetBtn.Location = new System.Drawing.Point(90, 66);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(92, 46);
            this.ResetBtn.TabIndex = 0;
            this.ResetBtn.Text = "Сброс";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DelD4
            // 
            this.DelD4.BackColor = System.Drawing.Color.Peru;
            this.DelD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelD4.ForeColor = System.Drawing.SystemColors.Info;
            this.DelD4.Location = new System.Drawing.Point(240, 63);
            this.DelD4.Name = "DelD4";
            this.DelD4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DelD4.Size = new System.Drawing.Size(55, 40);
            this.DelD4.TabIndex = 0;
            this.DelD4.Text = "— ";
            this.DelD4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelD4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DelD4.UseVisualStyleBackColor = false;
            this.DelD4.Click += new System.EventHandler(this.RemoveDice);
            // 
            // DelD6
            // 
            this.DelD6.BackColor = System.Drawing.Color.Peru;
            this.DelD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelD6.ForeColor = System.Drawing.SystemColors.Info;
            this.DelD6.Location = new System.Drawing.Point(357, 63);
            this.DelD6.Name = "DelD6";
            this.DelD6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DelD6.Size = new System.Drawing.Size(55, 40);
            this.DelD6.TabIndex = 0;
            this.DelD6.Text = "— ";
            this.DelD6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelD6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DelD6.UseVisualStyleBackColor = false;
            this.DelD6.Click += new System.EventHandler(this.RemoveDice);
            // 
            // AddD20
            // 
            this.AddD20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddD20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddD20.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddD20.Location = new System.Drawing.Point(672, 12);
            this.AddD20.Name = "AddD20";
            this.AddD20.Size = new System.Drawing.Size(92, 48);
            this.AddD20.TabIndex = 0;
            this.AddD20.Text = "D20";
            this.AddD20.UseVisualStyleBackColor = false;
            this.AddD20.Click += new System.EventHandler(this.AddDice);
            // 
            // D20Amount
            // 
            this.D20Amount.AutoSize = true;
            this.D20Amount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.D20Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D20Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.D20Amount.Location = new System.Drawing.Point(672, 63);
            this.D20Amount.Name = "D20Amount";
            this.D20Amount.Size = new System.Drawing.Size(30, 32);
            this.D20Amount.TabIndex = 2;
            this.D20Amount.Text = "0";
            // 
            // DelD20
            // 
            this.DelD20.BackColor = System.Drawing.Color.Peru;
            this.DelD20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelD20.ForeColor = System.Drawing.SystemColors.Info;
            this.DelD20.Location = new System.Drawing.Point(710, 63);
            this.DelD20.Name = "DelD20";
            this.DelD20.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DelD20.Size = new System.Drawing.Size(55, 40);
            this.DelD20.TabIndex = 0;
            this.DelD20.Text = "— ";
            this.DelD20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelD20.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DelD20.UseVisualStyleBackColor = false;
            this.DelD20.Click += new System.EventHandler(this.RemoveDice);
            // 
            // AddD8
            // 
            this.AddD8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddD8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddD8.Location = new System.Drawing.Point(435, 12);
            this.AddD8.Name = "AddD8";
            this.AddD8.Size = new System.Drawing.Size(92, 48);
            this.AddD8.TabIndex = 0;
            this.AddD8.Text = "D8";
            this.AddD8.UseVisualStyleBackColor = false;
            this.AddD8.Click += new System.EventHandler(this.AddDice);
            // 
            // D8Amount
            // 
            this.D8Amount.AutoSize = true;
            this.D8Amount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.D8Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D8Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.D8Amount.Location = new System.Drawing.Point(435, 63);
            this.D8Amount.Name = "D8Amount";
            this.D8Amount.Size = new System.Drawing.Size(30, 32);
            this.D8Amount.TabIndex = 2;
            this.D8Amount.Text = "0";
            // 
            // DelD8
            // 
            this.DelD8.BackColor = System.Drawing.Color.Peru;
            this.DelD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelD8.ForeColor = System.Drawing.SystemColors.Info;
            this.DelD8.Location = new System.Drawing.Point(473, 63);
            this.DelD8.Name = "DelD8";
            this.DelD8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DelD8.Size = new System.Drawing.Size(55, 40);
            this.DelD8.TabIndex = 0;
            this.DelD8.Text = "— ";
            this.DelD8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelD8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DelD8.UseVisualStyleBackColor = false;
            this.DelD8.Click += new System.EventHandler(this.RemoveDice);
            // 
            // DelD12
            // 
            this.DelD12.BackColor = System.Drawing.Color.Peru;
            this.DelD12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelD12.ForeColor = System.Drawing.SystemColors.Info;
            this.DelD12.Location = new System.Drawing.Point(591, 63);
            this.DelD12.Name = "DelD12";
            this.DelD12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DelD12.Size = new System.Drawing.Size(55, 40);
            this.DelD12.TabIndex = 0;
            this.DelD12.Text = "— ";
            this.DelD12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelD12.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DelD12.UseVisualStyleBackColor = false;
            this.DelD12.Click += new System.EventHandler(this.RemoveDice);
            // 
            // D12Amount
            // 
            this.D12Amount.AutoSize = true;
            this.D12Amount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.D12Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D12Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.D12Amount.Location = new System.Drawing.Point(553, 63);
            this.D12Amount.Name = "D12Amount";
            this.D12Amount.Size = new System.Drawing.Size(30, 32);
            this.D12Amount.TabIndex = 2;
            this.D12Amount.Text = "0";
            // 
            // AddD12
            // 
            this.AddD12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddD12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddD12.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddD12.Location = new System.Drawing.Point(553, 12);
            this.AddD12.Name = "AddD12";
            this.AddD12.Size = new System.Drawing.Size(92, 48);
            this.AddD12.TabIndex = 0;
            this.AddD12.Text = "D12";
            this.AddD12.UseVisualStyleBackColor = false;
            this.AddD12.Click += new System.EventHandler(this.AddDice);
            // 
            // show_frame_btn
            // 
            this.show_frame_btn.BackColor = System.Drawing.Color.Thistle;
            this.show_frame_btn.Location = new System.Drawing.Point(12, 66);
            this.show_frame_btn.Name = "show_frame_btn";
            this.show_frame_btn.Size = new System.Drawing.Size(72, 48);
            this.show_frame_btn.TabIndex = 3;
            this.show_frame_btn.Text = "Frame";
            this.show_frame_btn.UseVisualStyleBackColor = false;
            this.show_frame_btn.Click += new System.EventHandler(this.show_frame_btn_Click);
            // 
            // RollerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_frame_btn);
            this.Controls.Add(this.AddD12);
            this.Controls.Add(this.D12Amount);
            this.Controls.Add(this.DelD12);
            this.Controls.Add(this.DelD8);
            this.Controls.Add(this.D8Amount);
            this.Controls.Add(this.AddD8);
            this.Controls.Add(this.DelD20);
            this.Controls.Add(this.D20Amount);
            this.Controls.Add(this.AddD20);
            this.Controls.Add(this.DelD6);
            this.Controls.Add(this.DelD4);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.D6Amount);
            this.Controls.Add(this.AddD6);
            this.Controls.Add(this.D4Amount);
            this.Controls.Add(this.AddD4);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.RollBtn);
            this.Name = "RollerWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpaRoller";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RollerWindow_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollBtn;
        private System.Windows.Forms.Button closeBtn;
        internal System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button AddD4;
        private System.Windows.Forms.Label D4Amount;
        private System.Windows.Forms.Button AddD6;
        private System.Windows.Forms.Label D6Amount;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button DelD4;
        private System.Windows.Forms.Button DelD6;
        private System.Windows.Forms.Button AddD20;
        private System.Windows.Forms.Label D20Amount;
        private System.Windows.Forms.Button DelD20;
        private System.Windows.Forms.Button AddD8;
        private System.Windows.Forms.Label D8Amount;
        private System.Windows.Forms.Button DelD8;
        private System.Windows.Forms.Button DelD12;
        private System.Windows.Forms.Label D12Amount;
        private System.Windows.Forms.Button AddD12;
        private System.Windows.Forms.Button show_frame_btn;
    }
}

