using System;
using System.Windows.Forms;

namespace Текстовый_редактор_RTF
{

    public partial class Form1 : Form
    {
        private FontEditing fontEditing;
        private TextFormating textFormating;
        private Menu menu;

        public Form1()
        {
            InitializeComponent();
            fontEditing = new FontEditing(richTextBox1);
            textFormating = new TextFormating(richTextBox1);
            menu = new Menu(richTextBox1);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            menu.OpenFile(openFileDialog);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            menu.SaveFile(saveFileDialog);
        }

        private void SaveAsFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogAs = new SaveFileDialog();
            menu.SaveAsFile(saveFileDialogAs);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            menu.ExitingTheApplication();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            menu.ClearAll();
            PickFont.SelectedIndex = 0;
            numericUpDown1.Value = 14;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            menu.SelectAll();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fontEditing.FontUpDown(numericUpDown1, PickFont);
        }

        private void Copying_Click(object sender, EventArgs e)
        {
            textFormating.Copy();
        }

        private void Pasting_Click(object sender, EventArgs e)
        {
            textFormating.Paste();
        }

        private void Cuting_Click(object sender, EventArgs e)
        {
            textFormating.Cut();
        }

        private void FatFont_Click(object sender, EventArgs e)
        {
            fontEditing.FatFont();
        }

        private void ItalicsFont_Click(object sender, EventArgs e)
        {
            fontEditing.ItalicsFont();
        }

        private void UnderlinedFont_Click(object sender, EventArgs e)
        {
            fontEditing.UnderlinedFont();
        }

        private void LeftText_Click(object sender, EventArgs e)
        {
            textFormating.LeftText();
        }

        private void MIDDLETEXT_Click(object sender, EventArgs e)
        {
            textFormating.MiddleText();
        }

        private void RightText_Click(object sender, EventArgs e)
        {
            textFormating.RightText();
        }

        private void backDoIt_Click(object sender, EventArgs e)
        {
            textFormating.BackDo();
        }

        private void ForwardDoIt_Click(object sender, EventArgs e)
        {
            textFormating.ForwardDo();
        }

        private void PickFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontEditing.PickFont(numericUpDown1, PickFont);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontEditing.LoadFont(numericUpDown1, PickFont);
            menu.GlobalOpenFile();
        }

        private void PickColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            fontEditing.PickColor(colorDialog, PickColor);
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && (e.Control))
            {
                menu.ClearAll();
                PickFont.SelectedIndex = 0;
                numericUpDown1.Value = 14;
            }

            if (e.KeyCode == Keys.Escape)
            {
                menu.ExitingTheApplication();
            }

            if (e.KeyCode == Keys.C && (e.Control))
            {
                textFormating.Copy();
            }

            if (e.KeyCode == Keys.A && e.Control)
            {
                menu.SelectAll();
            }

            if (e.KeyCode == Keys.V && (e.Control))
            {
                textFormating.Paste();
            }

            if (e.KeyCode == Keys.X && (e.Control))
            {
                textFormating.Cut();
            }

            if (e.KeyCode == Keys.Z & (e.Shift) & (e.Control))
            {
                textFormating.ForwardDo();
            }
            else
            {
                if (e.KeyCode == Keys.Z && (e.Control))
                {
                    textFormating.BackDo();
                }
            }

            if (e.KeyCode == Keys.S & (e.Shift) & (e.Control))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                menu.SaveAsFile(saveFileDialog);

            }
            else
            {
                if (e.KeyCode == Keys.S & (e.Control))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    menu.SaveFile(saveFileDialog);
                }
            }

            if (e.KeyCode == Keys.O && (e.Control))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                menu.OpenFile(openFileDialog);
            }
        }
    }
}
