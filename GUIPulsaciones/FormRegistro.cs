using BLL;
using Entity;
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
    public partial class FormRegistro : Form
    {
        private PersonaService personaService;
        public FormRegistro()
        {
            personaService = new PersonaService();
            InitializeComponent();
        }

        private void GuardarCalcular()
        {
            Persona persona = new Persona()
            {
                Identificacion = TxtIdentificacion.Text,
                Nombre = TxtNombre.Text,
                Edad = int.Parse(TxtEdad.Text),
                Sexo = CmbSexo.Text,
            };
            persona.CalcularPulsaciones();
            TxtPulsaciones.Text = persona.Pulsaciones.ToString();
            var mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje, "Mensaje de guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCalcularGuardar_Click(object sender, EventArgs e)
        {
            GuardarCalcular();
        }

    }
}
