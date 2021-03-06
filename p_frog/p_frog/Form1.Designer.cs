﻿namespace p_frog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.PictureBox();
            this.singlefrog = new System.Windows.Forms.CheckBox();
            this.doublefrog = new System.Windows.Forms.CheckBox();
            this.too_much_warn = new System.Windows.Forms.Label();
            this.no_choice_warn = new System.Windows.Forms.Label();
            this.button_info = new System.Windows.Forms.Button();
            this.help_key = new System.Windows.Forms.PictureBox();
            this.button_levels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_key)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(24, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rozpocznij grę";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.play_sound_graj);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(24, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wyjdź do\r\nWindows";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.play_sound_wyjdz);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chartreuse;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Location = new System.Drawing.Point(24, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Pomoc";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseLeave += new System.EventHandler(this.see_help_off);
            this.button4.MouseHover += new System.EventHandler(this.see_help_on);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Cyan;
            this.help.Cursor = System.Windows.Forms.Cursors.No;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(420, 12);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(408, 220);
            this.help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.help.TabIndex = 5;
            this.help.TabStop = false;
            this.help.Visible = false;
            // 
            // singlefrog
            // 
            this.singlefrog.BackColor = System.Drawing.Color.Chartreuse;
            this.singlefrog.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.singlefrog.Cursor = System.Windows.Forms.Cursors.Default;
            this.singlefrog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singlefrog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.singlefrog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.singlefrog.Location = new System.Drawing.Point(215, 323);
            this.singlefrog.Name = "singlefrog";
            this.singlefrog.Size = new System.Drawing.Size(174, 31);
            this.singlefrog.TabIndex = 6;
            this.singlefrog.Text = "Tryb jednego gracza";
            this.singlefrog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.singlefrog.UseVisualStyleBackColor = false;
            // 
            // doublefrog
            // 
            this.doublefrog.BackColor = System.Drawing.Color.Chartreuse;
            this.doublefrog.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.doublefrog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doublefrog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doublefrog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.doublefrog.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.doublefrog.Location = new System.Drawing.Point(215, 360);
            this.doublefrog.Name = "doublefrog";
            this.doublefrog.Size = new System.Drawing.Size(174, 31);
            this.doublefrog.TabIndex = 7;
            this.doublefrog.Text = "Tryb dwóch graczy";
            this.doublefrog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.doublefrog.UseVisualStyleBackColor = false;
            // 
            // too_much_warn
            // 
            this.too_much_warn.BackColor = System.Drawing.Color.Crimson;
            this.too_much_warn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.too_much_warn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.too_much_warn.ForeColor = System.Drawing.Color.AliceBlue;
            this.too_much_warn.Location = new System.Drawing.Point(24, 236);
            this.too_much_warn.Name = "too_much_warn";
            this.too_much_warn.Size = new System.Drawing.Size(258, 15);
            this.too_much_warn.TabIndex = 8;
            this.too_much_warn.Text = "Wybierz tylko jeden tryb.";
            this.too_much_warn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.too_much_warn.Visible = false;
            // 
            // no_choice_warn
            // 
            this.no_choice_warn.BackColor = System.Drawing.Color.Crimson;
            this.no_choice_warn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.no_choice_warn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.no_choice_warn.ForeColor = System.Drawing.Color.AliceBlue;
            this.no_choice_warn.Location = new System.Drawing.Point(24, 194);
            this.no_choice_warn.Name = "no_choice_warn";
            this.no_choice_warn.Size = new System.Drawing.Size(258, 15);
            this.no_choice_warn.TabIndex = 9;
            this.no_choice_warn.Text = "Nie wybrałeś żadnego trybu!";
            this.no_choice_warn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.no_choice_warn.Visible = false;
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.Chartreuse;
            this.button_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_info.CausesValidation = false;
            this.button_info.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button_info.FlatAppearance.BorderSize = 2;
            this.button_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_info.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_info.Location = new System.Drawing.Point(215, 259);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(174, 58);
            this.button_info.TabIndex = 10;
            this.button_info.Text = "Sterowanie";
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.MouseLeave += new System.EventHandler(this.show_off);
            this.button_info.MouseHover += new System.EventHandler(this.show_on);
            // 
            // help_key
            // 
            this.help_key.Image = global::p_frog.Properties.Resources.keys_info;
            this.help_key.Location = new System.Drawing.Point(420, 11);
            this.help_key.Name = "help_key";
            this.help_key.Size = new System.Drawing.Size(408, 221);
            this.help_key.TabIndex = 13;
            this.help_key.TabStop = false;
            this.help_key.Visible = false;
            // 
            // button_levels
            // 
            this.button_levels.BackColor = System.Drawing.Color.Chartreuse;
            this.button_levels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_levels.CausesValidation = false;
            this.button_levels.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button_levels.FlatAppearance.BorderSize = 2;
            this.button_levels.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_levels.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button_levels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_levels.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_levels.Location = new System.Drawing.Point(288, 194);
            this.button_levels.Name = "button_levels";
            this.button_levels.Size = new System.Drawing.Size(101, 58);
            this.button_levels.TabIndex = 12;
            this.button_levels.Text = "Etapy";
            this.button_levels.UseVisualStyleBackColor = false;
            this.button_levels.Click += new System.EventHandler(this.button_levels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(842, 481);
            this.ControlBox = false;
            this.Controls.Add(this.button_levels);
            this.Controls.Add(this.help_key);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.no_choice_warn);
            this.Controls.Add(this.too_much_warn);
            this.Controls.Add(this.doublefrog);
            this.Controls.Add(this.singlefrog);
            this.Controls.Add(this.help);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt Frog";
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.CheckBox singlefrog;
        private System.Windows.Forms.CheckBox doublefrog;
        private System.Windows.Forms.Label too_much_warn;
        private System.Windows.Forms.Label no_choice_warn;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.PictureBox help_key;
        private System.Windows.Forms.Button button_levels;
    }
}

