/*
        Programmeur: Nathan Comeau
        Date: 10/29/2019
        But:  Projet 01 - Afficher l'alignement des joueurs d'une equipe de hockey ainsi que l'imprimer.
 
        Solution: AlignementJoueurs.sln
        Projet:   AlignementJoueurs.csproj
        Classe:   AlignementJoueursForm.cs
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Text;

using g = AlignementJoueursForm.AlignementJoueurGen;
using em = AlignementJoueursForm.AlignementJoueurGen.ErrorMessages;

namespace AlignementJoueursForm
{
    public partial class AlignementJoueursForm : Form
    {
        #region Initialisation des composantes
        public AlignementJoueursForm()
        {
            InitializeComponent();
        }

        private void AlignementJoueursForm_Load(object sender, EventArgs e)
        {
            g.InitMessages();
            InitFont();
            try
            {
                lineupRichTextBox.LoadFile(Application.StartupPath + @"\..\..\Data\TitanLineup.rtf",RichTextBoxStreamType.RichText);
            }
            catch (Exception  ex)
            {
                MessageBox.Show(g.errorMessages[(int)em.EmFileLoad] + ex.ToString());
            }

            lineupRichTextBox.Find("Félix-Anthony Éthier");
        }

        #endregion

        #region Methodes Privees

        #region Initialisation des polices

        private void InitFont()
        {
            InstalledFontCollection fontCollection = new InstalledFontCollection();

            FontFamily[] fontFamilies = fontCollection.Families;
            List<string> fonts = new List<string>();

            foreach(FontFamily font in fontFamilies)
            {
                fonts.Add(font.Name);
            }

            fonts.Reverse();

            foreach(string s in fonts)
            {
                fontToolStripComboBox.Items.Add(s);
            }
        }

        #endregion

        #region Police selected index changed

        /// <summary>
        /// Changes the font based on the selected item in the dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Font oFont = new Font(fontToolStripComboBox.SelectedItem.ToString(), lineupRichTextBox.Font.Size);
                lineupRichTextBox.Font = oFont;
            }
            catch (Exception)
            {
                MessageBox.Show(g.errorMessages[(int)em.EmUnexpected]);
            }
        }

        #endregion

        #region Printing
        private void printButton_Click(object sender, EventArgs e)
        {
            lineupPrintPreviewDialog.ShowDialog();
        }

        private void lineupPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Variables
            Graphics g = e.Graphics;

            int posx, posy;
            Font headerFont, columnHFont, listFont;
            Single headerHeight, headerWidth, imageWidth, imageHeight;
            Image logo = null;
            String header; // Top header label - titleLabel
            //Titles over list of items - number
            Single yFloat = 0;
            
            //Variable assignment

            posx = e.MarginBounds.X;
            posy = e.MarginBounds.Y;

            header = "Alignement Officiel";
            headerFont = new Font("Courier New", 24.0F, lineupRichTextBox.Font.Style);
            columnHFont = new Font("Arial", 14.0F, FontStyle.Bold); //Font for the column headers
            listFont = new Font("Times New Roman", 14.0F, FontStyle.Regular); //Font for the listed items

            logo = logoPictureBox.Image;

            headerHeight = headerFont.GetHeight();
            imageHeight = (logo.Height / logo.VerticalResolution) * 100.0F;
            headerWidth = g.MeasureString(header, headerFont).Width;
            imageWidth = (logo.Width / logo.HorizontalResolution) * 100.0F;

            Single centerImage = (e.PageBounds.Width - imageWidth) / 2;
            Single centerText = (e.PageBounds.Width - headerWidth) / 2;

            string columnHead = "Pos" + "#".PadLeft(9) + "Nom".PadLeft(14);

            yFloat = posy;

            g.DrawImage(logo, centerImage, yFloat);

            yFloat += imageHeight +10;

            g.DrawString(header, headerFont, Brushes.Maroon, centerText, yFloat);

            yFloat += headerHeight *1.2F;

            Pen penBlack = new Pen(Brushes.Black, 4.0F);

            g.DrawLine(penBlack,centerText,yFloat,headerWidth+centerText,yFloat);

            yFloat += headerHeight * 1.2F;

            g.DrawString(columnHead,columnHFont,Brushes.Black,centerText,yFloat);

            yFloat += headerHeight;

            for(int i = 0; i<lineupRichTextBox.Lines.Count();i++)
            {
                g.DrawString(lineupRichTextBox.Lines[i], listFont, Brushes.Black, centerText, yFloat);
                yFloat += headerHeight;
            }
        }

        #endregion

        private void displayButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
               for(int i = 0;i<lineupRichTextBox.Text.Length;i++)
               {
                   if(lineupRichTextBox.Find(searchTextBox.Text,i,RichTextBoxFinds.None) != -1)
                   {
                      count++;
                      i = lineupRichTextBox.Find(searchTextBox.Text, i, RichTextBoxFinds.None) + 1;
                   }                       
               }
               MessageBox.Show("Nombre de joueurs = " + count);
            }
            catch(Exception)
            {
                MessageBox.Show(g.errorMessages[(int)em.EmUnexpected]);
            }
            
        }

        #endregion

    }
}
