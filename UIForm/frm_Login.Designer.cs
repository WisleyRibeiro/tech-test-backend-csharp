namespace MobiStore.UIForm
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            btn_close = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lb_login = new Label();
            text_user = new TextBox();
            lb_user_name = new Label();
            lb_pass = new Label();
            text_pass = new TextBox();
            lb_user_type = new Label();
            set_user_type = new ComboBox();
            btn_login = new Button();
            pictureBox2 = new PictureBox();
            lb_by = new Label();
            lb_byWisley = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Image = Properties.Resources.close;
            btn_close.Location = new Point(856, 5);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(27, 27);
            btn_close.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_close.TabIndex = 0;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // lb_login
            // 
            lb_login.AutoSize = true;
            lb_login.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_login.ForeColor = Color.White;
            lb_login.Location = new Point(596, 45);
            lb_login.Name = "lb_login";
            lb_login.Size = new Size(112, 47);
            lb_login.TabIndex = 2;
            lb_login.Text = "Login";
            // 
            // text_user
            // 
            text_user.BackColor = Color.FromArgb(31, 31, 31);
            text_user.BorderStyle = BorderStyle.None;
            text_user.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            text_user.ForeColor = Color.White;
            text_user.Location = new Point(482, 138);
            text_user.Multiline = true;
            text_user.Name = "text_user";
            text_user.PlaceholderText = "@";
            text_user.Size = new Size(357, 36);
            text_user.TabIndex = 3;
            text_user.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_user_name
            // 
            lb_user_name.AutoSize = true;
            lb_user_name.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_user_name.ForeColor = Color.FromArgb(0, 236, 150);
            lb_user_name.Location = new Point(482, 120);
            lb_user_name.Name = "lb_user_name";
            lb_user_name.Size = new Size(47, 15);
            lb_user_name.TabIndex = 4;
            lb_user_name.Text = "Usuário";
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pass.ForeColor = Color.FromArgb(0, 236, 150);
            lb_pass.Location = new Point(482, 212);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(42, 15);
            lb_pass.TabIndex = 5;
            lb_pass.Text = "Senha:";
            // 
            // text_pass
            // 
            text_pass.BackColor = Color.FromArgb(31, 31, 31);
            text_pass.BorderStyle = BorderStyle.None;
            text_pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            text_pass.ForeColor = Color.White;
            text_pass.Location = new Point(482, 230);
            text_pass.Multiline = true;
            text_pass.Name = "text_pass";
            text_pass.PasswordChar = '•';
            text_pass.PlaceholderText = "••••••••";
            text_pass.Size = new Size(357, 36);
            text_pass.TabIndex = 6;
            text_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_user_type
            // 
            lb_user_type.AutoSize = true;
            lb_user_type.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_user_type.ForeColor = Color.FromArgb(0, 236, 150);
            lb_user_type.Location = new Point(482, 294);
            lb_user_type.Name = "lb_user_type";
            lb_user_type.Size = new Size(91, 15);
            lb_user_type.TabIndex = 7;
            lb_user_type.Text = "Tipo de usuário:";
            // 
            // set_user_type
            // 
            set_user_type.BackColor = Color.FromArgb(31, 31, 31);
            set_user_type.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            set_user_type.ForeColor = Color.White;
            set_user_type.FormattingEnabled = true;
            set_user_type.Items.AddRange(new object[] { "Administrador", "Comum" });
            set_user_type.Location = new Point(482, 312);
            set_user_type.Name = "set_user_type";
            set_user_type.Size = new Size(357, 38);
            set_user_type.TabIndex = 8;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 165, 246);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(596, 384);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 42);
            btn_login.TabIndex = 9;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 301);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 14);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lb_by
            // 
            lb_by.Location = new Point(0, 0);
            lb_by.Name = "lb_by";
            lb_by.Size = new Size(100, 23);
            lb_by.TabIndex = 0;
            // 
            // lb_byWisley
            // 
            lb_byWisley.AutoSize = true;
            lb_byWisley.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_byWisley.ForeColor = Color.FromArgb(0, 236, 150);
            lb_byWisley.Location = new Point(4, 429);
            lb_byWisley.Name = "lb_byWisley";
            lb_byWisley.Size = new Size(57, 15);
            lb_byWisley.TabIndex = 11;
            lb_byWisley.Text = "by Wisley";
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(892, 450);
            Controls.Add(lb_byWisley);
            Controls.Add(lb_by);
            Controls.Add(pictureBox2);
            Controls.Add(btn_login);
            Controls.Add(set_user_type);
            Controls.Add(lb_user_type);
            Controls.Add(text_pass);
            Controls.Add(lb_pass);
            Controls.Add(lb_user_name);
            Controls.Add(text_user);
            Controls.Add(lb_login);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Login";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lb_login;
        private TextBox text_user;
        private Label lb_user_name;
        private Label lb_pass;
        private TextBox text_pass;
        private Label lb_user_type;
        private ComboBox set_user_type;
        private Button btn_login;
        private PictureBox pictureBox2;
        private Label lb_by;
        private Label lb_byWisley;
    }
}