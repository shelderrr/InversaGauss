namespace InversaGauss
{
    partial class Matriz2x2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matriz2x2));
            this.lblMenuMatriz = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblIgual1 = new System.Windows.Forms.Label();
            this.lblIgual2 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMenuMatriz
            // 
            this.lblMenuMatriz.AutoSize = true;
            this.lblMenuMatriz.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMatriz.Location = new System.Drawing.Point(343, 48);
            this.lblMenuMatriz.Name = "lblMenuMatriz";
            this.lblMenuMatriz.Size = new System.Drawing.Size(178, 32);
            this.lblMenuMatriz.TabIndex = 0;
            this.lblMenuMatriz.Text = "MATRIZ 2x2";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(800, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 68);
            this.btnSalir.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir del menú");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtA1
            // 
            this.txtA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1.Location = new System.Drawing.Point(108, 172);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(81, 27);
            this.txtA1.TabIndex = 29;
            // 
            // txtA2
            // 
            this.txtA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA2.Location = new System.Drawing.Point(400, 172);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(81, 27);
            this.txtA2.TabIndex = 30;
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(108, 269);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(81, 27);
            this.txtB1.TabIndex = 31;
            // 
            // txtB2
            // 
            this.txtB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.Location = new System.Drawing.Point(400, 269);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(81, 27);
            this.txtB2.TabIndex = 32;
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblA1.Location = new System.Drawing.Point(234, 183);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(23, 16);
            this.lblA1.TabIndex = 33;
            this.lblA1.Text = "A1";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblA2.Location = new System.Drawing.Point(531, 183);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(23, 16);
            this.lblA2.TabIndex = 34;
            this.lblA2.Text = "A2";
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblB1.Location = new System.Drawing.Point(234, 280);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(23, 16);
            this.lblB1.TabIndex = 35;
            this.lblB1.Text = "B1";
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblB2.Location = new System.Drawing.Point(531, 280);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(23, 16);
            this.lblB2.TabIndex = 36;
            this.lblB2.Text = "B2";
            // 
            // lblIgual1
            // 
            this.lblIgual1.AutoSize = true;
            this.lblIgual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual1.Location = new System.Drawing.Point(613, 172);
            this.lblIgual1.Name = "lblIgual1";
            this.lblIgual1.Size = new System.Drawing.Size(31, 32);
            this.lblIgual1.TabIndex = 37;
            this.lblIgual1.Text = "=";
            // 
            // lblIgual2
            // 
            this.lblIgual2.AutoSize = true;
            this.lblIgual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual2.Location = new System.Drawing.Point(613, 269);
            this.lblIgual2.Name = "lblIgual2";
            this.lblIgual2.Size = new System.Drawing.Size(31, 32);
            this.lblIgual2.TabIndex = 38;
            this.lblIgual2.Text = "=";
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(677, 177);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(81, 27);
            this.txtX1.TabIndex = 39;
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(677, 269);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(81, 27);
            this.txtX2.TabIndex = 40;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(776, 185);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(22, 16);
            this.lblX1.TabIndex = 41;
            this.lblX1.Text = "X1";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(785, 280);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(22, 16);
            this.lblX2.TabIndex = 42;
            this.lblX2.Text = "X2";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(370, 404);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 44);
            this.btnEnviar.TabIndex = 43;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Salir";
            // 
            // Matriz2x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(903, 534);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblIgual2);
            this.Controls.Add(this.lblIgual1);
            this.Controls.Add(this.lblB2);
            this.Controls.Add(this.lblB1);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMenuMatriz);
            this.Name = "Matriz2x2";
            this.Text = "Matriz2x2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuMatriz;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.Label lblIgual1;
        private System.Windows.Forms.Label lblIgual2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}