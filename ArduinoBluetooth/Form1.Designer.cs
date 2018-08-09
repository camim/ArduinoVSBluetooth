namespace ArduinoBluetooth
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.enviar = new System.Windows.Forms.Button();
            this.tbEnviaT = new System.Windows.Forms.TextBox();
            this.lbRecibeT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaPuertosCOM = new System.Windows.Forms.ComboBox();
            this.Conectar = new System.Windows.Forms.Button();
            this.Desconectado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(132, 170);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(101, 20);
            this.enviar.TabIndex = 0;
            this.enviar.Text = "Enviar a Arduino";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // tbEnviaT
            // 
            this.tbEnviaT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbEnviaT.Location = new System.Drawing.Point(24, 171);
            this.tbEnviaT.Name = "tbEnviaT";
            this.tbEnviaT.Size = new System.Drawing.Size(102, 20);
            this.tbEnviaT.TabIndex = 1;
            // 
            // lbRecibeT
            // 
            this.lbRecibeT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbRecibeT.Location = new System.Drawing.Point(24, 194);
            this.lbRecibeT.Name = "lbRecibeT";
            this.lbRecibeT.Size = new System.Drawing.Size(102, 40);
            this.lbRecibeT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar el puerto saliente para el bluetooth";
            // 
            // ListaPuertosCOM
            // 
            this.ListaPuertosCOM.FormattingEnabled = true;
            this.ListaPuertosCOM.Location = new System.Drawing.Point(24, 110);
            this.ListaPuertosCOM.Name = "ListaPuertosCOM";
            this.ListaPuertosCOM.Size = new System.Drawing.Size(121, 21);
            this.ListaPuertosCOM.TabIndex = 4;
            this.ListaPuertosCOM.Click += new System.EventHandler(this.ListaPuertosCOM_Click);
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(159, 109);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(75, 23);
            this.Conectar.TabIndex = 5;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Desconectado
            // 
            this.Desconectado.AutoSize = true;
            this.Desconectado.ForeColor = System.Drawing.Color.Blue;
            this.Desconectado.Location = new System.Drawing.Point(158, 135);
            this.Desconectado.Name = "Desconectado";
            this.Desconectado.Size = new System.Drawing.Size(77, 13);
            this.Desconectado.TabIndex = 6;
            this.Desconectado.Text = "Desconectado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Agregar dispositivo";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(160, 34);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 264);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Desconectado);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.ListaPuertosCOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRecibeT);
            this.Controls.Add(this.tbEnviaT);
            this.Controls.Add(this.enviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.TextBox tbEnviaT;
        private System.Windows.Forms.Label lbRecibeT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaPuertosCOM;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Label Desconectado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agregar;
    }
}

