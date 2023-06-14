using System.Windows.Forms;

namespace Текстовый_редактор_RTF
{
    class TextFormating
    {
        private RichTextBox rtb;

        public TextFormating(RichTextBox rtb)
        {
            this.rtb = rtb;
        }

        public void Copy()
        {
            rtb.Copy();
            rtb.Focus();
        }

        public void Paste()
        {
            rtb.Paste();
            rtb.Focus();
        }

        public void Cut()
        {
            rtb.Cut();
            rtb.Focus();
        }

        public void LeftText()
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
            rtb.Focus();
        }

        public void MiddleText()
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
            rtb.Focus();
        }

        public void RightText()
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
            rtb.Focus();
        }

        public void BackDo()
        {
            if (rtb.CanUndo == true)
            {
                rtb.Undo();
            }

            rtb.Focus();
        }

        public void ForwardDo()
        {
            if (rtb.CanRedo == true)
            {
                rtb.Redo();
            }

            rtb.Focus();
        }
    }
}
