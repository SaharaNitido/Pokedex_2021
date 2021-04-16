using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_mia
{
    public partial class Movimientos : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();

        public Movimientos()
        {
            InitializeComponent();
        }

    }
}
