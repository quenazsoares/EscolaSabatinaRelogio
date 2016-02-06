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
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTempoRestanteTexto = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relógioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutosRestantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apenasLogoESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOpaco = new System.Windows.Forms.Panel();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.áudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tocarÁudioDe1MinutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tocarÁudioDe5MinutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararÁudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelOpaco.SuspendLayout();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(0, 0);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(44, 17);
            this.lblRelogio.TabIndex = 0;
            this.lblRelogio.Text = "09:50";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 537);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTempoRestanteTexto);
            this.panel2.Controls.Add(this.lblTempoRestante);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.configurarToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.áudiosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configurarToolStripMenuItem.Text = "Configurar";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relógioToolStripMenuItem,
            this.minutosRestantesToolStripMenuItem,
            this.apenasLogoESToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // relógioToolStripMenuItem
            // 
            this.relógioToolStripMenuItem.Checked = true;
            this.relógioToolStripMenuItem.CheckOnClick = true;
            this.relógioToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.relógioToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.relógioToolStripMenuItem.Name = "relógioToolStripMenuItem";
            this.relógioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.relógioToolStripMenuItem.Text = "Relógio";
            this.relógioToolStripMenuItem.Click += new System.EventHandler(this.relógioToolStripMenuItem_Click);
            // 
            // minutosRestantesToolStripMenuItem
            // 
            this.minutosRestantesToolStripMenuItem.Checked = true;
            this.minutosRestantesToolStripMenuItem.CheckOnClick = true;
            this.minutosRestantesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minutosRestantesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minutosRestantesToolStripMenuItem.Name = "minutosRestantesToolStripMenuItem";
            this.minutosRestantesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.minutosRestantesToolStripMenuItem.Text = "Minutos Restantes";
            this.minutosRestantesToolStripMenuItem.Click += new System.EventHandler(this.minutosRestantesToolStripMenuItem_Click);
            // 
            // apenasLogoESToolStripMenuItem
            // 
            this.apenasLogoESToolStripMenuItem.CheckOnClick = true;
            this.apenasLogoESToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.apenasLogoESToolStripMenuItem.Name = "apenasLogoESToolStripMenuItem";
            this.apenasLogoESToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.apenasLogoESToolStripMenuItem.Text = "Apenas Logo ES";
            this.apenasLogoESToolStripMenuItem.Click += new System.EventHandler(this.apenasLogoESToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // panelOpaco
            // 
            this.panelOpaco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelOpaco.Controls.Add(this.panel1);
            this.panelOpaco.Controls.Add(this.menuStrip);
            this.panelOpaco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpaco.Location = new System.Drawing.Point(0, 0);
            this.panelOpaco.Name = "panelOpaco";
            this.panelOpaco.Size = new System.Drawing.Size(784, 561);
            this.panelOpaco.TabIndex = 5;
            // 
            // panelFundo
            // 
            this.panelFundo.BackgroundImage = global::Escola_Sabatina_Relógio.Properties.Resources.logo_es_3;
            this.panelFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundo.Controls.Add(this.panelOpaco);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(784, 561);
            this.panelFundo.TabIndex = 6;
            // 
            // áudiosToolStripMenuItem
            // 
            this.áudiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tocarÁudioDe1MinutoToolStripMenuItem,
            this.tocarÁudioDe5MinutosToolStripMenuItem,
            this.pararÁudioToolStripMenuItem});
            this.áudiosToolStripMenuItem.Name = "áudiosToolStripMenuItem";
            this.áudiosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.áudiosToolStripMenuItem.Text = "Áudios";
            // 
            // tocarÁudioDe1MinutoToolStripMenuItem
            // 
            this.tocarÁudioDe1MinutoToolStripMenuItem.Name = "tocarÁudioDe1MinutoToolStripMenuItem";
            this.tocarÁudioDe1MinutoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.tocarÁudioDe1MinutoToolStripMenuItem.Text = "Tocar áudio de 1 minuto";
            this.tocarÁudioDe1MinutoToolStripMenuItem.Click += new System.EventHandler(this.tocarÁudioDe1MinutoToolStripMenuItem_Click);
            // 
            // tocarÁudioDe5MinutosToolStripMenuItem
            // 
            this.tocarÁudioDe5MinutosToolStripMenuItem.Name = "tocarÁudioDe5MinutosToolStripMenuItem";
            this.tocarÁudioDe5MinutosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.tocarÁudioDe5MinutosToolStripMenuItem.Text = "Tocar áudio de 5 minutos";
            this.tocarÁudioDe5MinutosToolStripMenuItem.Click += new System.EventHandler(this.tocarÁudioDe5MinutosToolStripMenuItem_Click);
            // 
            // pararÁudioToolStripMenuItem
            // 
            this.pararÁudioToolStripMenuItem.Name = "pararÁudioToolStripMenuItem";
            this.pararÁudioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pararÁudioToolStripMenuItem.Text = "Parar áudio";
            this.pararÁudioToolStripMenuItem.Click += new System.EventHandler(this.pararÁudioToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelFundo);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Escola Sabatina Relógio";
            this.ResizeEnd += new System.EventHandler(this.Form1_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelOpaco.ResumeLayout(false);
            this.panelOpaco.PerformLayout();
            this.panelFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTempoRestanteTexto;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Panel panelOpaco;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relógioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutosRestantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apenasLogoESToolStripMenuItem;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.ToolStripMenuItem áudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tocarÁudioDe1MinutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tocarÁudioDe5MinutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararÁudioToolStripMenuItem;




    }
}

