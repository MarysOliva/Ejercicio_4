using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        string[] Nombre = new string[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combobox_lista.Sorted = false;
        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            string[] Nombre = new string[1];
            int[] Edad = new int[1];


            for (int i = 0; i < Nombre.Length; i++)
            {
                Nombre[i] = txt_nom.Text;
                Edad[i] = Convert.ToInt32(txt_edad.Text);

            }

            for (int i = 0; i < Nombre.Length; i++)
            {
                combobox_lista.Items.Add(Nombre[i] + " " + Edad[i]);

            }


            Limpiar();
        }

        private void Limpiar()
        {
            txt_nom.Clear();
            txt_edad.Clear();
            txt_nom.Focus();
        }

        private void btn_asc_Click(object sender, EventArgs e)
        {
            combobox_lista.Sorted = true;
        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            combobox_lista.Sorted = false;
           


        }
    }



       
  }



