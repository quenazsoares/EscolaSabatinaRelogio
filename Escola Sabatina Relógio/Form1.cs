using System.Windows.Forms;
using System.Windows;


namespace Escola_Sabatina_Relógio
{
    public partial class Form1 : Form
    {
        public static bool _5min = true,
            _1min = true;
        public static System.DateTime horario;

        private bool alarme = false,
            menos6min = false,
            isFullScreen = false;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        string _1minPath, _5minPath;
        public static AboutBox1 about = null;

        //Usado para suspender a atualização da tela
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(System.IntPtr hWnd, System.Int32 wMsg, bool wParam, System.Int32 lParam);
        private const int WM_SETREDRAW = 11;

        public Form1()
        {
            InitializeComponent();
            _1min = Properties.Settings.Default._1min;
            _5min = Properties.Settings.Default._5min;
            menuStrip.BackColor = System.Drawing.ColorTranslator.FromHtml("#88ffffff");
            horario = System.DateTime.Today;
            horario = horario.AddHours(Properties.Settings.Default.Hora); //Utiliza a configuração padrão de hora
            horario = horario.AddMinutes(Properties.Settings.Default.Minuto); //Utiliza a configuração padrão de minuto
            alterarFontes();
            lblRelogio.Text = System.DateTime.Now.ToString("HH:mm");
            timer1.Interval = 1000;
            timer1.Start();
            //Inicializa a localização dos audios
            _1minPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\resources\\mp3_1min.mp3";
            _5minPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\resources\\mp3_5min.mp3";
            if (!System.IO.File.Exists(_1minPath) || !System.IO.File.Exists(_5minPath))
                System.Windows.MessageBox.Show("Arquivos de áudio foram deletados ou corrompidos\nReinstale o programa para corrigir.", "Falha ao abrir áudios", System.Windows.MessageBoxButton.OK, MessageBoxImage.Error);

            configurarExibicao();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lblRelogio.Text = System.DateTime.Now.ToString("HH:mm");
            if (alarme)
            {
                System.TimeSpan diff = horario.Subtract(System.DateTime.Now);
                if (_5min && diff.Minutes <= 5 && diff.Minutes > 1)
                {
                    _5min = false;
                    wplayer.URL = _5minPath;
                    wplayer.controls.play();
                }
                if (_1min && diff.Minutes == 0 && diff.Seconds > 0 )
                {
                    _1min = false;
                    wplayer.URL = _1minPath;
                    wplayer.controls.play();
                }
                if (diff.Minutes < 6 && diff.Minutes >= 0 && !menos6min)
                {
                    menos6min = true;
                    timer1.Interval = 100;
                }
                if (!_1min)
                {
                    if (diff.Seconds >= 0)
                    {
                        lblTempoRestante.Text = diff.Seconds + "seg";
                        lblTempoRestante.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lblTempoRestante.Text = "FIM!";
                        lblTempoRestante.ForeColor = System.Drawing.Color.Red;
                        timer1.Interval = 10000;
                    }
                }
                else
                {
                    lblTempoRestante.Text = (diff.Hours*60+diff.Minutes) + "min";
                    lblTempoRestante.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            alterarFontes();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Enter)
            {
                SendMessage(panelFundo.Handle, WM_SETREDRAW, false, 0);
                if (isFullScreen)
                {
                    isFullScreen = false;
                    menuStrip.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.Size = this.DefaultSize;
                    alterarFontes();
                }
                else
                {
                    
                    isFullScreen = true;
                    menuStrip.Visible = false;
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    this.Bounds = Screen.PrimaryScreen.Bounds;
                    alterarFontes();
                    
                }
                SendMessage(panelFundo.Handle, WM_SETREDRAW, true, 0);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void alterarFontes()
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;
            if (this.Size.Width < this.MinimumSize.Width)
                return;
            System.Drawing.Graphics auxGraph = CreateGraphics();
            int tamanhoFonte = 100;
            float largura = auxGraph.MeasureString(lblRelogio.Text, new System.Drawing.Font("Arial", tamanhoFonte)).Width;
            while (largura > lblRelogio.Parent.Width)
            {
                tamanhoFonte -= 5;
                largura = auxGraph.MeasureString(lblRelogio.Text, new System.Drawing.Font("Arial", tamanhoFonte)).Width;
            }
            while (largura < lblRelogio.Parent.Width)
            {
                tamanhoFonte += 5;
                largura = auxGraph.MeasureString(lblRelogio.Text, new System.Drawing.Font("Arial", tamanhoFonte)).Width;
            }
            lblRelogio.Font = new System.Drawing.Font("Arial", tamanhoFonte);

            tamanhoFonte = 100;
            float altura = auxGraph.MeasureString(lblTempoRestante.Text, new System.Drawing.Font("Arial", tamanhoFonte)).Height;
            while (altura > lblTempoRestante.Parent.Height)
            {
                tamanhoFonte -= 5;
                altura = auxGraph.MeasureString(lblTempoRestante.Text, new System.Drawing.Font("Arial", tamanhoFonte)).Height;
            }
            while (altura < lblTempoRestante.Parent.Height)
            {
                tamanhoFonte += 5;
                altura = auxGraph.MeasureString(lblTempoRestante.Text, new System.Drawing.Font("Arial", tamanhoFonte)).Height;
            }
            lblTempoRestante.Font = new System.Drawing.Font("Arial", tamanhoFonte);

            lblTempoRestanteTexto.Font = new System.Drawing.Font("Arial", lblTempoRestante.Font.Size/3);
            lblTempoRestanteTexto.Top = (lblTempoRestanteTexto.Parent.Height - lblTempoRestanteTexto.Height)/2;
            lblTempoRestanteTexto.Left = (lblTempoRestanteTexto.Parent.Width - lblTempoRestanteTexto.Width - lblTempoRestante.Width)/2;
            lblTempoRestante.Left = lblTempoRestanteTexto.Left + lblTempoRestanteTexto.Width;
            lblTempoRestante.Top = (lblTempoRestante.Parent.Height - lblTempoRestante.Height) / 2;
            lblRelogio.Top = (lblRelogio.Parent.Height - lblRelogio.Height - panel2.Height) / 2;
        }

        private void configurarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new configuracao().ShowDialog(this);
        }

        private void iniciarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            menos6min = false;
            if (alarme) // Se alarme for verdadeiro, significa que o alarme estava funcionando e agora deve-se parar
            {
                iniciarToolStripMenuItem.Text = "Iniciar";
                configurarToolStripMenuItem.Enabled = true;
                configurarToolStripMenuItem.ToolTipText = "";
                alarme = false;
                timer1.Interval = 1000;
                lblTempoRestante.Text = "---min";
                lblTempoRestante.ForeColor = lblTempoRestanteTexto.ForeColor;
            }
            else
            {
                System.TimeSpan diff = horario.Subtract(System.DateTime.Now);
                string mensagem = horario.Hour + ":" + horario.Minute;
                if (_5min) mensagem = mensagem + "\nTocar áudio faltando 5 minutos";
                if (_1min) mensagem = mensagem + "\nTocar áudio faltando 1 minuto";
                exibirNotificacao(mensagem,"Configuração selecionada", 5);
                if (diff.Hours >= 0 && diff.Minutes >= 0 && diff.Seconds >= 0)
                {
                    iniciarToolStripMenuItem.Text = "Parar";
                    configurarToolStripMenuItem.Enabled = false;
                    configurarToolStripMenuItem.ToolTipText = "É necessário parar o alarme para configurar";
                    alarme = true;
                    _5min = true;
                    _1min = true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("O horário selecionado encontra-se no passado, vá no menu CONFIGURAÇÃO e selecione um horário futuro. \n"+
                        "Caso o horário esteja selecionado corretamente, verifique o relógio do sistema.", "ERRO - Horário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string ajuda = "Lembre-se de configurar ou definir uma configuração padrão antes de iniciar o alarme/contador regressivo. "+
                "Para isto clique no menu CONFIGURAR.\n\nPara ativar o alarme/contador regressivo clique no menu INICIAR\n" + 
                "Enquanto estiver ativo o clique no menu PARAR para desativar\n\n" + 
                "Para entrar e sair do modo de tela cheia aperte ALT+Enter\n\n" +
                "Para sair do programa clique no botão de fechar ou aperte ESC\n\n" +
                "O menu EXIBIR serve para selecionar se o relógio e o mostrador de minutos restantes serão visíveis, " +
                "recomenda-se que o relógio e o mostrador de minutos restantes sejam exibidos em telas que apenas os professores irão ver.";
            System.Windows.MessageBox.Show(ajuda, "AJUDA");
        }

        private void sobreToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new AboutBox1().ShowDialog(this);
        }

        private void configurarExibicao()
        {
            //Configura a exibição dos componentes
            relógioToolStripMenuItem.Checked = Properties.Settings.Default.exibir_relogio;
            minutosRestantesToolStripMenuItem.Checked = Properties.Settings.Default.exibir_minutos_restantes;
            apenasLogoESToolStripMenuItem.Checked = !(Properties.Settings.Default.exibir_relogio || Properties.Settings.Default.exibir_minutos_restantes);
            lblRelogio.Visible = Properties.Settings.Default.exibir_relogio;
            lblTempoRestante.Visible = Properties.Settings.Default.exibir_minutos_restantes;
            lblTempoRestanteTexto.Visible = Properties.Settings.Default.exibir_minutos_restantes;
            panelOpaco.BackColor = System.Drawing.Color.FromArgb(apenasLogoESToolStripMenuItem.Checked ? 0 : 216, 255, 255, 255);
        }

        private void relógioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.exibir_relogio = relógioToolStripMenuItem.Checked;
            configurarExibicao();
        }

        private void minutosRestantesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.exibir_minutos_restantes = minutosRestantesToolStripMenuItem.Checked;
            configurarExibicao();
        }

        private void apenasLogoESToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.exibir_minutos_restantes = !apenasLogoESToolStripMenuItem.Checked;
            Properties.Settings.Default.exibir_relogio = !apenasLogoESToolStripMenuItem.Checked;
            configurarExibicao();
        }

        private void exibirNotificacao(string mensagem, string titulo, int duracao)
        {
            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = this.Icon,
                BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                BalloonTipTitle = titulo,
                BalloonTipText = mensagem,
            };
            // Display for 5 seconds.
            notification.ShowBalloonTip(duracao);
        }

        protected override void WndProc(ref Message m)//Para controlar a alteração das fontes quando maximizamos a janela
        {
            FormWindowState previousWindowState = this.WindowState;
            base.WndProc(ref m);
            FormWindowState currentWindowState = this.WindowState;
            if (previousWindowState != currentWindowState)
            {
                alterarFontes();
            }
        }

        private void tocarÁudioDe1MinutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            wplayer.URL = _1minPath;
            wplayer.controls.play();
        }

        private void tocarÁudioDe5MinutosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            wplayer.URL = _5minPath;
            wplayer.controls.play();
        }

        private void pararÁudioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            wplayer.controls.stop();
        }

    }
}