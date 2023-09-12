namespace MobiStore.UIForm.AlertsUI
{
    partial class alert_products
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
            btn_ok = new Button();
            lb_alert = new Label();
            lb_login = new Label();
            btn_close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.BackColor = Color.FromArgb(0, 165, 246);
            btn_ok.FlatAppearance.BorderSize = 0;
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.White;
            btn_ok.Location = new Point(381, 163);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(100, 27);
            btn_ok.TabIndex = 116;
            btn_ok.Text = "Okay";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // lb_alert
            // 
            lb_alert.AutoSize = true;
            lb_alert.BackColor = Color.FromArgb(31, 31, 31);
            lb_alert.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_alert.ForeColor = Color.White;
            lb_alert.Location = new Point(12, 100);
            lb_alert.Name = "lb_alert";
            lb_alert.Size = new Size(161, 19);
            lb_alert.TabIndex = 115;
            lb_alert.Text = "Mensagem de alerta";
            lb_alert.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_login
            // 
            lb_login.AutoSize = true;
            lb_login.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_login.ForeColor = Color.White;
            lb_login.Location = new Point(12, 10);
            lb_login.Name = "lb_login";
            lb_login.Size = new Size(133, 47);
            lb_login.TabIndex = 114;
            lb_login.Text = "Alerta!";
            // 
            // btn_close
            // 
            btn_close.Image = Properties.Resources.close;
            btn_close.Location = new Point(454, 13);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(27, 27);
            btn_close.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_close.TabIndex = 113;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // alert_products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(493, 201);
            Controls.Add(btn_ok);
            Controls.Add(lb_alert);
            Controls.Add(lb_login);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "alert_products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "alert_products";
            Load += alert_products_Load;
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private Label lb_alert;
        private Label lb_login;
        private PictureBox btn_close;
    }
}