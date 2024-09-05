
namespace WindowsFormsApp5
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
            this.btn_verify = new Guna.UI2.WinForms.Guna2Button();
            this.btn_send = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btn_verify
            // 
            this.btn_verify.CheckedState.Parent = this.btn_verify;
            this.btn_verify.CustomImages.Parent = this.btn_verify;
            this.btn_verify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_verify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_verify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_verify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_verify.DisabledState.Parent = this.btn_verify;
            this.btn_verify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_verify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_verify.ForeColor = System.Drawing.Color.White;
            this.btn_verify.HoverState.Parent = this.btn_verify;
            this.btn_verify.Location = new System.Drawing.Point(270, 235);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.ShadowDecoration.Parent = this.btn_verify;
            this.btn_verify.Size = new System.Drawing.Size(126, 25);
            this.btn_verify.TabIndex = 0;
            this.btn_verify.Text = "Verify";
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // btn_send
            // 
            this.btn_send.CheckedState.Parent = this.btn_send;
            this.btn_send.CustomImages.Parent = this.btn_send;
            this.btn_send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_send.DisabledState.Parent = this.btn_send;
            this.btn_send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.HoverState.Parent = this.btn_send;
            this.btn_send.Location = new System.Drawing.Point(270, 143);
            this.btn_send.Name = "btn_send";
            this.btn_send.ShadowDecoration.Parent = this.btn_send;
            this.btn_send.Size = new System.Drawing.Size(126, 25);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send Code";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(85, 122);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(28, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Email";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(70, 214);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(56, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Enter Code";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.Parent = this.txt_email;
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.FocusedState.Parent = this.txt_email;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.HoverState.Parent = this.txt_email;
            this.txt_email.Location = new System.Drawing.Point(185, 113);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.ShadowDecoration.Parent = this.txt_email;
            this.txt_email.Size = new System.Drawing.Size(257, 24);
            this.txt_email.TabIndex = 4;
            // 
            // txt_code
            // 
            this.txt_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_code.DefaultText = "";
            this.txt_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_code.DisabledState.Parent = this.txt_code;
            this.txt_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_code.FocusedState.Parent = this.txt_code;
            this.txt_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_code.HoverState.Parent = this.txt_code;
            this.txt_code.Location = new System.Drawing.Point(185, 206);
            this.txt_code.Name = "txt_code";
            this.txt_code.PasswordChar = '\0';
            this.txt_code.PlaceholderText = "";
            this.txt_code.SelectedText = "";
            this.txt_code.ShadowDecoration.Parent = this.txt_code;
            this.txt_code.Size = new System.Drawing.Size(257, 23);
            this.txt_code.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 341);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_verify);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_verify;
        private Guna.UI2.WinForms.Guna2Button btn_send;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_code;
    }
}