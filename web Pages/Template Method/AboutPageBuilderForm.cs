using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_Pages.Template_Method
{
    class AboutPageBuilderForm : WebPageBuilderForm
    {
        private PictureBox pictureBoxHeader;
        private PictureBox pictureBoxFooter;
        private TextBox textBoxContent;
        private Button buttonHome;

        public AboutPageBuilderForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Ініціалізація елементів управління
            pictureBoxHeader = new PictureBox();
            pictureBoxHeader.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHeader.Dock = DockStyle.Top; // PictureBox для заголовка розміщується вгорі
            Controls.Add(pictureBoxHeader);

            pictureBoxFooter = new PictureBox();
            pictureBoxFooter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFooter.Dock = DockStyle.Bottom; // PictureBox для підвалу розміщується внизу
            Controls.Add(pictureBoxFooter);

            textBoxContent = new TextBox();
            textBoxContent.Multiline = true;
            textBoxContent.Anchor = AnchorStyles.Left | AnchorStyles.Right; // TextBox для вмісту розміщується між PictureBox для заголовка і підвалу
            Controls.Add(textBoxContent);

            buttonHome = new Button();
            buttonHome.Text = "Home";
            buttonHome.Dock = DockStyle.Right;
            buttonHome.Click += buttonHome_Click;
            Controls.Add(buttonHome);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide(); // ховаємо поточну форму
            HomePageBuilderForm homePageForm = new HomePageBuilderForm();
            homePageForm.ShowDialog(); // показуємо нову форму модально
            this.Show(); // після закриття нової форми, показуємо знову поточну форму
        }

        protected override void AddHeader()
        {
            pictureBoxHeader.Image = Image.FromFile("image\\Header.jpg");
            DisplayMessage("Додано заголовок About сторінки");
        }

        protected override void AddContent()
        {
            textBoxContent.Text = "Це текст бокс для вмісту сторінки про нас";
            DisplayMessage("Додано вміст About сторінки");
        }

        protected override void AddFooter()
        {
            pictureBoxFooter.Image = Image.FromFile("image\\Footer.jpg");
            DisplayMessage("Додано підвал About сторінки");
        }
    }
}
