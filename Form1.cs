using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_AngelHandal{
    public partial class Form1 : Form{
        String []nombres = new string[5];  //globales
        String []edades = new string[5];   //globales
        public Form1(){
            InitializeComponent();
        }

        private void agregarBtn_Click_1(object sender, EventArgs e){
            //FOR PARA AGREGAR UN NUEVO DATO A NUESTROS ARREGLOS
            for (int i = 0; i < 1; i++){
                nombres[i] = txtnombre.Text;
                edades[i] = txtedad.Text;

            }

            //FOR PARA MOSTRAR NUESTROS ARREGLOS CONCATENADOS,  (EDAD LO TOME COMO STRING PARA PODER CONCATENARLO)
            for (int i = 0; i < 1; i++){
                registroLst.Items.Add("Nombre: " + nombres[i] + "   Edad: " + edades[i]);

            }
        }

    }
}
