using MemoTest.Controladores;
using MemoTest.Entidades;

namespace MemoTest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            panelCategories.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCategories_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            panelCategories.Show();
        }
    }
}