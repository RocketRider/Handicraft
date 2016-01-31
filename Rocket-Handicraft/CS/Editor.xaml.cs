#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Win32;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
#if !Framework3_5
using System.Linq;
#endif

namespace DocumentEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
            InitializeComponent();
            /*
#if !Framework3_5
            //Enables touch manipulation.
            richTextBoxAdv.IsManipulationEnabled = true;
#endif
            DataContext = richTextBoxAdv;
#if Framework3_5 || Framework4_0
            Assembly assembly = typeof(MainWindow).Assembly;
#else
            Assembly assembly = typeof(MainWindow).GetTypeInfo().Assembly;
#endif
            Stream stream = assembly.GetManifestResourceStream("DocumentEditor.Assets.GettingStarted.docx");
            richTextBoxAdv.Load(stream, FormatType.Docx);
            */

            /*
            DocumentAdv document = new DocumentAdv();
            SectionAdv section = new SectionAdv();
            ParagraphAdv paragraph = new ParagraphAdv();
            SpanAdv span = new SpanAdv();
            span.Text = "This is span text";
            paragraph.Inlines.Add(span);
            section.Blocks.Add(paragraph);
            document.Sections.Add(section);
            richTextBoxAdv2.Document = document;
            */

            
            DocumentEditorBox doc1 = new DocumentEditorBox(richTextRibbon);
            dockingManager.CreateHorizontalTabGroup(doc1.TextBox);
            
        }



        /*
        private void richTextBoxAdv_GotFocus(object sender, RoutedEventArgs e)
        {
            richTextRibbon.DataContext = richTextBoxAdv;
        }

        private void richTextBoxAdv2_GotFocus(object sender, RoutedEventArgs e)
        {
            richTextRibbon.DataContext = richTextBoxAdv2;
        }

        private void richTextBoxAdv3_GotFocus(object sender, RoutedEventArgs e)
        {
            richTextRibbon.DataContext = richTextBoxAdv3;
        }
        */

        private void ribbonWindow_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DockingManager_ActiveWindowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
