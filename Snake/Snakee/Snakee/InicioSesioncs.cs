using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakee
{
    public partial class InicioSesioncs : Form
    {
        public InicioSesioncs()
        {
            InitializeComponent();
        }

        private void InicioSesioncs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            formulario1.username = nickname.Text;    //Pasamos el nick name al otro formulario
            formulario1.Show();
        }
    }
}
