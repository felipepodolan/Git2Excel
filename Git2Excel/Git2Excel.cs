using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git2Excel
{
    public partial class Git2Excel : Form
    {

        private String path = "";

        public Git2Excel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navegar = new System.Windows.Forms.FolderBrowserDialog();
            if(Navegar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = Navegar.SelectedPath;
                MessageBox.Show(path);
            }
        }

        private void gitinit_Click(object sender, EventArgs e)
        {
            if(path != "")
            {
                MessageBox.Show("Iniciando repositório Git2Excel em: " + path);
                Init init = new Init(path);
            }
            else
            {
                MessageBox.Show("Diretório vazio");
            }
        }
    }
}
