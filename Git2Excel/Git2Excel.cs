using System;
using LibGit2Sharp;
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
                if(!Repository.IsValid(path))
                {
                    MessageBox.Show("Iniciando repositório Git2Excel em: " + path);
                    Init init = new Init(path);
                }
                else
                {
                    MessageBox.Show("Repositório já existente");
                }
            }
            else
            {
                MessageBox.Show("Diretório vazio");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                if (Repository.IsValid(path))
                {
                    Add add = new Add(path);
                }
                else
                {
                    MessageBox.Show("Repositório não existente");
                }
            }
            else
            {
                MessageBox.Show("Diretório vazio");
            }
        }
    }
}
