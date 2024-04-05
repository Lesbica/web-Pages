using web_Pages.Template_Method;

namespace web_Pages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // ховаємо поточну форму
            HomePageBuilderForm homePageForm = new HomePageBuilderForm();
            homePageForm.ShowDialog(); // показуємо нову форму модально
            this.Show(); // після закриття нової форми, показуємо знову поточну форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // ховаємо поточну форму
            AboutPageBuilderForm aboutPageForm = new AboutPageBuilderForm();
            aboutPageForm.ShowDialog(); // показуємо нову форму модально
            this.Show(); // після закриття нової форми, показуємо знову поточну форму
        }
    }
}
