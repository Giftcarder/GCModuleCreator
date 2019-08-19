using System;

namespace GiftCarder_Module_Creator
{
    partial class Creation
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
            this.CaptchaToggle = new System.Windows.Forms.CheckBox();
            this.PinToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TokenToggle = new System.Windows.Forms.CheckBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CookieToggle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.SiteKeyBox = new System.Windows.Forms.TextBox();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.SuccessBox = new System.Windows.Forms.TextBox();
            this.HeadersBox = new System.Windows.Forms.TextBox();
            this.MethodToggle = new System.Windows.Forms.CheckBox();
            this.RetriesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeoutBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CardLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PinBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CardFormatBox = new System.Windows.Forms.TextBox();
            this.StaticToggle = new System.Windows.Forms.CheckBox();
            this.ScrapeBox = new System.Windows.Forms.TextBox();
            this.Finish = new System.Windows.Forms.Button();
            this.HeaderTOGGLE = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PinDigitBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CaptchaToggle
            // 
            this.CaptchaToggle.AutoSize = true;
            this.CaptchaToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaptchaToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptchaToggle.ForeColor = System.Drawing.Color.White;
            this.CaptchaToggle.Location = new System.Drawing.Point(18, 102);
            this.CaptchaToggle.Name = "CaptchaToggle";
            this.CaptchaToggle.Size = new System.Drawing.Size(96, 17);
            this.CaptchaToggle.TabIndex = 0;
            this.CaptchaToggle.Text = "Uses Captcha?";
            this.CaptchaToggle.UseVisualStyleBackColor = false;
            // 
            // PinToggle
            // 
            this.PinToggle.AutoSize = true;
            this.PinToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinToggle.ForeColor = System.Drawing.Color.White;
            this.PinToggle.Location = new System.Drawing.Point(18, 79);
            this.PinToggle.Name = "PinToggle";
            this.PinToggle.Size = new System.Drawing.Size(70, 17);
            this.PinToggle.TabIndex = 1;
            this.PinToggle.Text = "Uses Pin?";
            this.PinToggle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Basic Settings: ";
            // 
            // TokenToggle
            // 
            this.TokenToggle.AutoSize = true;
            this.TokenToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TokenToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenToggle.ForeColor = System.Drawing.Color.White;
            this.TokenToggle.Location = new System.Drawing.Point(129, 102);
            this.TokenToggle.Name = "TokenToggle";
            this.TokenToggle.Size = new System.Drawing.Size(85, 17);
            this.TokenToggle.TabIndex = 3;
            this.TokenToggle.Text = "Uses Token?";
            this.TokenToggle.UseVisualStyleBackColor = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(18, 43);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(208, 22);
            this.NameBox.TabIndex = 4;
            this.NameBox.Text = "Name:";
            this.NameBox.Click += new System.EventHandler(this.NameBox_Click);
            // 
            // CookieToggle
            // 
            this.CookieToggle.AutoSize = true;
            this.CookieToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CookieToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookieToggle.ForeColor = System.Drawing.Color.White;
            this.CookieToggle.Location = new System.Drawing.Point(129, 79);
            this.CookieToggle.Name = "CookieToggle";
            this.CookieToggle.Size = new System.Drawing.Size(96, 17);
            this.CookieToggle.TabIndex = 5;
            this.CookieToggle.Text = "Uses Cookies?";
            this.CookieToggle.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Settings: ";
            // 
            // URLBox
            // 
            this.URLBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.URLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLBox.ForeColor = System.Drawing.Color.White;
            this.URLBox.Location = new System.Drawing.Point(18, 188);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(208, 22);
            this.URLBox.TabIndex = 7;
            this.URLBox.Text = "URL: ";
            this.URLBox.Click += new System.EventHandler(this.URLBox_Click);
            // 
            // SiteKeyBox
            // 
            this.SiteKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.SiteKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SiteKeyBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteKeyBox.ForeColor = System.Drawing.Color.White;
            this.SiteKeyBox.Location = new System.Drawing.Point(18, 214);
            this.SiteKeyBox.Name = "SiteKeyBox";
            this.SiteKeyBox.Size = new System.Drawing.Size(208, 22);
            this.SiteKeyBox.TabIndex = 8;
            this.SiteKeyBox.Text = "SITEKEY:";
            this.SiteKeyBox.Click += new System.EventHandler(this.SiteKeyBox_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBox.ForeColor = System.Drawing.Color.White;
            this.ErrorBox.Location = new System.Drawing.Point(18, 240);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(208, 22);
            this.ErrorBox.TabIndex = 9;
            this.ErrorBox.Text = "ERROR KEY:";
            this.ErrorBox.Click += new System.EventHandler(this.ErrorBox_Click);
            // 
            // SuccessBox
            // 
            this.SuccessBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.SuccessBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SuccessBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessBox.ForeColor = System.Drawing.Color.White;
            this.SuccessBox.Location = new System.Drawing.Point(18, 266);
            this.SuccessBox.Name = "SuccessBox";
            this.SuccessBox.Size = new System.Drawing.Size(208, 22);
            this.SuccessBox.TabIndex = 10;
            this.SuccessBox.Text = "SUCCESS KEY: ";
            this.SuccessBox.Click += new System.EventHandler(this.SuccessBox_Click);
            // 
            // HeadersBox
            // 
            this.HeadersBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.HeadersBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadersBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadersBox.ForeColor = System.Drawing.Color.White;
            this.HeadersBox.Location = new System.Drawing.Point(261, 188);
            this.HeadersBox.Multiline = true;
            this.HeadersBox.Name = "HeadersBox";
            this.HeadersBox.Size = new System.Drawing.Size(218, 74);
            this.HeadersBox.TabIndex = 11;
            this.HeadersBox.Text = "Cutom Headers (Seperate with \":\")";
            this.HeadersBox.Click += new System.EventHandler(this.HeadersBox_Click);
            // 
            // MethodToggle
            // 
            this.MethodToggle.AutoSize = true;
            this.MethodToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodToggle.ForeColor = System.Drawing.Color.White;
            this.MethodToggle.Location = new System.Drawing.Point(18, 292);
            this.MethodToggle.Name = "MethodToggle";
            this.MethodToggle.Size = new System.Drawing.Size(91, 17);
            this.MethodToggle.TabIndex = 12;
            this.MethodToggle.Text = "Post request?";
            this.MethodToggle.UseVisualStyleBackColor = false;
            // 
            // RetriesBox
            // 
            this.RetriesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.RetriesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RetriesBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetriesBox.ForeColor = System.Drawing.Color.White;
            this.RetriesBox.Location = new System.Drawing.Point(60, 123);
            this.RetriesBox.Name = "RetriesBox";
            this.RetriesBox.Size = new System.Drawing.Size(23, 22);
            this.RetriesBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Retries:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Timeout:";
            // 
            // TimeoutBox
            // 
            this.TimeoutBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TimeoutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeoutBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeoutBox.ForeColor = System.Drawing.Color.White;
            this.TimeoutBox.Location = new System.Drawing.Point(176, 123);
            this.TimeoutBox.Name = "TimeoutBox";
            this.TimeoutBox.Size = new System.Drawing.Size(23, 22);
            this.TimeoutBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Generation Settings:";
            // 
            // CardLength
            // 
            this.CardLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CardLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardLength.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardLength.ForeColor = System.Drawing.Color.White;
            this.CardLength.Location = new System.Drawing.Point(325, 43);
            this.CardLength.Name = "CardLength";
            this.CardLength.Size = new System.Drawing.Size(43, 22);
            this.CardLength.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(254, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Card length:";
            // 
            // PinBox
            // 
            this.PinBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinBox.ForeColor = System.Drawing.Color.White;
            this.PinBox.Location = new System.Drawing.Point(443, 43);
            this.PinBox.Name = "PinBox";
            this.PinBox.Size = new System.Drawing.Size(43, 22);
            this.PinBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(376, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "PIN length:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(254, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Card Format:";
            // 
            // CardFormatBox
            // 
            this.CardFormatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CardFormatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardFormatBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardFormatBox.ForeColor = System.Drawing.Color.White;
            this.CardFormatBox.Location = new System.Drawing.Point(328, 77);
            this.CardFormatBox.Name = "CardFormatBox";
            this.CardFormatBox.Size = new System.Drawing.Size(158, 22);
            this.CardFormatBox.TabIndex = 21;
            // 
            // StaticToggle
            // 
            this.StaticToggle.AutoSize = true;
            this.StaticToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaticToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticToggle.ForeColor = System.Drawing.Color.White;
            this.StaticToggle.Location = new System.Drawing.Point(403, 107);
            this.StaticToggle.Name = "StaticToggle";
            this.StaticToggle.Size = new System.Drawing.Size(83, 17);
            this.StaticToggle.TabIndex = 24;
            this.StaticToggle.Text = "Static Card?";
            this.StaticToggle.UseVisualStyleBackColor = false;
            // 
            // ScrapeBox
            // 
            this.ScrapeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ScrapeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScrapeBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrapeBox.ForeColor = System.Drawing.Color.White;
            this.ScrapeBox.Location = new System.Drawing.Point(261, 266);
            this.ScrapeBox.Name = "ScrapeBox";
            this.ScrapeBox.Size = new System.Drawing.Size(218, 22);
            this.ScrapeBox.TabIndex = 25;
            this.ScrapeBox.Text = "SCRAPE RESPONSE";
            this.ScrapeBox.Click += new System.EventHandler(this.ScrapeBox_Click);
            // 
            // Finish
            // 
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.ForeColor = System.Drawing.Color.White;
            this.Finish.Location = new System.Drawing.Point(311, 308);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(127, 35);
            this.Finish.TabIndex = 26;
            this.Finish.Text = "Create Module";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // HeaderTOGGLE
            // 
            this.HeaderTOGGLE.AutoSize = true;
            this.HeaderTOGGLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderTOGGLE.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderTOGGLE.ForeColor = System.Drawing.Color.White;
            this.HeaderTOGGLE.Location = new System.Drawing.Point(134, 292);
            this.HeaderTOGGLE.Name = "HeaderTOGGLE";
            this.HeaderTOGGLE.Size = new System.Drawing.Size(92, 17);
            this.HeaderTOGGLE.TabIndex = 27;
            this.HeaderTOGGLE.Text = "Use Headers?";
            this.HeaderTOGGLE.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(298, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "PIN: ";
            // 
            // PinDigitBox
            // 
            this.PinDigitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PinDigitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinDigitBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinDigitBox.ForeColor = System.Drawing.Color.White;
            this.PinDigitBox.Location = new System.Drawing.Point(328, 105);
            this.PinDigitBox.Name = "PinDigitBox";
            this.PinDigitBox.Size = new System.Drawing.Size(43, 22);
            this.PinDigitBox.TabIndex = 29;
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(505, 355);
            this.Controls.Add(this.PinDigitBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HeaderTOGGLE);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.ScrapeBox);
            this.Controls.Add(this.StaticToggle);
            this.Controls.Add(this.CardFormatBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PinBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CardLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeoutBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RetriesBox);
            this.Controls.Add(this.MethodToggle);
            this.Controls.Add(this.HeadersBox);
            this.Controls.Add(this.SuccessBox);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.SiteKeyBox);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CookieToggle);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.TokenToggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PinToggle);
            this.Controls.Add(this.CaptchaToggle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Creation";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GiftCarder Module Creator V1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.CheckBox CaptchaToggle;
        private System.Windows.Forms.CheckBox PinToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TokenToggle;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.CheckBox CookieToggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.TextBox SiteKeyBox;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.TextBox SuccessBox;
        private System.Windows.Forms.TextBox HeadersBox;
        private System.Windows.Forms.CheckBox MethodToggle;
        private System.Windows.Forms.TextBox RetriesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimeoutBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CardLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PinBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CardFormatBox;
        private System.Windows.Forms.CheckBox StaticToggle;
        private System.Windows.Forms.TextBox ScrapeBox;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.CheckBox HeaderTOGGLE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PinDigitBox;
    }
}

