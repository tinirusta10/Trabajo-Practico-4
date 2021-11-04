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
    class listadeperros
    {

        public listadeperros()
        {

            dt.TableName = "listadeperros";
            dt.Columns.Add("id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("NombreDueño");
            dt.Columns.Add("Raza");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Sexo");
            LeoArchivo();

        }

        public void LeoArchivo()
        {
            if (System.IO.File.Exists("listaperro.xml"))
            {
                dt.Clear();
                dt.ReadXml("listaperro.xml");
                ID = dt.Rows.Count - 1;
            }


        }


        public Perro[] perros { get; set; }

        public DataTable dt { get; set; } = new DataTable();

        public void Aumentar()
        {

            if (perros == null)
            {
                perros = new Perro[1];
            }
            else
            {
                Perro[] auxiliar = new Perro[perros.Length + 1];
                for (int i = 0; i < perros.Length; i++)
                {
                    auxiliar[i] = perros[i];
                }
                perros = auxiliar;



            }
        }

        public int ID { get; set; } = 0;


        public Perro Buscar(int codigo)

        {
            Perro resp = new Perro();
           DataRow [] fila =  dt.Select  ("id=" + codigo.ToString());
           
            
            resp.id = Convert.ToInt32  (fila [0][0]);
            resp.Nombre= Convert.ToString (fila[0][1]);
            resp.nombredueño = Convert.ToString(fila[0][2]);
            resp.Raza = Convert.ToString(fila[0][3]);
            resp.Edad= Convert.ToInt32(fila[0][4]);
            resp.Sexo = Convert.ToString(fila[0][5]);


            return resp;
            
        }


        public void añadirperro(string nombre, string nombred, string raza, int edad, string sexo)

        {
            Perro perrito = new Perro();
            perrito.Nombre = nombre;
            perrito.nombredueño = nombred;
            perrito.Raza = raza;
            perrito.Edad = edad;
            perrito.Sexo = sexo;
            ID = ID + 1;
            perrito.id = ID;
      
            dt.Rows.Add();
            int numeroRegistroNuevo = dt.Rows.Count - 1;
            dt.Rows[numeroRegistroNuevo]["id"] = perrito.id.ToString();
            dt.Rows[numeroRegistroNuevo]["Nombre"] = perrito.Nombre;
            dt.Rows[numeroRegistroNuevo]["NombreDueño"] = perrito.nombredueño;
            dt.Rows[numeroRegistroNuevo]["Raza"] = perrito.Raza;
            dt.Rows[numeroRegistroNuevo]["Edad"] = perrito.Edad.ToString();
            dt.Rows[numeroRegistroNuevo]["Sexo"] = perrito.Sexo;

            dt.WriteXml("listaperro.xml");
        
        }
                            
    
    }
}
