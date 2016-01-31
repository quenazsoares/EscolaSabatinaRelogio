using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Escola_Sabatina_Relógio
{
    public partial class configuracao : Form
    {
        public configuracao()
        {
            InitializeComponent();
            cbx1min.Checked = Form1._1min;
            cbx5min.Checked = Form1._5min;
            dtpHorario.Value = Form1.horario;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form1._1min = cbx1min.Checked;
            Form1._5min = cbx5min.Checked;
            Form1.horario = dtpHorario.Value;
            if (cbxPadrao.Checked)
            {
                Properties.Settings.Default._1min = cbx1min.Checked;
                Properties.Settings.Default._5min = cbx5min.Checked;
                Properties.Settings.Default.Minuto = dtpHorario.Value.Minute;
                Properties.Settings.Default.Hora = dtpHorario.Value.Hour;
                Properties.Settings.Default.Save();
            }
            this.Dispose();
        }
    }
}
