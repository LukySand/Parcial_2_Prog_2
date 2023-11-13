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
            panelDifficulty.Hide();

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

        private void CategoriesSelect(object sender, EventArgs e)
        {
            panelCategories.Hide();
            panelDifficulty.Show();
        }

        private void DifficultySelect(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "Easy")
            {
                Program.Difficulty = 0;
            }
            else
            {
                Program.Difficulty = 1;
            }
        }
    }
}