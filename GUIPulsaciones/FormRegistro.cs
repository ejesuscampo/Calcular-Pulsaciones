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

        private void TxtIdentificacion_Validated(object sender, EventArgs e)
        {
            errorProviderRegistro.SetError(TxtIdentificacion, "");
        }

        private void TxtIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            bool succes = int.TryParse(TxtIdentificacion.Text, out int resultado);
            if (!succes)
            {
                errorProviderRegistro.SetError(TxtIdentificacion, "Digite solo numeros");
                e.Cancel = true;
            }
        }

        private void TxtEdad_Validated(object sender, EventArgs e)
        {
            errorProviderRegistro.SetError(TxtEdad, "");
        }

        private void TxtEdad_Validating(object sender, CancelEventArgs e)
        {
            if (!validarEdad(TxtEdad.Text, out string mensaje))
            {
                errorProviderRegistro.SetError(TxtEdad, mensaje);
                e.Cancel = true;
            }
        }

        private bool validarEdad(string valor, out string mensaje)
        {
            if (string.IsNullOrEmpty(valor))
            {
                mensaje = "Digite datos para la edad";
                return false;
            }

            bool succes = int.TryParse(TxtEdad.Text, out int resultado);
            if (!succes)
            {
                mensaje = "Digite solo valores numericos";
                return false;
            }
            mensaje = "Datos correctos";
            return true;
        }
    }
}
