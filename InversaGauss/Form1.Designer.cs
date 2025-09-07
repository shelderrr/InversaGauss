namespace InversaGauss
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.lblMenu3 = new System.Windows.Forms.Label();
            this.lblMenu4 = new System.Windows.Forms.Label();
            this.img3x3 = new System.Windows.Forms.PictureBox();
            this.img2x2 = new System.Windows.Forms.PictureBox();
            this.rbtnMatriz3x3 = new System.Windows.Forms.RadioButton();
            this.rbtn2x2 = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img3x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2x2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(123, 34);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(762, 39);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Bienvenido al programa de matrices inversas";
            // 
            // lblMenu2
            // 
            this.lblMenu2.AutoSize = true;
            this.lblMenu2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu2.Location = new System.Drawing.Point(209, 94);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Size = new System.Drawing.Size(553, 39);
            this.lblMenu2.TabIndex = 1;
            this.lblMenu2.Text = "siga las siguientes instrucciones";
            // 
            // lblMenu3
            // 
            this.lblMenu3.AutoSize = true;
            this.lblMenu3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu3.Location = new System.Drawing.Point(266, 172);
            this.lblMenu3.Name = "lblMenu3";
            this.lblMenu3.Size = new System.Drawing.Size(407, 32);
            this.lblMenu3.TabIndex = 2;
            this.lblMenu3.Text = "¿Qué matriz desea resolver?";
            // 
            // lblMenu4
            // 
            this.lblMenu4.AutoSize = true;
            this.lblMenu4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu4.Location = new System.Drawing.Point(69, 230);
            this.lblMenu4.Name = "lblMenu4";
            this.lblMenu4.Size = new System.Drawing.Size(822, 32);
            this.lblMenu4.TabIndex = 3;
            this.lblMenu4.Text = "Elija su opción preferida y posteriormente, presione Enviar";
            // 
            // img3x3
            // 
            this.img3x3.Image = ((System.Drawing.Image)(resources.GetObject("img3x3.Image")));
            this.img3x3.Location = new System.Drawing.Point(94, 314);
            this.img3x3.Name = "img3x3";
            this.img3x3.Size = new System.Drawing.Size(228, 116);
            this.img3x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3x3.TabIndex = 4;
            this.img3x3.TabStop = false;
            this.img3x3.Click += new System.EventHandler(this.img3x3_Click);
            // 
            // img2x2
            // 
            this.img2x2.Image = ((System.Drawing.Image)(resources.GetObject("img2x2.Image")));
            this.img2x2.Location = new System.Drawing.Point(578, 265);
            this.img2x2.Name = "img2x2";
            this.img2x2.Size = new System.Drawing.Size(346, 195);
            this.img2x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2x2.TabIndex = 5;
            this.img2x2.TabStop = false;
            this.img2x2.Click += new System.EventHandler(this.img2x2_Click);
            // 
            // rbtnMatriz3x3
            // 
            this.rbtnMatriz3x3.AutoSize = true;
            this.rbtnMatriz3x3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMatriz3x3.Location = new System.Drawing.Point(130, 423);
            this.rbtnMatriz3x3.Name = "rbtnMatriz3x3";
            this.rbtnMatriz3x3.Size = new System.Drawing.Size(145, 31);
            this.rbtnMatriz3x3.TabIndex = 10;
            this.rbtnMatriz3x3.TabStop = true;
            this.rbtnMatriz3x3.Text = "Matriz 3x3";
            this.rbtnMatriz3x3.UseVisualStyleBackColor = true;
            // 
            // rbtn2x2
            // 
            this.rbtn2x2.AutoSize = true;
            this.rbtn2x2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2x2.Location = new System.Drawing.Point(690, 423);
            this.rbtn2x2.Name = "rbtn2x2";
            this.rbtn2x2.Size = new System.Drawing.Size(145, 31);
            this.rbtn2x2.TabIndex = 11;
            this.rbtn2x2.TabStop = true;
            this.rbtn2x2.Text = "Matriz 2x2";
            this.rbtn2x2.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Brown;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(418, 484);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(124, 44);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 584);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rbtn2x2);
            this.Controls.Add(this.rbtnMatriz3x3);
            this.Controls.Add(this.img2x2);
            this.Controls.Add(this.img3x3);
            this.Controls.Add(this.lblMenu4);
            this.Controls.Add(this.lblMenu3);
            this.Controls.Add(this.lblMenu2);
            this.Controls.Add(this.lblMenu);
            this.Name = "Principal";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.img3x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2x2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.Label lblMenu3;
        private System.Windows.Forms.Label lblMenu4;
        private System.Windows.Forms.PictureBox img3x3;
        private System.Windows.Forms.PictureBox img2x2;
        private System.Windows.Forms.RadioButton rbtnMatriz3x3;
        private System.Windows.Forms.RadioButton rbtn2x2;
        private System.Windows.Forms.Button btnEnviar;
    }
}

