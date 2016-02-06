namespace Escola_Sabatina_Relógio
{
    partial class configuracao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.cbx5min = new System.Windows.Forms.CheckBox();
            this.cbx1min = new System.Windows.Forms.CheckBox();
            this.toolTipString = new System.Windows.Forms.ToolTip(this.components);
            this.cbxPadrao = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horário";
            this.toolTipString.SetToolTip(this.label1, "Horário no qual a Escola Sabatina irá terminar.");
            // 
            // dtpHorario
            // 
            this.dtpHorario.CustomFormat = "HH:mm";
            this.dtpHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorario.Location = new System.Drawing.Point(73, 13);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.ShowUpDown = true;
            this.dtpHorario.Size = new System.Drawing.Size(63, 26);
            this.dtpHorario.TabIndex = 1;
            this.toolTipString.SetToolTip(this.dtpHorario, "Horário no qual a Escola Sabatina irá terminar.");
            // 
            // cbx5min
            // 
            this.cbx5min.AutoSize = true;
            this.cbx5min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx5min.Location = new System.Drawing.Point(9, 45);
            this.cbx5min.Name = "cbx5min";
            this.cbx5min.Size = new System.Drawing.Size(151, 24);
            this.cbx5min.TabIndex = 2;
            this.cbx5min.Text = "Alarme 5 minutos";
            this.toolTipString.SetToolTip(this.cbx5min, "Alarme sonoro que tocará 5 minutos\r\nantes do fim da Escola Sabatina.");
            this.cbx5min.UseVisualStyleBackColor = true;
            // 
            // cbx1min
            // 
            this.cbx1min.AutoSize = true;
            this.cbx1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx1min.Location = new System.Drawing.Point(9, 75);
            this.cbx1min.Name = "cbx1min";
            this.cbx1min.Size = new System.Drawing.Size(143, 24);
            this.cbx1min.TabIndex = 3;
            this.cbx1min.Text = "Alarme 1 minuto";
            this.toolTipString.SetToolTip(this.cbx1min, "Alarme sonoro que tocará 1 minuto\r\nantes do fim da Escola Sabatina.");
            this.cbx1min.UseVisualStyleBackColor = true;
            // 
            // cbxPadrao
            // 
            this.cbxPadrao.AutoSize = true;
            this.cbxPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPadrao.Location = new System.Drawing.Point(13, 124);
            this.cbxPadrao.Name = "cbxPadrao";
            this.cbxPadrao.Size = new System.Drawing.Size(155, 21);
            this.cbxPadrao.TabIndex = 5;
            this.cbxPadrao.Text = "Definir como padrão";
            this.toolTipString.SetToolTip(this.cbxPadrao, "Opção de definir como padrão para\r\ntodas vezes que utilizar o programa.\r\n * Utili" +
                    "ze essa opção ao menos uma\r\n    vez para definir o horário comun \r\n    de términ" +
                    "o da Escola Sabatina.");
            this.cbxPadrao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx1min);
            this.groupBox1.Controls.Add(this.dtpHorario);
            this.groupBox1.Controls.Add(this.cbx5min);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(13, 152);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(95, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // configuracao
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(226, 189);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxPadrao);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "configuracao";
            this.Text = "Configuração";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx1min;
        private System.Windows.Forms.CheckBox cbx5min;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.ToolTip toolTipString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxPadrao;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
    }
}