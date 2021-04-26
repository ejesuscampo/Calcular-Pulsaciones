using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPulsaciones
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formhijo)
        {
            if (this.panelInicio.Controls.Count > 0)
                this.panelInicio.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelInicio.Controls.Add(fh);
            this.panelInicio.Tag = fh;
            fh.Show();

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistro());
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConsulta());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
