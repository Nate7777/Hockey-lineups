namespace AlignementJoueursForm
{
    partial class AlignementJoueursForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlignementJoueursForm));
            this.lineupToolStrip = new System.Windows.Forms.ToolStrip();
            this.fontToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.lineupRichTextBox = new System.Windows.Forms.RichTextBox();
            this.listeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.rechercheGroupBox = new System.Windows.Forms.GroupBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.posLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.lineupPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.lineupPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lineupToolStrip.SuspendLayout();
            this.rechercheGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lineupToolStrip
            // 
            this.lineupToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lineupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripComboBox});
            this.lineupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.lineupToolStrip.Name = "lineupToolStrip";
            this.lineupToolStrip.Size = new System.Drawing.Size(458, 31);
            this.lineupToolStrip.TabIndex = 0;
            this.lineupToolStrip.Text = "toolStrip1";
            // 
            // fontToolStripComboBox
            // 
            this.fontToolStripComboBox.Name = "fontToolStripComboBox";
            this.fontToolStripComboBox.Size = new System.Drawing.Size(121, 31);
            this.fontToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontToolStripComboBox_SelectedIndexChanged);
            // 
            // lineupRichTextBox
            // 
            this.lineupRichTextBox.HideSelection = false;
            this.lineupRichTextBox.Location = new System.Drawing.Point(12, 159);
            this.lineupRichTextBox.Name = "lineupRichTextBox";
            this.lineupRichTextBox.Size = new System.Drawing.Size(434, 294);
            this.lineupRichTextBox.TabIndex = 2;
            this.lineupRichTextBox.Text = "";
            // 
            // listeLabel
            // 
            this.listeLabel.AutoSize = true;
            this.listeLabel.Location = new System.Drawing.Point(23, 139);
            this.listeLabel.Name = "listeLabel";
            this.listeLabel.Size = new System.Drawing.Size(342, 17);
            this.listeLabel.TabIndex = 3;
            this.listeLabel.Text = "Liste des joueurs(sélection indique le nom du joueur)";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(12, 459);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(434, 46);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Imprimer la liste des joueurs";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // rechercheGroupBox
            // 
            this.rechercheGroupBox.Controls.Add(this.displayButton);
            this.rechercheGroupBox.Controls.Add(this.posLabel);
            this.rechercheGroupBox.Controls.Add(this.searchTextBox);
            this.rechercheGroupBox.Location = new System.Drawing.Point(12, 530);
            this.rechercheGroupBox.Name = "rechercheGroupBox";
            this.rechercheGroupBox.Size = new System.Drawing.Size(434, 158);
            this.rechercheGroupBox.TabIndex = 5;
            this.rechercheGroupBox.TabStop = false;
            this.rechercheGroupBox.Text = "Recherche";
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayButton.ForeColor = System.Drawing.Color.White;
            this.displayButton.Location = new System.Drawing.Point(34, 91);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(358, 46);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Afficher le nombre de joueurs";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(39, 43);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(298, 17);
            this.posLabel.TabIndex = 1;
            this.posLabel.Text = "Position de joueur recherchée(D,RW,LW,C,G)";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(34, 63);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(358, 22);
            this.searchTextBox.TabIndex = 0;
            // 
            // lineupPrintPreviewDialog
            // 
            this.lineupPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.lineupPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.lineupPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.lineupPrintPreviewDialog.Document = this.lineupPrintDocument;
            this.lineupPrintPreviewDialog.Enabled = true;
            this.lineupPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("lineupPrintPreviewDialog.Icon")));
            this.lineupPrintPreviewDialog.Name = "lineupPrintPreviewDialog";
            this.lineupPrintPreviewDialog.Visible = false;
            // 
            // lineupPrintDocument
            // 
            this.lineupPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.lineupPrintDocument_PrintPage);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::AlignementJoueursForm.Properties.Resources.TitanLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(158, 41);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(137, 85);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // AlignementJoueursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 701);
            this.Controls.Add(this.rechercheGroupBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.listeLabel);
            this.Controls.Add(this.lineupRichTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.lineupToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlignementJoueursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alignement des joueurs";
            this.Load += new System.EventHandler(this.AlignementJoueursForm_Load);
            this.lineupToolStrip.ResumeLayout(false);
            this.lineupToolStrip.PerformLayout();
            this.rechercheGroupBox.ResumeLayout(false);
            this.rechercheGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip lineupToolStrip;
        private System.Windows.Forms.ToolStripComboBox fontToolStripComboBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.RichTextBox lineupRichTextBox;
        private System.Windows.Forms.Label listeLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox rechercheGroupBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PrintPreviewDialog lineupPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument lineupPrintDocument;
    }
}

