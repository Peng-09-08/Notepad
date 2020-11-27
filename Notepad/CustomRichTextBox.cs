using System.Windows.Forms;

namespace Notepad
{
    public class CustomRichTextBox : RichTextBox
    {
        private string _previousText = "";

        public string PreviousText
        {
            get { return _previousText; }
        }

        public CustomRichTextBox() { }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            _previousText = Text;
            base.OnKeyDown(e);
        }
    }
}
