namespace MobiStore.UIForm
{
    partial class frm_products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_products));
            label1 = new Label();
            dgvUser = new DataGridView();
            text_search = new TextBox();
            lb_search = new Label();
            btn_clear = new Button();
            btn_del = new Button();
            btn_atualizar = new Button();
            btn_cadastrar = new Button();
            text_description = new TextBox();
            lb_descricao = new Label();
            text_name = new TextBox();
            title_categoria = new Label();
            text_ID = new TextBox();
            categoria_id = new Label();
            pictureBox1 = new PictureBox();
            nome = new Label();
            img_close = new PictureBox();
            lb_categoria = new Label();
            set_categoria = new ComboBox();
            text_value = new TextBox();
            lb_valor = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_close).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(253, 89, 85);
            label1.Location = new Point(547, 121);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 55;
            label1.Text = "•";
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = Color.FromArgb(31, 31, 31);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(578, 110);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(523, 313);
            dgvUser.TabIndex = 54;
            dgvUser.RowHeaderMouseClick += dgvUser_RowHeaderMouseClick;
            // 
            // text_search
            // 
            text_search.BackColor = Color.FromArgb(31, 31, 31);
            text_search.BorderStyle = BorderStyle.None;
            text_search.ForeColor = Color.White;
            text_search.Location = new Point(688, 75);
            text_search.Multiline = true;
            text_search.Name = "text_search";
            text_search.Size = new Size(413, 23);
            text_search.TabIndex = 53;
            text_search.TextChanged += text_search_TextChanged;
            // 
            // lb_search
            // 
            lb_search.AutoSize = true;
            lb_search.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_search.Location = new Point(578, 76);
            lb_search.Name = "lb_search";
            lb_search.Size = new Size(72, 17);
            lb_search.TabIndex = 52;
            lb_search.Text = "Pesquisar:";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(32, 120, 217);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.FromArgb(19, 73, 133);
            btn_clear.Location = new Point(162, 453);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(118, 34);
            btn_clear.TabIndex = 51;
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
            btn_del.Location = new Point(451, 362);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(90, 32);
            btn_del.TabIndex = 50;
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
            btn_atualizar.Location = new Point(308, 362);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(90, 32);
            btn_atualizar.TabIndex = 49;
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
            btn_cadastrar.Location = new Point(162, 362);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(90, 32);
            btn_cadastrar.TabIndex = 48;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // text_description
            // 
            text_description.BackColor = Color.FromArgb(31, 31, 31);
            text_description.BorderStyle = BorderStyle.None;
            text_description.ForeColor = Color.White;
            text_description.Location = new Point(162, 209);
            text_description.Multiline = true;
            text_description.Name = "text_description";
            text_description.Size = new Size(379, 75);
            text_description.TabIndex = 47;
            // 
            // lb_descricao
            // 
            lb_descricao.AutoSize = true;
            lb_descricao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_descricao.Location = new Point(76, 236);
            lb_descricao.Name = "lb_descricao";
            lb_descricao.Size = new Size(71, 17);
            lb_descricao.TabIndex = 46;
            lb_descricao.Text = "Descrição:";
            // 
            // text_name
            // 
            text_name.BackColor = Color.FromArgb(31, 31, 31);
            text_name.BorderStyle = BorderStyle.None;
            text_name.ForeColor = Color.White;
            text_name.Location = new Point(162, 119);
            text_name.Multiline = true;
            text_name.Name = "text_name";
            text_name.Size = new Size(379, 23);
            text_name.TabIndex = 45;
            // 
            // title_categoria
            // 
            title_categoria.AutoSize = true;
            title_categoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title_categoria.Location = new Point(28, 125);
            title_categoria.Name = "title_categoria";
            title_categoria.Size = new Size(123, 17);
            title_categoria.TabIndex = 44;
            title_categoria.Text = "Nome do Produto:";
            // 
            // text_ID
            // 
            text_ID.BackColor = Color.FromArgb(35, 44, 59);
            text_ID.BorderStyle = BorderStyle.None;
            text_ID.ForeColor = Color.White;
            text_ID.Location = new Point(162, 78);
            text_ID.Multiline = true;
            text_ID.Name = "text_ID";
            text_ID.ReadOnly = true;
            text_ID.Size = new Size(379, 23);
            text_ID.TabIndex = 43;
            // 
            // categoria_id
            // 
            categoria_id.AutoSize = true;
            categoria_id.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            categoria_id.Location = new Point(76, 78);
            categoria_id.Name = "categoria_id";
            categoria_id.Size = new Size(80, 17);
            categoria_id.TabIndex = 42;
            categoria_id.Text = "ID Produto:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nome.ForeColor = Color.White;
            nome.Location = new Point(543, 27);
            nome.Name = "nome";
            nome.Size = new Size(190, 21);
            nome.TabIndex = 40;
            nome.Text = "Formulário de Produtos";
            // 
            // img_close
            // 
            img_close.Image = (Image)resources.GetObject("img_close.Image");
            img_close.Location = new Point(1075, 30);
            img_close.Name = "img_close";
            img_close.Size = new Size(26, 27);
            img_close.SizeMode = PictureBoxSizeMode.StretchImage;
            img_close.TabIndex = 39;
            img_close.TabStop = false;
            img_close.Click += img_close_Click;
            // 
            // lb_categoria
            // 
            lb_categoria.AutoSize = true;
            lb_categoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_categoria.Location = new Point(76, 166);
            lb_categoria.Name = "lb_categoria";
            lb_categoria.Size = new Size(71, 17);
            lb_categoria.TabIndex = 57;
            lb_categoria.Text = "Categoria:";
            // 
            // set_categoria
            // 
            set_categoria.BackColor = Color.FromArgb(31, 31, 31);
            set_categoria.FlatStyle = FlatStyle.Flat;
            set_categoria.ForeColor = Color.White;
            set_categoria.FormattingEnabled = true;
            set_categoria.Location = new Point(162, 165);
            set_categoria.Name = "set_categoria";
            set_categoria.Size = new Size(379, 23);
            set_categoria.TabIndex = 58;
            // 
            // text_value
            // 
            text_value.BackColor = Color.FromArgb(31, 31, 31);
            text_value.BorderStyle = BorderStyle.None;
            text_value.ForeColor = Color.White;
            text_value.Location = new Point(162, 300);
            text_value.Multiline = true;
            text_value.Name = "text_value";
            text_value.Size = new Size(379, 23);
            text_value.TabIndex = 60;
            text_value.KeyPress += text_value_KeyPress;
            // 
            // lb_valor
            // 
            lb_valor.AutoSize = true;
            lb_valor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_valor.Location = new Point(102, 306);
            lb_valor.Name = "lb_valor";
            lb_valor.Size = new Size(45, 17);
            lb_valor.TabIndex = 59;
            lb_valor.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(253, 89, 85);
            label2.Location = new Point(547, 167);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 61;
            label2.Text = "•";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(253, 89, 85);
            label3.Location = new Point(547, 302);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 62;
            label3.Text = "•";
            // 
            // frm_products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1144, 527);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(text_value);
            Controls.Add(lb_valor);
            Controls.Add(set_categoria);
            Controls.Add(lb_categoria);
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
            Controls.Add(text_name);
            Controls.Add(title_categoria);
            Controls.Add(text_ID);
            Controls.Add(categoria_id);
            Controls.Add(pictureBox1);
            Controls.Add(nome);
            Controls.Add(img_close);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_products";
            Load += frm_products_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvUser;
        private TextBox text_search;
        private Label lb_search;
        private Button btn_clear;
        private Button btn_del;
        private Button btn_atualizar;
        private Button btn_cadastrar;
        private TextBox text_description;
        private Label lb_descricao;
        private TextBox text_name;
        private Label title_categoria;
        private TextBox text_ID;
        private Label categoria_id;
        private PictureBox pictureBox1;
        private Label nome;
        private PictureBox img_close;
        private Label lb_categoria;
        private ComboBox set_categoria;
        private TextBox text_value;
        private Label lb_valor;
        private Label label2;
        private Label label3;
    }
}