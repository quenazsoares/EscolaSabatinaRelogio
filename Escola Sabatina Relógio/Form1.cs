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
                if (isFullScreen)
                {
                    isFullScreen = false;
                    menuStrip.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.Size = this.DefaultSize;
                }
                else
                {
                    isFullScreen = true;
                    menuStrip.Visible = false;
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    this.Bounds = Screen.PrimaryScreen.Bounds;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void alterarFontes()
        {
            while (lblRelogio.Width > lblRelogio.Parent.Width)
            {
                if (lblRelogio.Font.Size > 20)
                {
                    lblRelogio.Font = new System.Drawing.Font("Arial", lblRelogio.Font.Size - 10);
                }
                else break;
            }
            while (lblRelogio.Width < lblRelogio.Parent.Width)
            {
                lblRelogio.Font = new System.Drawing.Font("Arial", lblRelogio.Font.Size + 10);
            }
            while (lblTempoRestante.Height > lblTempoRestante.Parent.Height)
            {
                if (lblTempoRestante.Font.Size > 20)
                {
                    lblTempoRestante.Font = new System.Drawing.Font("Arial", lblTempoRestante.Font.Size - 10);
                }
                else break;
            }
            while (lblTempoRestante.Height < lblTempoRestante.Parent.Height)
            {
                lblTempoRestante.Font = new System.Drawing.Font("Arial", lblTempoRestante.Font.Size + 10);
            }
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
            }
            else
            {
                iniciarToolStripMenuItem.Text = "Parar";
                configurarToolStripMenuItem.Enabled = false;
                configurarToolStripMenuItem.ToolTipText = "É necessário parar o alarme para configurar";
                alarme = true;
                _5min = true;
                _1min = true;

            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string ajuda = "Lembre-se de configurar ou definir uma configuração padrão antes de iniciar o alarme/contador regressivo. "+
                "Para isto clique no menu CONFIGURAR.\n\nPara ativar o alarme/contador regressivo clique no menu INICIAR\n" + 
                "Enquanto estiver ativo o clique no menu PARAR para desativar\n\n" + 
                "Para entrar e sair do modo de tela cheia aperte ALT+Enter\n\n" +
                "Para sair do programa clique no botão de fechar ou aperte ESC";
            System.Windows.MessageBox.Show(ajuda, "AJUDA");
        }

        private void sobreToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new AboutBox1().ShowDialog(this);
        }
    }
}