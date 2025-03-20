using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLientes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Clientes_menu_Click(object sender, EventArgs e)
        {
            
            FrmCadClientes frm = new FrmCadClientes();
            frm.MdiParent = this;  // Abrindo o forms dentro do menu cad
            frm.Show();// Abrindo o forms dentro do menu cad
            
        }
    }
}
