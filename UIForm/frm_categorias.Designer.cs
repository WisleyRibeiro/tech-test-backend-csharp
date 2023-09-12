namespace MobiStore.UIForm
{
    partial class frm_categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_categorias));
            pictureBox1 = new PictureBox();
            nome = new Label();
            img_close = new PictureBox();
            text_description = new TextBox();
            lb_descricao = new Label();
            text_title = new TextBox();
            title_categoria = new Label();
            text_ID = new TextBox();
            categoria_id = new Label();
            btn_clear = new Button();
            btn_del = new Button();
            btn_atualizar = new Button();
            btn_cadastrar = new Button();
            dgvUser = new DataGridView();
            text_search = new TextBox();
            lb_search = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nome.ForeColor = Color.White;
            nome.Location = new Point(512, 9);
            nome.Name = "nome";
            nome.Size = new Size(202, 21);
            nome.TabIndex = 1;
            nome.Text = "Formulário de Categorias";
            // 
            // img_close
            // 
            img_close.Image = (Image)resources.GetObject("img_close.Image");
            img_close.Location = new Point(1044, 12);
            img_close.Name = "img_close";
            img_close.Size = new Size(26, 27);
            img_close.SizeMode = PictureBoxSizeMode.StretchImage;
            img_close.TabIndex = 1;
            img_close.TabStop = false;
            img_close.Click += img_close_Click;
            // 
            // text_description
            // 
            text_description.BackColor = Color.FromArgb(31, 31, 31);
            text_description.BorderStyle = BorderStyle.None;
            text_description.ForeColor = Color.White;
            text_description.Location = new Point(131, 187);
            text_description.Multiline = true;
            text_description.Name = "text_description";
            text_description.Size = new Size(379, 75);
            text_description.TabIndex = 28;
            // 
            // lb_descricao
            // 
            lb_descricao.AutoSize = true;
            lb_descricao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_descricao.Location = new Point(21, 215);
            lb_descricao.Name = "lb_descricao";
            lb_descricao.Size = new Size(67, 17);
            lb_descricao.TabIndex = 25;
            lb_descricao.Text = "Descrição";
            // 
            // text_title
            // 
            text_title.BackColor = Color.FromArgb(31, 31, 31);
            text_title.BorderStyle = BorderStyle.None;
            text_title.ForeColor = Color.White;
            text_title.Location = new Point(131, 148);
            text_title.Multiline = true;
            text_title.Name = "text_title";
            text_title.Size = new Size(379, 23);
            text_title.TabIndex = 24;
            // 
            // title_categoria
            // 
            title_categoria.AutoSize = true;
            title_categoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title_categoria.Location = new Point(21, 149);
            title_categoria.Name = "title_categoria";
            title_categoria.Size = new Size(108, 17);
            title_categoria.TabIndex = 23;
            title_categoria.Text = "Título Categoria";
            // 
            // text_ID
            // 
            text_ID.BackColor = Color.FromArgb(35, 44, 59);
            text_ID.BorderStyle = BorderStyle.None;
            text_ID.ForeColor = Color.White;
            text_ID.Location = new Point(131, 114);
            text_ID.Multiline = true;
            text_ID.Name = "text_ID";
            text_ID.ReadOnly = true;
            text_ID.Size = new Size(379, 23);
            text_ID.TabIndex = 22;
            // 
            // categoria_id
            // 
            categoria_id.AutoSize = true;
            categoria_id.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            categoria_id.Location = new Point(21, 115);
            categoria_id.Name = "categoria_id";
            categoria_id.Size = new Size(89, 17);
            categoria_id.TabIndex = 21;
            categoria_id.Text = "ID Categoria:";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(32, 120, 217);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.FromArgb(19, 73, 133);
            btn_clear.Location = new Point(131, 371);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(118, 34);
            btn_clear.TabIndex = 33;
            btn_clear.Text = "Limpar campos";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.FromArgb(253, 89, 85);
            btn_del.FlatAppearance.BorderSize = 0;
            btn_del.FlatStyle = FlatStyle.Flat;
            btn_del.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.ForeColor = Color.FromArgb(130, 7, 2);
            btn_del.Location = new Point(420, 280);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(90, 32);
            btn_del.TabIndex = 32;
            btn_del.Text = "Deletar!";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += btn_del_Click;
            // 
            // btn_atualizar
            // 
            btn_atualizar.BackColor = Color.FromArgb(252, 188, 66);
            btn_atualizar.FlatAppearance.BorderSize = 0;
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_atualizar.ForeColor = Color.FromArgb(154, 87, 16);
            btn_atualizar.Location = new Point(277, 280);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(90, 32);
            btn_atualizar.TabIndex = 31;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(57, 198, 75);
            btn_cadastrar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.ForeColor = Color.FromArgb(10, 102, 12);
            btn_cadastrar.Location = new Point(131, 280);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(90, 32);
            btn_cadastrar.TabIndex = 30;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = Color.FromArgb(31, 31, 31);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(547, 92);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(523, 313);
            dgvUser.TabIndex = 36;
            dgvUser.RowHeaderMouseClick += dgvUser_RowHeaderMouseClick;
            // 
            // text_search
            // 
            text_search.BackColor = Color.FromArgb(31, 31, 31);
            text_search.BorderStyle = BorderStyle.None;
            text_search.ForeColor = Color.White;
            text_search.Location = new Point(657, 57);
            text_search.Multiline = true;
            text_search.Name = "text_search";
            text_search.Size = new Size(413, 23);
            text_search.TabIndex = 35;
            text_search.TextChanged += text_search_TextChanged;
            // 
            // lb_search
            // 
            lb_search.AutoSize = true;
            lb_search.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_search.Location = new Point(547, 58);
            lb_search.Name = "lb_search";
            lb_search.Size = new Size(72, 17);
            lb_search.TabIndex = 34;
            lb_search.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(253, 89, 85);
            label1.Location = new Point(516, 212);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 37;
            label1.Text = "•";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(253, 89, 85);
            label2.Location = new Point(516, 148);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 38;
            label2.Text = "•";
            // 
            // frm_categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1082, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUser);
            Controls.Add(text_search);
            Controls.Add(lb_search);
            Controls.Add(btn_clear);
            Controls.Add(btn_del);
            Controls.Add(btn_atualizar);
            Controls.Add(btn_cadastrar);
            Controls.Add(text_description);
            Controls.Add(lb_descricao);
            Controls.Add(text_title);
            Controls.Add(title_categoria);
            Controls.Add(text_ID);
            Controls.Add(categoria_id);
            Controls.Add(pictureBox1);
            Controls.Add(nome);
            Controls.Add(img_close);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_categorias";
            Load += frm_categorias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label nome;
        private PictureBox img_close;
        private TextBox text_description;
        private Label lb_descricao;
        private TextBox text_title;
        private Label title_categoria;
        private TextBox text_ID;
        private Label categoria_id;
        private Button btn_clear;
        private Button btn_del;
        private Button btn_atualizar;
        private Button btn_cadastrar;
        private DataGridView dgvUser;
        private TextBox text_search;
        private Label lb_search;
        private Label label1;
        private Label label2;
    }
}