using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalletaFortuna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] mensajesalea =
        {
            "Buena suerte en el semestre",
            "Tendras un buen año",
            "Dios te dara muchas alegrias este nuevo año",
            "Pasaras un buen cumpleaños",
            "Haras nuevas y buenas amistades",
            "Que cada día esté lleno de bendiciones y buena suerte.",
            "Presentacion programa"
        };

        private Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int imensaje = random.Next(mensajesalea.Length);
            MessageBox.Show(mensajesalea[imensaje], "Mensaje Random");
        }
    }
}
