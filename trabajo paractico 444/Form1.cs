using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_paractico_444
{
    public partial class Form1 : Form

    

    {

        listadeperros Lista { get; set; } = new listadeperros();
        Perro perrito = new Perro();
        public Perro[] perros { get; set; }

        public Form1()
        {
            InitializeComponent();
            dg.DataSource = Lista.dt;
            
            

        }

  
        
        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text == " ")
            {
                MessageBox.Show(" el nombre no puede estar vacio");
            }
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        

            
           
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        
        
        
        }

        private void cmbRaza_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            Lista.añadirperro(txtnombre.Text,txtdueño.Text,cmbRaza.SelectedItem.ToString(),Convert.ToInt32(txtedad.Text),cmbSexo.SelectedItem.ToString());


        
        
        }



        private void btnsalir_Click(object sender, EventArgs e)
        {
           
            
            var eleccion = DialogResult;
            for (int i = 0; i < 1; i++)                                   
            {
                eleccion = MessageBox.Show("Desea salir? Presione 1 vez Si, si no lo desea presione No " ,"Salir", MessageBoxButtons.YesNo);

                if (eleccion == DialogResult.No)
                {
                    break;
                }
            }

            if (eleccion == DialogResult.Yes)
            {
                Close();
            }

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
            
       
        }






        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Perro buscperro = Lista.Buscar(System.Convert.ToInt32(txtid.Text));
            txtnombre.Text = buscperro.Nombre;
            txtdueño.Text = buscperro.nombredueño;
            txtedad.Text = buscperro.Edad.ToString();
            cmbRaza.Text = buscperro.Raza;
            cmbSexo.Text = buscperro.Sexo;
        
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdueño.Clear();
            txtedad.Clear();
            txtnombre.Clear();
            cmbRaza.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
        }
    }
}
