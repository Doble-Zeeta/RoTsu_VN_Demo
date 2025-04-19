using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VN_RO_TSU_DEMO
{
    public partial class menusart : Form
    {
        public menusart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Juego juego = new Juego();
            juego.Show();
            this.Hide();
        }
    }
}
