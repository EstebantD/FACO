namespace Presentacion
{
    partial class FormGerencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Pnl_Cliente = new System.Windows.Forms.Panel();
            this.Pnl_Inventario = new System.Windows.Forms.Panel();
            this.Pnl_Finanzas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Pnl_Cliente.SuspendLayout();
            this.Pnl_Inventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.Btn_Salir);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 586);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 76);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(157, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "Inventario";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "Finanzas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.Color.White;
            this.Btn_Salir.Location = new System.Drawing.Point(0, 522);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(173, 64);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Pnl_Cliente
            // 
            this.Pnl_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Cliente.Controls.Add(this.Pnl_Inventario);
            this.Pnl_Cliente.Location = new System.Drawing.Point(170, 75);
            this.Pnl_Cliente.Name = "Pnl_Cliente";
            this.Pnl_Cliente.Size = new System.Drawing.Size(789, 586);
            this.Pnl_Cliente.TabIndex = 2;
            // 
            // Pnl_Inventario
            // 
            this.Pnl_Inventario.Controls.Add(this.Pnl_Finanzas);
            this.Pnl_Inventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Inventario.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Inventario.Name = "Pnl_Inventario";
            this.Pnl_Inventario.Size = new System.Drawing.Size(789, 586);
            this.Pnl_Inventario.TabIndex = 3;
            // 
            // Pnl_Finanzas
            // 
            this.Pnl_Finanzas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Finanzas.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Finanzas.Name = "Pnl_Finanzas";
            this.Pnl_Finanzas.Size = new System.Drawing.Size(789, 586);
            this.Pnl_Finanzas.TabIndex = 3;
            // 
            // FormGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(959, 661);
            this.Controls.Add(this.Pnl_Cliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGerencia";
            this.Text = "FormGerencia";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Pnl_Cliente.ResumeLayout(false);
            this.Pnl_Inventario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Pnl_Cliente;
        private System.Windows.Forms.Panel Pnl_Inventario;
        private System.Windows.Forms.Panel Pnl_Finanzas;
    }
}