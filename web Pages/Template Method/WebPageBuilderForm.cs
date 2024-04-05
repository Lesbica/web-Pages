using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_Pages.Template_Method
{
    abstract class WebPageBuilderForm : Form
    {
        protected abstract void AddHeader();
        protected abstract void AddContent();
        protected abstract void AddFooter();

        protected void BuildPage()
        {
            AddHeader();
            AddContent();
            AddFooter();
        }

        protected void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BuildPage();
        }
    }
}
