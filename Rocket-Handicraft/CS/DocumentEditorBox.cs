using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DocumentEditor
{
    class DocumentEditorBox
    {
        private SfRichTextBoxAdv textBox; 
        private SfRichTextRibbon ribbon;

        public SfRichTextBoxAdv TextBox
        {
            get
            {
                return textBox;
            }

            set
            {
                textBox = value;
            }
        }

        public DocumentEditorBox(SfRichTextRibbon ribbon)
        {
            this.ribbon = ribbon;
            textBox = new SfRichTextBoxAdv();
            textBox.GotFocus += TextBox_GotFocus;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ribbon.DataContext = textBox;
        }
    }
}
