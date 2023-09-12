namespace MobiStore.UIForm
{
    partial class frm_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_User));
            img_close = new PictureBox();
            nome = new Label();
            pictureBox1 = new PictureBox();
            usr_ID = new Label();
            text_ID = new TextBox();
            text_First_Name = new TextBox();
            first_name = new Label();
            text_Last_Name = new TextBox();
            secound_name = new Label();
            text_mail = new TextBox();
            lb_mail = new Label();
            text_user_name = new TextBox();
            nick_name = new Label();
            text_pass = new TextBox();
            lb_pass = new Label();
            text_adress = new TextBox();
            lb_adress = new Label();
            lb_gener = new Label();
            lb_user_type = new Label();
            set_gener = new ComboBox();
            set_user_type = new ComboBox();
            text_contact = new TextBox();
            lb_contact = new Label();
            text_search = new TextBox();
            lb_search = new Label();
            dgvUser = new DataGridView();
            btn_cadastrar = new Button();
            btn_atualizar = new Button();
            btn_del = new Button();
            btn_clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            text_pass2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)img_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // img_close
            // 
            img_close.Image = (Image)resources.GetObject("img_close.Image");
            img_close.Location = new Point(1158, 6);
            img_close.Name = "img_close";
            img_close.Size = new Size(26, 27);
            img_close.SizeMode = PictureBoxSizeMode.StretchImage;
            img_close.TabIndex = 1;
            img_close.TabStop = false;
            img_close.Click += img_close_Click;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nome.ForeColor = Color.White;
            nome.Location = new Point(487, 9);
            nome.Name = "nome";
            nome.Size = new Size(187, 21);
            nome.TabIndex = 1;
            nome.Text = "Formulário de Usuários";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // usr_ID
            // 
            usr_ID.AutoSize = true;
            usr_ID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usr_ID.Location = new Point(14, 54);
            usr_ID.Name = "usr_ID";
            usr_ID.Size = new Size(96, 17);
            usr_ID.TabIndex = 1;
            usr_ID.Text = "ID de Usuário:";
            // 
            // text_ID
            // 
            text_ID.BackColor = Color.FromArgb(35, 44, 59);
            text_ID.BorderStyle = BorderStyle.None;
            text_ID.Enabled = false;
            text_ID.ForeColor = Color.White;
            text_ID.Location = new Point(124, 53);
            text_ID.Multiline = true;
            text_ID.Name = "text_ID";
            text_ID.ReadOnly = true;
            text_ID.Size = new Size(379, 23);
            text_ID.TabIndex = 2;
            // 
            // text_First_Name
            // 
            text_First_Name.BackColor = Color.FromArgb(31, 31, 31);
            text_First_Name.BorderStyle = BorderStyle.None;
            text_First_Name.ForeColor = Color.White;
            text_First_Name.Location = new Point(124, 87);
            text_First_Name.Multiline = true;
            text_First_Name.Name = "text_First_Name";
            text_First_Name.Size = new Size(379, 23);
            text_First_Name.TabIndex = 4;
            // 
            // first_name
            // 
            first_name.AutoSize = true;
            first_name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            first_name.Location = new Point(14, 88);
            first_name.Name = "first_name";
            first_name.Size = new Size(104, 17);
            first_name.TabIndex = 3;
            first_name.Text = "Primeiro nome:";
            // 
            // text_Last_Name
            // 
            text_Last_Name.BackColor = Color.FromArgb(31, 31, 31);
            text_Last_Name.BorderStyle = BorderStyle.None;
            text_Last_Name.ForeColor = Color.White;
            text_Last_Name.Location = new Point(124, 123);
            text_Last_Name.Multiline = true;
            text_Last_Name.Name = "text_Last_Name";
            text_Last_Name.Size = new Size(379, 23);
            text_Last_Name.TabIndex = 6;
            // 
            // secound_name
            // 
            secound_name.AutoSize = true;
            secound_name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            secound_name.Location = new Point(14, 124);
            secound_name.Name = "secound_name";
            secound_name.Size = new Size(82, 17);
            secound_name.TabIndex = 5;
            secound_name.Text = "Sobrenome:";
            // 
            // text_mail
            // 
            text_mail.BackColor = Color.FromArgb(31, 31, 31);
            text_mail.BorderStyle = BorderStyle.None;
            text_mail.ForeColor = Color.White;
            text_mail.Location = new Point(124, 160);
            text_mail.Multiline = true;
            text_mail.Name = "text_mail";
            text_mail.Size = new Size(379, 23);
            text_mail.TabIndex = 8;
            // 
            // lb_mail
            // 
            lb_mail.AutoSize = true;
            lb_mail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_mail.Location = new Point(14, 161);
            lb_mail.Name = "lb_mail";
            lb_mail.Size = new Size(51, 17);
            lb_mail.TabIndex = 7;
            lb_mail.Text = "E-mail:";
            // 
            // text_user_name
            // 
            text_user_name.BackColor = Color.FromArgb(31, 31, 31);
            text_user_name.BorderStyle = BorderStyle.None;
            text_user_name.ForeColor = Color.White;
            text_user_name.Location = new Point(124, 199);
            text_user_name.Multiline = true;
            text_user_name.Name = "text_user_name";
            text_user_name.Size = new Size(379, 23);
            text_user_name.TabIndex = 10;
            // 
            // nick_name
            // 
            nick_name.AutoSize = true;
            nick_name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nick_name.Location = new Point(14, 200);
            nick_name.Name = "nick_name";
            nick_name.Size = new Size(100, 17);
            nick_name.TabIndex = 9;
            nick_name.Text = "Nome Usuário:";
            // 
            // text_pass
            // 
            text_pass.BackColor = Color.FromArgb(31, 31, 31);
            text_pass.BorderStyle = BorderStyle.None;
            text_pass.ForeColor = Color.White;
            text_pass.Location = new Point(124, 234);
            text_pass.Multiline = true;
            text_pass.Name = "text_pass";
            text_pass.PasswordChar = '•';
            text_pass.PlaceholderText = "Digite a senha...";
            text_pass.Size = new Size(184, 23);
            text_pass.TabIndex = 12;
            text_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pass.Location = new Point(14, 235);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(49, 17);
            lb_pass.TabIndex = 11;
            lb_pass.Text = "Senha:";
            // 
            // text_adress
            // 
            text_adress.BackColor = Color.FromArgb(31, 31, 31);
            text_adress.BorderStyle = BorderStyle.None;
            text_adress.ForeColor = Color.White;
            text_adress.Location = new Point(124, 312);
            text_adress.Multiline = true;
            text_adress.Name = "text_adress";
            text_adress.Size = new Size(379, 75);
            text_adress.TabIndex = 14;
            // 
            // lb_adress
            // 
            lb_adress.AutoSize = true;
            lb_adress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_adress.Location = new Point(14, 342);
            lb_adress.Name = "lb_adress";
            lb_adress.Size = new Size(68, 17);
            lb_adress.TabIndex = 13;
            lb_adress.Text = "Endereço:";
            // 
            // lb_gener
            // 
            lb_gener.AutoSize = true;
            lb_gener.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_gener.Location = new Point(14, 410);
            lb_gener.Name = "lb_gener";
            lb_gener.Size = new Size(41, 17);
            lb_gener.TabIndex = 15;
            lb_gener.Text = "Sexo:";
            // 
            // lb_user_type
            // 
            lb_user_type.AutoSize = true;
            lb_user_type.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_user_type.Location = new Point(14, 455);
            lb_user_type.Name = "lb_user_type";
            lb_user_type.Size = new Size(106, 17);
            lb_user_type.TabIndex = 17;
            lb_user_type.Text = "Tipo de Usuário";
            // 
            // set_gener
            // 
            set_gener.BackColor = Color.FromArgb(31, 31, 31);
            set_gener.ForeColor = Color.White;
            set_gener.FormattingEnabled = true;
            set_gener.Items.AddRange(new object[] { "Masculino", "Feminino", "Não Binário" });
            set_gener.Location = new Point(124, 410);
            set_gener.Name = "set_gener";
            set_gener.Size = new Size(379, 23);
            set_gener.TabIndex = 18;
            // 
            // set_user_type
            // 
            set_user_type.BackColor = Color.FromArgb(31, 31, 31);
            set_user_type.ForeColor = Color.White;
            set_user_type.FormattingEnabled = true;
            set_user_type.Items.AddRange(new object[] { "Administrador", "Comum" });
            set_user_type.Location = new Point(124, 454);
            set_user_type.Name = "set_user_type";
            set_user_type.Size = new Size(379, 23);
            set_user_type.TabIndex = 19;
            // 
            // text_contact
            // 
            text_contact.BackColor = Color.FromArgb(31, 31, 31);
            text_contact.BorderStyle = BorderStyle.None;
            text_contact.ForeColor = Color.White;
            text_contact.Location = new Point(124, 269);
            text_contact.Multiline = true;
            text_contact.Name = "text_contact";
            text_contact.Size = new Size(379, 23);
            text_contact.TabIndex = 22;
            // 
            // lb_contact
            // 
            lb_contact.AutoSize = true;
            lb_contact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_contact.Location = new Point(14, 270);
            lb_contact.Name = "lb_contact";
            lb_contact.Size = new Size(61, 17);
            lb_contact.TabIndex = 21;
            lb_contact.Text = "Contato:";
            // 
            // text_search
            // 
            text_search.BackColor = Color.FromArgb(31, 31, 31);
            text_search.BorderStyle = BorderStyle.None;
            text_search.ForeColor = Color.White;
            text_search.Location = new Point(673, 54);
            text_search.Multiline = true;
            text_search.Name = "text_search";
            text_search.Size = new Size(505, 23);
            text_search.TabIndex = 24;
            text_search.TextChanged += text_search_TextChanged;
            // 
            // lb_search
            // 
            lb_search.AutoSize = true;
            lb_search.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_search.Location = new Point(563, 55);
            lb_search.Name = "lb_search";
            lb_search.Size = new Size(72, 17);
            lb_search.TabIndex = 23;
            lb_search.Text = "Pesquisar:";
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = Color.FromArgb(31, 31, 31);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(563, 87);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(615, 346);
            dgvUser.TabIndex = 25;
            dgvUser.RowHeaderMouseClick += dgvUser_RowHeaderMouseClick;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(57, 198, 75);
            btn_cadastrar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.ForeColor = Color.FromArgb(10, 102, 12);
            btn_cadastrar.Location = new Point(569, 455);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(90, 32);
            btn_cadastrar.TabIndex = 26;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_atualizar
            // 
            btn_atualizar.BackColor = Color.FromArgb(252, 188, 66);
            btn_atualizar.FlatAppearance.BorderSize = 0;
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_atualizar.ForeColor = Color.FromArgb(154, 87, 16);
            btn_atualizar.Location = new Point(842, 456);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(90, 32);
            btn_atualizar.TabIndex = 27;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.FromArgb(253, 89, 85);
            btn_del.FlatAppearance.BorderSize = 0;
            btn_del.FlatStyle = FlatStyle.Flat;
            btn_del.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.ForeColor = Color.FromArgb(130, 7, 2);
            btn_del.Location = new Point(1088, 456);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(90, 32);
            btn_del.TabIndex = 28;
            btn_del.Text = "Deletar!";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += btn_del_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(32, 120, 217);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.FromArgb(19, 73, 133);
            btn_clear.Location = new Point(233, 485);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(118, 34);
            btn_clear.TabIndex = 29;
            btn_clear.Text = "Limpar campos";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(253, 89, 85);
            label1.Location = new Point(509, 88);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 30;
            label1.Text = "•";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(253, 89, 85);
            label2.Location = new Point(509, 125);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 31;
            label2.Text = "•";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(253, 89, 85);
            label3.Location = new Point(509, 236);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 32;
            label3.Text = "•";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(253, 89, 85);
            label4.Location = new Point(509, 456);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 33;
            label4.Text = "•";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(253, 89, 85);
            label5.Location = new Point(509, 201);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 34;
            label5.Text = "•";
            // 
            // text_pass2
            // 
            text_pass2.BackColor = Color.FromArgb(31, 31, 31);
            text_pass2.BorderStyle = BorderStyle.None;
            text_pass2.ForeColor = Color.White;
            text_pass2.Location = new Point(319, 234);
            text_pass2.Multiline = true;
            text_pass2.Name = "text_pass2";
            text_pass2.PasswordChar = '•';
            text_pass2.PlaceholderText = "Confirme a senha";
            text_pass2.Size = new Size(184, 23);
            text_pass2.TabIndex = 35;
            text_pass2.TextAlign = HorizontalAlignment.Center;
            // 
            // frm_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1190, 529);
            Controls.Add(text_pass2);
            Controls.Add(img_close);
            Controls.Add(nome);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_clear);
            Controls.Add(btn_del);
            Controls.Add(btn_atualizar);
            Controls.Add(btn_cadastrar);
            Controls.Add(dgvUser);
            Controls.Add(text_search);
            Controls.Add(lb_search);
            Controls.Add(text_contact);
            Controls.Add(lb_contact);
            Controls.Add(set_user_type);
            Controls.Add(set_gener);
            Controls.Add(lb_user_type);
            Controls.Add(lb_gener);
            Controls.Add(text_adress);
            Controls.Add(lb_adress);
            Controls.Add(text_pass);
            Controls.Add(lb_pass);
            Controls.Add(text_user_name);
            Controls.Add(nick_name);
            Controls.Add(text_mail);
            Controls.Add(lb_mail);
            Controls.Add(text_Last_Name);
            Controls.Add(secound_name);
            Controls.Add(text_First_Name);
            Controls.Add(first_name);
            Controls.Add(text_ID);
            Controls.Add(usr_ID);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários";
            Load += frm_User_Load;
            ((System.ComponentModel.ISupportInitialize)img_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nome;
        private PictureBox img_close;
        private Label usr_ID;
        private TextBox text_ID;
        private TextBox text_First_Name;
        private Label first_name;
        private TextBox text_Last_Name;
        private Label secound_name;
        private TextBox text_mail;
        private Label lb_mail;
        private TextBox text_user_name;
        private Label nick_name;
        private TextBox text_pass;
        private Label lb_pass;
        private TextBox text_adress;
        private Label lb_adress;
        private Label lb_gener;
        private Label lb_user_type;
        private ComboBox set_gener;
        private ComboBox set_user_type;
        private PictureBox pictureBox1;
        private TextBox text_contact;
        private Label lb_contact;
        private TextBox text_search;
        private Label lb_search;
        private DataGridView dgvUser;
        private Button btn_cadastrar;
        private Button btn_atualizar;
        private Button btn_del;
        private Button btn_clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox text_pass2;
    }
}