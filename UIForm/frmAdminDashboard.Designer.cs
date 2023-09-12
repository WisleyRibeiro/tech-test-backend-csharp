namespace MobiStore
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            pnlfooter = new Panel();
            label1 = new Label();
            btn_close = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lb_type = new Label();
            btn_chose_user = new Button();
            lblUser = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btn_created_user = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            btn_categorias = new Button();
            label7 = new Label();
            label8 = new Label();
            btn_products = new Button();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            button3 = new Button();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            label13 = new Label();
            label14 = new Label();
            btn_about = new Button();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pnlfooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            SuspendLayout();
            // 
            // pnlfooter
            // 
            pnlfooter.BackColor = Color.FromArgb(31, 31, 31);
            pnlfooter.Controls.Add(label1);
            pnlfooter.Dock = DockStyle.Bottom;
            pnlfooter.Location = new Point(0, 486);
            pnlfooter.Name = "pnlfooter";
            pnlfooter.Size = new Size(1036, 29);
            pnlfooter.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(31, 31, 31);
            label1.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 1;
            label1.Text = "Made with ❤️ by Wisley Ribeiro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            btn_close.Image = Properties.Resources.close;
            btn_close.Location = new Point(997, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(27, 27);
            btn_close.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_close.TabIndex = 4;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(34, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 407);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox2.Image = Properties.Resources.login;
            pictureBox2.Location = new Point(61, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // lb_type
            // 
            lb_type.AutoSize = true;
            lb_type.BackColor = Color.FromArgb(31, 31, 31);
            lb_type.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_type.ForeColor = Color.DimGray;
            lb_type.Location = new Point(181, 74);
            lb_type.Name = "lb_type";
            lb_type.Size = new Size(97, 17);
            lb_type.TabIndex = 19;
            lb_type.Text = "Administrador";
            // 
            // btn_chose_user
            // 
            btn_chose_user.BackColor = Color.FromArgb(0, 165, 246);
            btn_chose_user.FlatAppearance.BorderSize = 0;
            btn_chose_user.FlatStyle = FlatStyle.Flat;
            btn_chose_user.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chose_user.ForeColor = Color.White;
            btn_chose_user.Location = new Point(181, 115);
            btn_chose_user.Name = "btn_chose_user";
            btn_chose_user.Size = new Size(110, 27);
            btn_chose_user.TabIndex = 18;
            btn_chose_user.Text = "Trocar Usuário";
            btn_chose_user.UseVisualStyleBackColor = false;
            btn_chose_user.Click += btn_chose_user_Click_1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.FromArgb(31, 31, 31);
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(181, 53);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 21);
            lblUser.TabIndex = 17;
            lblUser.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(31, 31, 31);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 171);
            label2.Name = "label2";
            label2.Size = new Size(204, 120);
            label2.TabIndex = 21;
            label2.Text = "Olá, seja bem vindo ao Painel\r\nAdministrativo que possue \r\nfunções exclusivas para\r\nadministradores. Aqui você\r\npode cadastrar usuários,\r\ncategorias e produtos!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(349, 37);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(178, 199);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox5.Image = Properties.Resources.user;
            pictureBox5.Location = new Point(389, 44);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // btn_created_user
            // 
            btn_created_user.BackColor = Color.FromArgb(0, 165, 246);
            btn_created_user.FlatAppearance.BorderSize = 0;
            btn_created_user.FlatStyle = FlatStyle.Flat;
            btn_created_user.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_created_user.ForeColor = Color.White;
            btn_created_user.Location = new Point(389, 197);
            btn_created_user.Name = "btn_created_user";
            btn_created_user.Size = new Size(100, 27);
            btn_created_user.TabIndex = 25;
            btn_created_user.Text = "Gerenciar";
            btn_created_user.UseVisualStyleBackColor = false;
            btn_created_user.Click += btn_created_user_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(31, 31, 31);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(409, 97);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 26;
            label3.Text = "Usuários";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(31, 31, 31);
            label4.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(365, 133);
            label4.Name = "label4";
            label4.Size = new Size(146, 34);
            label4.TabIndex = 27;
            label4.Text = "Peinel de gerenciamento\r\nde usuários";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(31, 31, 31);
            label5.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(365, 338);
            label5.Name = "label5";
            label5.Size = new Size(146, 34);
            label5.TabIndex = 31;
            label5.Text = "Peinel de gerenciamento\r\nde categorias";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(31, 31, 31);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(397, 302);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 30;
            label6.Text = "Categorias";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox6.Image = Properties.Resources.categorias;
            pictureBox6.Location = new Point(389, 249);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(349, 242);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(178, 199);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 28;
            pictureBox7.TabStop = false;
            // 
            // btn_categorias
            // 
            btn_categorias.BackColor = Color.FromArgb(0, 165, 246);
            btn_categorias.FlatAppearance.BorderSize = 0;
            btn_categorias.FlatStyle = FlatStyle.Flat;
            btn_categorias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_categorias.ForeColor = Color.White;
            btn_categorias.Location = new Point(389, 402);
            btn_categorias.Name = "btn_categorias";
            btn_categorias.Size = new Size(100, 27);
            btn_categorias.TabIndex = 32;
            btn_categorias.Text = "Gerenciar";
            btn_categorias.UseVisualStyleBackColor = false;
            btn_categorias.Click += btn_categorias_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(31, 31, 31);
            label7.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(586, 133);
            label7.Name = "label7";
            label7.Size = new Size(146, 34);
            label7.TabIndex = 37;
            label7.Text = "Peinel de gerenciamento\r\nde produtos";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(31, 31, 31);
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(630, 97);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 36;
            label8.Text = "Produtos";
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.FromArgb(0, 165, 246);
            btn_products.FlatAppearance.BorderSize = 0;
            btn_products.FlatStyle = FlatStyle.Flat;
            btn_products.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_products.ForeColor = Color.White;
            btn_products.Location = new Point(610, 197);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(100, 27);
            btn_products.TabIndex = 35;
            btn_products.Text = "Gerenciar";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox8.Image = Properties.Resources.products;
            pictureBox8.Location = new Point(610, 44);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 34;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(570, 37);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(178, 199);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 33;
            pictureBox9.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(31, 31, 31);
            label9.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(586, 338);
            label9.Name = "label9";
            label9.Size = new Size(146, 34);
            label9.TabIndex = 42;
            label9.Text = "Peinel de gerenciamento\r\nde inventário";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(31, 31, 31);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(623, 302);
            label10.Name = "label10";
            label10.Size = new Size(71, 17);
            label10.TabIndex = 41;
            label10.Text = "Inventário";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 165, 246);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(610, 402);
            button2.Name = "button2";
            button2.Size = new Size(100, 27);
            button2.TabIndex = 40;
            button2.Text = "Gerenciar";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox10.Image = Properties.Resources.inventary;
            pictureBox10.Location = new Point(610, 249);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 50);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 39;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(570, 242);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(178, 199);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 38;
            pictureBox11.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(31, 31, 31);
            label11.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(797, 133);
            label11.Name = "label11";
            label11.Size = new Size(146, 34);
            label11.TabIndex = 47;
            label11.Text = "Peinel de gerenciamento\r\nde transações";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(31, 31, 31);
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(841, 97);
            label12.Name = "label12";
            label12.Size = new Size(75, 17);
            label12.TabIndex = 46;
            label12.Text = "Transações";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 165, 246);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(821, 197);
            button3.Name = "button3";
            button3.Size = new Size(100, 27);
            button3.TabIndex = 45;
            button3.Text = "Gerenciar";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox12.Image = Properties.Resources.money_pink_floyd_adoro_essa_musica;
            pictureBox12.Location = new Point(821, 44);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 50);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 44;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(781, 37);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(178, 199);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 43;
            pictureBox13.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(31, 31, 31);
            label13.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(813, 338);
            label13.Name = "label13";
            label13.Size = new Size(130, 17);
            label13.TabIndex = 52;
            label13.Text = "Sobre - Wisley Ribeiro";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(31, 31, 31);
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(851, 302);
            label14.Name = "label14";
            label14.Size = new Size(43, 17);
            label14.TabIndex = 51;
            label14.Text = "Sobre";
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.FromArgb(0, 165, 246);
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_about.ForeColor = Color.White;
            btn_about.Location = new Point(821, 402);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(100, 27);
            btn_about.TabIndex = 50;
            btn_about.Text = "Acessar";
            btn_about.UseVisualStyleBackColor = false;
            btn_about.Click += btn_about_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox14.Image = Properties.Resources.about;
            pictureBox14.Location = new Point(821, 249);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(100, 50);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 49;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(781, 242);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(178, 206);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 48;
            pictureBox15.TabStop = false;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1036, 515);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(btn_about);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox15);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btn_products);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(btn_categorias);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_created_user);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(lb_type);
            Controls.Add(btn_chose_user);
            Controls.Add(lblUser);
            Controls.Add(pictureBox3);
            Controls.Add(btn_close);
            Controls.Add(pnlfooter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MobiStore";
            pnlfooter.ResumeLayout(false);
            pnlfooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlfooter;
        private Label label1;
        private PictureBox btn_close;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lb_type;
        private Button btn_chose_user;
        private Label lblUser;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btn_created_user;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button btn_categorias;
        private Label label7;
        private Label label8;
        private Button btn_products;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label9;
        private Label label10;
        private Button button2;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label label11;
        private Label label12;
        private Button button3;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private Label label13;
        private Label label14;
        private Button btn_about;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
    }
}