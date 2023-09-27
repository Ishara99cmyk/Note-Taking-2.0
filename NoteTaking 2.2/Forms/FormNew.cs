using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using System.IO;

namespace NoteTaking_2._2.Forms
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "pdf file|* .pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate());
                    try
                    {
                        iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(richTextBoxPDF.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            richTextBoxPDF.SelectionFont = new Font(richTextBoxPDF.SelectionFont, richTextBoxPDF.SelectionFont.Style | FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            richTextBoxPDF.SelectionFont = new Font(richTextBoxPDF.SelectionFont, richTextBoxPDF.SelectionFont.Style | FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            richTextBoxPDF.SelectionFont = new Font(richTextBoxPDF.SelectionFont, richTextBoxPDF.SelectionFont.Style | FontStyle.Underline);
        }

        private void btnStrike_Click(object sender, EventArgs e)
        {
            richTextBoxPDF.SelectionFont = new Font(richTextBoxPDF.SelectionFont, richTextBoxPDF.SelectionFont.Style | FontStyle.Strikeout);
        }
        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontChange();
        }
        private void FontChange()
        {
               
            float fontsize = 10;
            string fontname = richTextBoxPDF.SelectionFont.Name;
            if (comboBoxSize.Text != "") fontsize = float.Parse(comboBoxSize.Text);
            if (fontsize == 0) fontsize = 10;
            if (richTextBoxPDF.SelectionLength > 0)
            {
                richTextBoxPDF.SelectionFont = new Font(fontname, fontsize);
            }
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            btnUnderline.Text = "Underline";
            btnUnderline.Font = new Font("Arial", 10, FontStyle.Underline, GraphicsUnit.Point);
            AddFontSize();
        }
        private void AddFontSize()
        {
            // throw new Not Implemented Exception();    
            comboBoxSize.Items.Add("8");
            comboBoxSize.Items.Add("9");
            comboBoxSize.Items.Add("10");
            comboBoxSize.Items.Add("11");
            comboBoxSize.Items.Add("12");
        }
    }
}
