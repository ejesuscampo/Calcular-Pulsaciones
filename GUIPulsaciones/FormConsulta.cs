using BLL;
using System;
using System.Windows.Forms;

namespace GUIPulsaciones
{
    public partial class FormConsulta : Form
    {
        private PersonaService personaService;
        public FormConsulta()
        {
            InitializeComponent();
            personaService = new PersonaService();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var filtrado = CmbFiltro.Text;
            if (filtrado.Equals(""))
            {
                MessageBox.Show("Escoja una opción de filtrado");
            }
            else
            {
                ConsultaResponse response;
                if (filtrado.Equals("Todos"))
                {
                    response = personaService.Consultar();
                }
                else
                {
                    var sexo = MapearSexo(filtrado);
                    response = personaService.Consultar(sexo);
                }
                if (!response.Error)
                {
                    TblDatos.DataSource = response.Personas;
                }
            }

        }

        private string MapearSexo(string filtrado)
        {
            if (filtrado.Equals("Femenino"))
            {
                return "Femenino";
            }
            else
            {
                return "Masculino";
            }
        }
    }
}
