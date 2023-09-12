namespace MobiStore.UIForm
{
    partial class frm_Purchase_AND_Sale
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
            btn_close = new PictureBox();
            lb_top = new Label();
            text_search = new TextBox();
            label1 = new Label();
            label2 = new Label();
            text_inventary = new TextBox();
            text_quantidade = new TextBox();
            text_value = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btn_add = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            text_desconto = new TextBox();
            text_total_geral = new TextBox();
            text_imposto = new TextBox();
            text_total_pago = new TextBox();
            button1 = new Button();
            dgvUser = new DataGridView();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label6 = new Label();
            text_subtotal = new TextBox();
            text_name = new ComboBox();
            text_troco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Image = Properties.Resources.close;
            btn_close.Location = new Point(1096, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(27, 27);
            btn_close.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_close.TabIndex = 92;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // lb_top
            // 
            lb_top.AutoSize = true;
            lb_top.BackColor = Color.FromArgb(26, 26, 26);
            lb_top.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_top.ForeColor = Color.White;
            lb_top.Location = new Point(516, 9);
            lb_top.Name = "lb_top";
            lb_top.Size = new Size(77, 21);
            lb_top.TabIndex = 93;
            lb_top.Text = "Compras";
            // 
            // text_search
            // 
            text_search.BackColor = Color.FromArgb(31, 31, 31);
            text_search.BorderStyle = BorderStyle.None;
            text_search.ForeColor = Color.White;
            text_search.Location = new Point(28, 77);
            text_search.Multiline = true;
            text_search.Name = "text_search";
            text_search.PlaceholderText = "Pesquisar...";
            text_search.Size = new Size(399, 23);
            text_search.TabIndex = 94;
            text_search.TextAlign = HorizontalAlignment.Center;
            text_search.TextChanged += text_search_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(26, 26, 26);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 95;
            label1.Text = "Detalhes do produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(26, 26, 26);
            label2.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 165, 246);
            label2.Location = new Point(28, 107);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 96;
            label2.Text = "Nome:";
            // 
            // text_inventary
            // 
            text_inventary.BackColor = Color.FromArgb(31, 31, 31);
            text_inventary.BorderStyle = BorderStyle.None;
            text_inventary.ForeColor = Color.White;
            text_inventary.Location = new Point(28, 178);
            text_inventary.Multiline = true;
            text_inventary.Name = "text_inventary";
            text_inventary.Size = new Size(399, 23);
            text_inventary.TabIndex = 99;
            text_inventary.TextAlign = HorizontalAlignment.Center;
            // 
            // text_quantidade
            // 
            text_quantidade.BackColor = Color.FromArgb(31, 31, 31);
            text_quantidade.BorderStyle = BorderStyle.None;
            text_quantidade.ForeColor = Color.White;
            text_quantidade.Location = new Point(28, 228);
            text_quantidade.Multiline = true;
            text_quantidade.Name = "text_quantidade";
            text_quantidade.PlaceholderText = "0";
            text_quantidade.Size = new Size(92, 23);
            text_quantidade.TabIndex = 101;
            text_quantidade.TextAlign = HorizontalAlignment.Center;
            text_quantidade.KeyPress += text_quantidade_KeyPress;
            // 
            // text_value
            // 
            text_value.BackColor = Color.FromArgb(31, 31, 31);
            text_value.BorderStyle = BorderStyle.None;
            text_value.ForeColor = Color.White;
            text_value.Location = new Point(153, 228);
            text_value.Multiline = true;
            text_value.Name = "text_value";
            text_value.PlaceholderText = "R$";
            text_value.Size = new Size(92, 23);
            text_value.TabIndex = 103;
            text_value.TextAlign = HorizontalAlignment.Center;
            text_value.KeyPress += text_value_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(26, 26, 26);
            label4.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 165, 246);
            label4.Location = new Point(28, 208);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 104;
            label4.Text = "Quantidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(26, 26, 26);
            label5.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 165, 246);
            label5.Location = new Point(153, 208);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 105;
            label5.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(26, 26, 26);
            label3.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 165, 246);
            label3.Location = new Point(28, 158);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 106;
            label3.Text = "Inventário:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(31, 31, 31);
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(28, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 165, 246);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(28, 268);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 27);
            btn_add.TabIndex = 108;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(26, 26, 26);
            label7.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 165, 246);
            label7.Location = new Point(712, 81);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 110;
            label7.Text = "Sub total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(26, 26, 26);
            label8.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 165, 246);
            label8.Location = new Point(1034, 81);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 112;
            label8.Text = "Desconto %";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(26, 26, 26);
            label9.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 165, 246);
            label9.Location = new Point(712, 136);
            label9.Name = "label9";
            label9.Size = new Size(66, 17);
            label9.TabIndex = 114;
            label9.Text = "Imposto %";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(26, 26, 26);
            label10.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 165, 246);
            label10.Location = new Point(1042, 138);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 116;
            label10.Text = "Total Geral";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(26, 26, 26);
            label11.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 165, 246);
            label11.Location = new Point(712, 193);
            label11.Name = "label11";
            label11.Size = new Size(63, 17);
            label11.TabIndex = 118;
            label11.Text = "Total Pago";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(26, 26, 26);
            label12.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 165, 246);
            label12.Location = new Point(1071, 193);
            label12.Name = "label12";
            label12.Size = new Size(37, 17);
            label12.TabIndex = 120;
            label12.Text = "Troco";
            // 
            // text_desconto
            // 
            text_desconto.BackColor = Color.FromArgb(31, 31, 31);
            text_desconto.BorderStyle = BorderStyle.None;
            text_desconto.ForeColor = Color.White;
            text_desconto.Location = new Point(922, 101);
            text_desconto.Multiline = true;
            text_desconto.Name = "text_desconto";
            text_desconto.Size = new Size(189, 23);
            text_desconto.TabIndex = 122;
            text_desconto.Text = "0";
            text_desconto.TextAlign = HorizontalAlignment.Center;
            text_desconto.TextChanged += text_desconto_TextChanged;
            text_desconto.KeyPress += text_desconto_KeyPress;
            // 
            // text_total_geral
            // 
            text_total_geral.BackColor = Color.FromArgb(31, 31, 31);
            text_total_geral.BorderStyle = BorderStyle.None;
            text_total_geral.ForeColor = Color.White;
            text_total_geral.Location = new Point(922, 158);
            text_total_geral.Multiline = true;
            text_total_geral.Name = "text_total_geral";
            text_total_geral.ReadOnly = true;
            text_total_geral.Size = new Size(189, 23);
            text_total_geral.TabIndex = 124;
            text_total_geral.Text = "0";
            text_total_geral.TextAlign = HorizontalAlignment.Center;
            // 
            // text_imposto
            // 
            text_imposto.BackColor = Color.FromArgb(31, 31, 31);
            text_imposto.BorderStyle = BorderStyle.None;
            text_imposto.ForeColor = Color.White;
            text_imposto.Location = new Point(712, 158);
            text_imposto.Multiline = true;
            text_imposto.Name = "text_imposto";
            text_imposto.Size = new Size(204, 23);
            text_imposto.TabIndex = 123;
            text_imposto.Text = "0";
            text_imposto.TextAlign = HorizontalAlignment.Center;
            text_imposto.TextChanged += text_imposto_TextChanged;
            text_imposto.KeyPress += text_imposto_KeyPress;
            // 
            // text_total_pago
            // 
            text_total_pago.BackColor = Color.FromArgb(31, 31, 31);
            text_total_pago.BorderStyle = BorderStyle.None;
            text_total_pago.ForeColor = Color.White;
            text_total_pago.Location = new Point(712, 213);
            text_total_pago.Multiline = true;
            text_total_pago.Name = "text_total_pago";
            text_total_pago.Size = new Size(204, 23);
            text_total_pago.TabIndex = 125;
            text_total_pago.Text = "0";
            text_total_pago.TextAlign = HorizontalAlignment.Center;
            text_total_pago.TextChanged += text_total_pago_TextChanged;
            text_total_pago.KeyPress += text_total_pago_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 165, 246);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1008, 268);
            button1.Name = "button1";
            button1.Size = new Size(100, 27);
            button1.TabIndex = 127;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = Color.FromArgb(31, 31, 31);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(28, 342);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(1083, 227);
            dgvUser.TabIndex = 128;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(26, 26, 26);
            label13.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 165, 246);
            label13.Location = new Point(28, 322);
            label13.Name = "label13";
            label13.Size = new Size(102, 17);
            label13.TabIndex = 129;
            label13.Text = "Lista de Produtos";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(253, 89, 85);
            label14.Location = new Point(126, 228);
            label14.Name = "label14";
            label14.Size = new Size(17, 21);
            label14.TabIndex = 130;
            label14.Text = "•";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(253, 89, 85);
            label15.Location = new Point(433, 127);
            label15.Name = "label15";
            label15.Size = new Size(17, 21);
            label15.TabIndex = 131;
            label15.Text = "•";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(253, 89, 85);
            label16.Location = new Point(251, 230);
            label16.Name = "label16";
            label16.Size = new Size(17, 21);
            label16.TabIndex = 132;
            label16.Text = "•";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(26, 26, 26);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(712, 47);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 134;
            label6.Text = "Calculos:";
            // 
            // text_subtotal
            // 
            text_subtotal.BackColor = Color.FromArgb(31, 31, 31);
            text_subtotal.BorderStyle = BorderStyle.None;
            text_subtotal.Enabled = false;
            text_subtotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            text_subtotal.ForeColor = Color.White;
            text_subtotal.Location = new Point(712, 101);
            text_subtotal.Multiline = true;
            text_subtotal.Name = "text_subtotal";
            text_subtotal.ReadOnly = true;
            text_subtotal.Size = new Size(204, 23);
            text_subtotal.TabIndex = 135;
            text_subtotal.Text = "0";
            text_subtotal.TextAlign = HorizontalAlignment.Center;
            // 
            // text_name
            // 
            text_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            text_name.BackColor = Color.FromArgb(31, 31, 31);
            text_name.FlatStyle = FlatStyle.Flat;
            text_name.ForeColor = Color.White;
            text_name.FormattingEnabled = true;
            text_name.Location = new Point(28, 125);
            text_name.Name = "text_name";
            text_name.Size = new Size(399, 23);
            text_name.TabIndex = 136;
            text_name.SelectedIndexChanged += text_name_SelectedIndexChanged;
            // 
            // text_troco
            // 
            text_troco.BackColor = Color.FromArgb(31, 31, 31);
            text_troco.BorderStyle = BorderStyle.None;
            text_troco.ForeColor = Color.White;
            text_troco.Location = new Point(922, 213);
            text_troco.Multiline = true;
            text_troco.Name = "text_troco";
            text_troco.Size = new Size(189, 23);
            text_troco.TabIndex = 137;
            text_troco.Text = "0";
            text_troco.TextAlign = HorizontalAlignment.Center;
            // 
            // frm_Purchase_AND_Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1135, 586);
            Controls.Add(text_troco);
            Controls.Add(text_name);
            Controls.Add(text_subtotal);
            Controls.Add(label6);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(dgvUser);
            Controls.Add(button1);
            Controls.Add(text_total_pago);
            Controls.Add(text_total_geral);
            Controls.Add(text_imposto);
            Controls.Add(text_desconto);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_add);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(text_value);
            Controls.Add(text_quantidade);
            Controls.Add(text_inventary);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_search);
            Controls.Add(lb_top);
            Controls.Add(btn_close);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Purchase_AND_Sale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Purchase_AND_Sale";
            Load += frm_Purchase_AND_Sale_Load;
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private Label lb_top;
        private TextBox text_search;
        private Label label1;
        private Label label2;
        private TextBox text_inventary;
        private TextBox text_quantidade;
        private TextBox text_value;
        private Label label4;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_add;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox text_desconto;
        private TextBox text_total_geral;
        private TextBox text_imposto;
        private TextBox text_total_pago;
        private Button button1;
        private DataGridView dgvUser;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label6;
        private TextBox text_subtotal;
        private ComboBox text_name;
        private TextBox text_troco;
    }
}