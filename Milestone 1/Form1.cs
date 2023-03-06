//JARED ABRAMS//CST-150//05MARCH2023//THIS IS MY OWN WORK


namespace Milestone_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_GameTitle.Text = string.Empty;
            textBox_GameCost.Text = string.Empty;
            textBox_GameGenre.Text = string.Empty;
            textBox_Quantity.Text = string.Empty;
            textBox_UPC.Text = string.Empty;
        }

        private void button_NewEntry_Click(object sender, EventArgs e)
        {
            textBox_GameTitle.Text = string.Empty;
            textBox_GameCost.Text = string.Empty;
            textBox_GameGenre.Text = string.Empty;
            textBox_Quantity.Text = string.Empty;
            textBox_UPC.Text = string.Empty;
        }

        private void button_ModifyEntry_Click(object sender, EventArgs e)
        {
            textBox_GameTitle.Text = string.Empty;
            textBox_GameCost.Text = string.Empty;
            textBox_GameGenre.Text = string.Empty;
            textBox_Quantity.Text = string.Empty;
            textBox_UPC.Text = string.Empty;
        }
    }
}