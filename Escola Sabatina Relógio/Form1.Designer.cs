namespace Escola_Sabatina_Relógio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRelogio = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx1min = new System.Windows.Forms.CheckBox();
            this.cbx5min = new System.Windows.Forms.CheckBox();
            this.btnAlarme = new System.Windows.Forms.Button();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTempoRestanteTexto = new System.Windows.Forms.Label();
            this.panelConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(0, 0);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(44, 17);
            this.lblRelogio.TabIndex = 0;
            this.lblRelogio.Text = "09:50";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpHora
            // 
            this.dtpHora.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.CalendarTrailingForeColor = System.Drawing.Color.LightCoral;
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(19, 10);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(10);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(66, 26);
            this.dtpHora.TabIndex = 2;
            this.dtpHora.Value = new System.DateTime(2016, 1, 23, 10, 10, 0, 0);
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            this.dtpHora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // panelConfig
            // 
            this.panelConfig.BackColor = System.Drawing.Color.Transparent;
            this.panelConfig.Controls.Add(this.button1);
            this.panelConfig.Controls.Add(this.cbx1min);
            this.panelConfig.Controls.Add(this.cbx5min);
            this.panelConfig.Controls.Add(this.btnAlarme);
            this.panelConfig.Controls.Add(this.dtpHora);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfig.Location = new System.Drawing.Point(0, 0);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(784, 51);
            this.panelConfig.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sobre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbx1min
            // 
            this.cbx1min.AutoSize = true;
            this.cbx1min.Checked = true;
            this.cbx1min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx1min.Location = new System.Drawing.Point(273, 13);
            this.cbx1min.Margin = new System.Windows.Forms.Padding(10);
            this.cbx1min.Name = "cbx1min";
            this.cbx1min.Size = new System.Drawing.Size(149, 21);
            this.cbx1min.TabIndex = 4;
            this.cbx1min.Text = "Alarme de 1 minuto";
            this.cbx1min.UseVisualStyleBackColor = true;
            this.cbx1min.CheckedChanged += new System.EventHandler(this.cbx1min_CheckedChanged);
            this.cbx1min.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // cbx5min
            // 
            this.cbx5min.AutoSize = true;
            this.cbx5min.Checked = true;
            this.cbx5min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx5min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx5min.Location = new System.Drawing.Point(101, 13);
            this.cbx5min.Margin = new System.Windows.Forms.Padding(10);
            this.cbx5min.Name = "cbx5min";
            this.cbx5min.Size = new System.Drawing.Size(156, 21);
            this.cbx5min.TabIndex = 3;
            this.cbx5min.Text = "Alarme de 5 minutos";
            this.cbx5min.UseVisualStyleBackColor = true;
            this.cbx5min.CheckedChanged += new System.EventHandler(this.cbx5min_CheckedChanged);
            this.cbx5min.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnAlarme
            // 
            this.btnAlarme.AutoSize = true;
            this.btnAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarme.Location = new System.Drawing.Point(438, 10);
            this.btnAlarme.Margin = new System.Windows.Forms.Padding(10);
            this.btnAlarme.Name = "btnAlarme";
            this.btnAlarme.Size = new System.Drawing.Size(152, 27);
            this.btnAlarme.TabIndex = 1;
            this.btnAlarme.Text = "Ativar Alarme";
            this.btnAlarme.UseVisualStyleBackColor = true;
            this.btnAlarme.Click += new System.EventHandler(this.button1_Click);
            this.btnAlarme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRestante.Location = new System.Drawing.Point(524, 43);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(45, 17);
            this.lblTempoRestante.TabIndex = 0;
            this.lblTempoRestante.Text = "---min";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblRelogio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 510);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTempoRestanteTexto);
            this.panel2.Controls.Add(this.lblTempoRestante);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 156);
            this.panel2.TabIndex = 1;
            // 
            // lblTempoRestanteTexto
            // 
            this.lblTempoRestanteTexto.AutoSize = true;
            this.lblTempoRestanteTexto.Location = new System.Drawing.Point(33, 43);
            this.lblTempoRestanteTexto.Name = "lblTempoRestanteTexto";
            this.lblTempoRestanteTexto.Size = new System.Drawing.Size(50, 26);
            this.lblTempoRestanteTexto.TabIndex = 1;
            this.lblTempoRestanteTexto.Text = "Tempo\r\nRestante";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelConfig);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Escola Sabatina Relógio";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Button btnAlarme;
        private System.Windows.Forms.CheckBox cbx1min;
        private System.Windows.Forms.CheckBox cbx5min;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTempoRestanteTexto;




    }
}

