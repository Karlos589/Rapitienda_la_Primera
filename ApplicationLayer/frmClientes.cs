using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class frmClientes : Form
    {
        public  frmClientes()
        {
            InitializeComponent();
        }


        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarFechas();
        }

        public void GuardarEDB()
        { 
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidarFormulario();
            ValidarFechas();
        }
        private bool ValidarFormulario() 
        { 
          if(CmbTipoDocumento.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El tipo de documento es un dato" +
                    " obligatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                CmbTipoDocumento.Focus();
                return false;
            }
            if (txtNumeroDocumento.Text=="")
            {
            MessageBox.Show("El numero de documento es un dato"+
                " obligatorio", "Error de validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            txtNumeroDocumento.Focus();
            return false;
            }
            if(txtPrimerNombre.Text=="")
            {
                MessageBox.Show("El primer nombre es un dato"+
                    " obligatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrimerNombre.Focus();
                return false;
            }
            if (txtPrimerApellido.Text == "")
            {
                MessageBox.Show("El primer Apellido es un dato" +
                    " obligatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrimerApellido.Focus();
                return false;

            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("El numero de telefono es un dato" +
                    " oblogatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;

            } 
            if (txtCorreoElectronico.Text == "")
            {
                MessageBox.Show("El correo electronico es un dato" +
                    " oblogatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCorreoElectronico.Focus();
                return false;

            } 
            if (cmbAnio.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El año es un dato" +
                    " obligatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbAnio.Focus();
                return false;
            } 
            if (cmbMes.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El mes es un dato" +
                    " obligatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbMes.Focus();
                return false;
            } 
            if (cmbDia.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El dia es un dato" +
                    " obligatorio", "Error de validacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
               cmbDia.Focus();
                return false;
            }  
          return true;
        }
      
        private void CargarFechas()
        {
            for (int dia = 1; dia <= 31; dia++)
            {
                cmbDia.Items.Add(dia); 
            }
            int aux = DateTime.Now.Year;
            for (int anyo = 1900; anyo <= 2020; anyo++)
            {
                cmbAnio.Items.Add(anyo);
            }
        }
        private bool ValidarFechas()
        {
            string auxMes = cmbMes.Text;
            int auxAnyo = 0;
            int auxDia = 0;
            Int32.TryParse(cmbAnio.Text, out auxAnyo);
            Int32.TryParse(cmbDia.Text, out auxDia);

            if (auxAnyo != 0)
            {
                if (auxDia == 31 && auxMes == "Abril" ||
                   auxDia == 31 && auxMes == "Junio" ||
                   auxDia == 31 && auxMes == "Septiembre" ||
                   auxDia == 31 && auxMes == "Noviembre"
                    )
                {
                    MessageBox.Show("Error");
                    return false;
                }
                if (auxDia > 29 && auxMes == "Febrero")
                {
                    MessageBox.Show("Error");
                    return false;
                }
                if (auxDia == 29 && auxMes == "Febrero")
                {
                    if (auxAnyo % 400 == 0 || (auxAnyo % 4 == 0 && auxAnyo % 100 != 0))
                    {
                        MessageBox.Show("Fecha correcta");
                        return true;
                    }
                    else
                    {

                        MessageBox.Show("Error");
                        return false;

                    }

                }

            }
            else
            {
                MessageBox.Show("Error");
                return false;
            }

            return true;

        }

        }


      

      
    }

