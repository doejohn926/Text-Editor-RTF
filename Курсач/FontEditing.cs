using System.Windows.Forms;
using System.Drawing;

namespace Текстовый_редактор_RTF
{
    class FontEditing
    {
        private int sizeSelection = 1;
        private RichTextBox rtb;

        public FontEditing(RichTextBox rtb)
        {
            this.rtb = rtb;
        }

        public void FontUpDown(NumericUpDown numeric, ComboBox cmb)
        {
            int theNumberOfLettersInTheSelection = rtb.SelectionLength;
            string wordForSearch = rtb.SelectedText;
            char[] array = wordForSearch.ToCharArray();

            int startingPoint = rtb.Find(array, rtb.SelectionStart, rtb.MaxLength);
            int forStartSelection = startingPoint;

            for (int i = startingPoint; i < (theNumberOfLettersInTheSelection + startingPoint); i++)
            {
                rtb.Select(i, sizeSelection);
                cmb.Text = rtb.SelectionFont.Name;
                rtb.SelectionFont = new Font(cmb.Text, (int)numeric.Value, rtb.SelectionFont.Style);
            }

            if (forStartSelection != -1)
            {
                rtb.Select(forStartSelection, theNumberOfLettersInTheSelection);
            }
            else
            {
                rtb.SelectionFont = new Font(cmb.Text, (int)numeric.Value, rtb.SelectionFont.Style);
            }

            rtb.Focus();
        }

        public void FontStyles(FontStyle fontStyle)
        {
            Font oldFont = rtb.SelectionFont;
            Font unknowFont;
            int j;
            int theNumberOfLettersInTheSelection = rtb.SelectionLength;
            string wordForSearch = rtb.SelectedText;
            char[] array = wordForSearch.ToCharArray();

            int startingPoint = rtb.Find(array, rtb.SelectionStart, rtb.MaxLength);
            int forStartSelection = startingPoint;

            if (oldFont == null)
            {
                for (j = startingPoint; j < (theNumberOfLettersInTheSelection + startingPoint); j++)
                {
                    rtb.Select(j, sizeSelection);
                    unknowFont = rtb.SelectionFont;

                    if (unknowFont.Style == fontStyle)
                    {
                        rtb.Select(j, sizeSelection);
                        unknowFont = rtb.SelectionFont;
                        rtb.SelectionFont = new Font(unknowFont, unknowFont.Style & ~fontStyle);
                    }
                    else
                    {
                        rtb.Select(j, sizeSelection);
                        unknowFont = rtb.SelectionFont;
                        rtb.SelectionFont = new Font(unknowFont, unknowFont.Style | fontStyle);
                    }
                }
            }
            else if (oldFont.Style == fontStyle)
            {
                for (int i = startingPoint; i < (theNumberOfLettersInTheSelection + startingPoint); i++)
                {
                    rtb.Select(i, sizeSelection);
                    oldFont = rtb.SelectionFont;
                    rtb.SelectionFont = new Font(oldFont, oldFont.Style & ~fontStyle);
                }
            }
            else
            {
                for (int i = startingPoint; i < (theNumberOfLettersInTheSelection + startingPoint); i++)
                {
                    rtb.Select(i, sizeSelection);
                    oldFont = rtb.SelectionFont;

                    if (oldFont.Style == fontStyle)
                    {
                        rtb.SelectionFont = new Font(oldFont, oldFont.Style & ~fontStyle);
                    }
                    else
                    {
                        rtb.SelectionFont = new Font(oldFont, oldFont.Style | fontStyle);
                    }
                }
            }

            if (forStartSelection != -1)
            {
                rtb.Select(forStartSelection, theNumberOfLettersInTheSelection);
            }
            else if (oldFont.Style == fontStyle)
            {
                rtb.SelectionFont = new Font(oldFont, oldFont.Style & ~fontStyle);
            }
            else
            {
                rtb.SelectionFont = new Font(oldFont, oldFont.Style | fontStyle);
            }

            rtb.Focus();
        }

        public void FatFont()
        {
            FontStyles(FontStyle.Bold);
        }

        public void ItalicsFont()
        {
            FontStyles(FontStyle.Italic);
        }

        public void UnderlinedFont()
        {
            FontStyles(FontStyle.Underline);
        }

        public void PickFont(NumericUpDown numeric, ComboBox cmb)
        {
            int theNumberOfLettersInTheSelection = rtb.SelectionLength;
            string wordForSearch = rtb.SelectedText;
            char[] array = wordForSearch.ToCharArray();

            int startingPoint = rtb.Find(array, rtb.SelectionStart, rtb.MaxLength);
            int forStartSelection = startingPoint;

            for (int i = startingPoint; i < (theNumberOfLettersInTheSelection + startingPoint); i++)
            {
                rtb.Select(i, sizeSelection);
                int sizeFont = (int)rtb.SelectionFont.Size;
                rtb.SelectionFont = new Font(cmb.Text, sizeFont, rtb.SelectionFont.Style);
            }

            rtb.DeselectAll();

            if (forStartSelection != -1)
            {
                rtb.Select(forStartSelection, theNumberOfLettersInTheSelection);
            }
            else
            {
                rtb.SelectionFont = new Font(cmb.Text, (int)numeric.Value, rtb.SelectionFont.Style);
            }

            rtb.Focus();

        }

        public void LoadFont(NumericUpDown numeric, ComboBox cmb)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cmb.Items.Add(font.Name.ToString());
            }

            cmb.SelectedIndex = 0;
            rtb.Font = new Font(cmb.Text, (int)numeric.Value, rtb.SelectionFont.Style);
        }

        public void PickColor(ColorDialog cd, ComboBox cmb)
        {

            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionColor = cd.Color;
                cmb.ForeColor = cd.Color;

                rtb.Focus();
            }
        }
    }
}
