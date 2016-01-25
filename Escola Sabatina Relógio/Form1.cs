using System.Windows.Forms;
using System.Windows;


namespace Escola_Sabatina_Relógio
{
    public partial class Form1 : Form
    {
        private bool _5min = true,
            _1min = true,
            alarme = false,
            menos6min = false,
            isFullScreen = false;
        private System.DateTime alarmeTime;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        string _1minPath, _5minPath;
        public static AboutBox1 about = null;
        public Form1()
        {
            InitializeComponent();
            System.DateTime d = System.DateTime.Today;
            d=d.AddHours(10);
            d=d.AddMinutes(10);
            dtpHora.Value = d;
            alterarFontes();
            lblRelogio.Text = System.DateTime.Now.ToString("HH:mm");
            timer1.Interval = 1000;
            timer1.Start();
            //Inicializa a localização dos audios
            _1minPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\resources\\mp3_1min.mp3";
            _5minPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\resources\\mp3_5min.mp3";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            menos6min = false;
            if (alarme)
            {
                btnAlarme.Text = "Ativar Alarme";
                dtpHora.Enabled = true;
                cbx1min.Enabled = true;
                cbx5min.Enabled = true;
                alarme = false;
                timer1.Interval = 1000;
                lblTempoRestante.Text = "---min";
            }
            else
            {
                btnAlarme.Text = "Desativar Alarme";
                dtpHora.Enabled = false;
                cbx1min.Enabled = false;
                cbx5min.Enabled = false;
                alarme = true;
                _5min = true;
                _1min = true;

            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lblRelogio.Text = System.DateTime.Now.ToString("HH:mm");
            if (alarme)
            {
                System.TimeSpan diff = alarmeTime.Subtract(System.DateTime.Now);
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

        private void cbx5min_CheckedChanged(object sender, System.EventArgs e)
        {
            _5min = !_5min;
        }

        private void cbx1min_CheckedChanged(object sender, System.EventArgs e)
        {
            _1min = !_1min;
        }

        private void dtpHora_ValueChanged(object sender, System.EventArgs e)
        {
            alarmeTime = dtpHora.Value;
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
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.Size = this.DefaultSize;
                }
                else
                {
                    isFullScreen = true;
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
                lblRelogio.Font = new System.Drawing.Font("Arial", lblRelogio.Font.Size - 10);
            }
            while (lblRelogio.Width < lblRelogio.Parent.Width)
            {
                lblRelogio.Font = new System.Drawing.Font("Arial", lblRelogio.Font.Size + 10);
            }
            while (lblTempoRestante.Height > lblTempoRestante.Parent.Height)
            {
                lblTempoRestante.Font = new System.Drawing.Font("Arial", lblTempoRestante.Font.Size - 10);
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

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            if (about == null)
            {
                about = new AboutBox1();
                about.Visible = true;
            }
            else
            {
                about.Activate();
            }
        }

        private void label1_MouseHover(object sender, System.EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.lblHelp, "Configure o horário do Término da Escola sabatina\n Selecione os alarmes de 1 minuto e/ou 5 minutos\n\nAperte ALT + Enter para colocar em tela cheia\nPressione Esc para sair");
            ToolTip1.AutoPopDelay = 10000;
        }
    }
}