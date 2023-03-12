using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_4._8_REPASO___PALINDROMOS
{
    public partial class btnVerificar : Form
    {
        public btnVerificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text.ToLower(); //Obtenemos la cadena ingresada en el textbox y la convertimos a minúsculas
            char[] arrayOriginal = cadena.ToCharArray(); //Convertimos la cadena en un array de caracteres
            Array.Reverse(arrayOriginal); //Invertimos el array de caracteres

            string cadenaInvertida = new string(arrayOriginal); //Creamos una nueva cadena con el array invertido
            cadenaInvertida = cadenaInvertida.ToLower(); //Convertimos la cadena invertida a minúsculas

            if (cadena == cadenaInvertida) //Comparamos la cadena original con la invertida para determinar si es un palíndromo
            {
                lblResultado.Text = "La cadena es un palíndromo";
            }
            else
            {
                lblResultado.Text = "La cadena no es un palíndromo";
            }
        }
    }
}