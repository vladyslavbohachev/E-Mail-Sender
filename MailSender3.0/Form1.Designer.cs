namespace MailSender3._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmd_send = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuenKundenAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugreportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_getFolder = new System.Windows.Forms.Button();
            this.cmd_getFile = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button16 = new System.Windows.Forms.Button();
            this.txt_send_To = new System.Windows.Forms.TextBox();
            this.txt_send_Cc = new System.Windows.Forms.TextBox();
            this.txt_attchment = new System.Windows.Forms.TextBox();
            this.txt_send_Betreff = new System.Windows.Forms.TextBox();
            this.cmd_sendTo = new System.Windows.Forms.Button();
            this.cmd_sendCc = new System.Windows.Forms.Button();
            this.cmd_txt_getFolder = new System.Windows.Forms.Button();
            this.cmd_Betreff = new System.Windows.Forms.Button();
            this.txt_mailBody = new System.Windows.Forms.RichTextBox();
            this.cmd_getOutlookSignature = new System.Windows.Forms.Button();
            this.lbl_warn = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_send
            // 
            this.cmd_send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_send.BackgroundImage")));
            this.cmd_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmd_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_send.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_send.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmd_send.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_send.Location = new System.Drawing.Point(12, 26);
            this.cmd_send.Name = "cmd_send";
            this.cmd_send.Size = new System.Drawing.Size(95, 123);
            this.cmd_send.TabIndex = 5;
            this.cmd_send.Text = "Senden";
            this.cmd_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmd_send.UseVisualStyleBackColor = true;
            this.cmd_send.Click += new System.EventHandler(this.cmd_send_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.kundenToolStripMenuItem,
            this.überToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleAnzeigenToolStripMenuItem,
            this.neuenKundenAnlegenToolStripMenuItem});
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kundenToolStripMenuItem.Text = "Kunden";
            // 
            // alleAnzeigenToolStripMenuItem
            // 
            this.alleAnzeigenToolStripMenuItem.Name = "alleAnzeigenToolStripMenuItem";
            this.alleAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.alleAnzeigenToolStripMenuItem.Text = "Alle Anzeigen";
            // 
            // neuenKundenAnlegenToolStripMenuItem
            // 
            this.neuenKundenAnlegenToolStripMenuItem.Name = "neuenKundenAnlegenToolStripMenuItem";
            this.neuenKundenAnlegenToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.neuenKundenAnlegenToolStripMenuItem.Text = "Neuen Kunden Anlegen";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentationToolStripMenuItem,
            this.bugreportToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // dokumentationToolStripMenuItem
            // 
            this.dokumentationToolStripMenuItem.Name = "dokumentationToolStripMenuItem";
            this.dokumentationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dokumentationToolStripMenuItem.Text = "Dokumentation";
            // 
            // bugreportToolStripMenuItem
            // 
            this.bugreportToolStripMenuItem.Name = "bugreportToolStripMenuItem";
            this.bugreportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bugreportToolStripMenuItem.Text = "Bug Report";
            this.bugreportToolStripMenuItem.Click += new System.EventHandler(this.bugreportToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // cmd_getFolder
            // 
            this.cmd_getFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_getFolder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_getFolder.ForeColor = System.Drawing.SystemColors.Window;
            this.cmd_getFolder.Image = global::MailSender3._0.Properties.Resources.folder_plus;
            this.cmd_getFolder.Location = new System.Drawing.Point(837, 87);
            this.cmd_getFolder.Name = "cmd_getFolder";
            this.cmd_getFolder.Size = new System.Drawing.Size(35, 35);
            this.cmd_getFolder.TabIndex = 4;
            this.cmd_getFolder.TabStop = false;
            this.cmd_getFolder.UseVisualStyleBackColor = true;
            this.cmd_getFolder.Click += new System.EventHandler(this.cmd_getFolder_Click);
            // 
            // cmd_getFile
            // 
            this.cmd_getFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_getFile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_getFile.ForeColor = System.Drawing.SystemColors.Window;
            this.cmd_getFile.Image = global::MailSender3._0.Properties.Resources.paperclip;
            this.cmd_getFile.Location = new System.Drawing.Point(796, 87);
            this.cmd_getFile.Name = "cmd_getFile";
            this.cmd_getFile.Size = new System.Drawing.Size(35, 35);
            this.cmd_getFile.TabIndex = 6;
            this.cmd_getFile.TabStop = false;
            this.cmd_getFile.UseVisualStyleBackColor = true;
            this.cmd_getFile.Click += new System.EventHandler(this.cmd_getFile_Click);
            // 
            // button9
            // 
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.Window;
            this.button9.Image = global::MailSender3._0.Properties.Resources.align_justify;
            this.button9.Location = new System.Drawing.Point(638, 160);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 26);
            this.button9.TabIndex = 9;
            this.button9.TabStop = false;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.Window;
            this.button10.Image = global::MailSender3._0.Properties.Resources.align_right;
            this.button10.Location = new System.Drawing.Point(597, 160);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 26);
            this.button10.TabIndex = 10;
            this.button10.TabStop = false;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.SystemColors.Window;
            this.button11.Image = global::MailSender3._0.Properties.Resources.align_center;
            this.button11.Location = new System.Drawing.Point(556, 160);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 26);
            this.button11.TabIndex = 10;
            this.button11.TabStop = false;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.SystemColors.Window;
            this.button12.Image = global::MailSender3._0.Properties.Resources.align_left;
            this.button12.Location = new System.Drawing.Point(515, 160);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 26);
            this.button12.TabIndex = 10;
            this.button12.TabStop = false;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.SystemColors.Window;
            this.button13.Image = global::MailSender3._0.Properties.Resources.italic;
            this.button13.Location = new System.Drawing.Point(450, 160);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 26);
            this.button13.TabIndex = 10;
            this.button13.TabStop = false;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.SystemColors.Window;
            this.button14.Image = global::MailSender3._0.Properties.Resources.underline;
            this.button14.Location = new System.Drawing.Point(409, 160);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 26);
            this.button14.TabIndex = 10;
            this.button14.TabStop = false;
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.SystemColors.Window;
            this.button15.Image = global::MailSender3._0.Properties.Resources.bold;
            this.button15.Location = new System.Drawing.Point(368, 160);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 26);
            this.button15.TabIndex = 10;
            this.button15.TabStop = false;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 26);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(233, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 26);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.TabStop = false;
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.SystemColors.Window;
            this.button16.Image = global::MailSender3._0.Properties.Resources.droplet;
            this.button16.Location = new System.Drawing.Point(309, 160);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 26);
            this.button16.TabIndex = 13;
            this.button16.TabStop = false;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // txt_send_To
            // 
            this.txt_send_To.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_send_To.Location = new System.Drawing.Point(233, 28);
            this.txt_send_To.Name = "txt_send_To";
            this.txt_send_To.Size = new System.Drawing.Size(639, 26);
            this.txt_send_To.TabIndex = 0;
            // 
            // txt_send_Cc
            // 
            this.txt_send_Cc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_send_Cc.Location = new System.Drawing.Point(233, 60);
            this.txt_send_Cc.Name = "txt_send_Cc";
            this.txt_send_Cc.Size = new System.Drawing.Size(639, 26);
            this.txt_send_Cc.TabIndex = 1;
            // 
            // txt_attchment
            // 
            this.txt_attchment.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_attchment.Location = new System.Drawing.Point(233, 93);
            this.txt_attchment.Name = "txt_attchment";
            this.txt_attchment.Size = new System.Drawing.Size(557, 26);
            this.txt_attchment.TabIndex = 2;
            this.txt_attchment.TextChanged += new System.EventHandler(this.txt_attchment_TextChanged);
            // 
            // txt_send_Betreff
            // 
            this.txt_send_Betreff.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_send_Betreff.Location = new System.Drawing.Point(233, 124);
            this.txt_send_Betreff.Name = "txt_send_Betreff";
            this.txt_send_Betreff.Size = new System.Drawing.Size(639, 26);
            this.txt_send_Betreff.TabIndex = 3;
            // 
            // cmd_sendTo
            // 
            this.cmd_sendTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_sendTo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_sendTo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmd_sendTo.Location = new System.Drawing.Point(113, 27);
            this.cmd_sendTo.Name = "cmd_sendTo";
            this.cmd_sendTo.Size = new System.Drawing.Size(114, 27);
            this.cmd_sendTo.TabIndex = 0;
            this.cmd_sendTo.TabStop = false;
            this.cmd_sendTo.Text = "An";
            this.cmd_sendTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_sendTo.UseMnemonic = false;
            this.cmd_sendTo.UseVisualStyleBackColor = false;
            this.cmd_sendTo.Click += new System.EventHandler(this.cmd_sendTo_Click);
            // 
            // cmd_sendCc
            // 
            this.cmd_sendCc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_sendCc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_sendCc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmd_sendCc.Location = new System.Drawing.Point(113, 59);
            this.cmd_sendCc.Name = "cmd_sendCc";
            this.cmd_sendCc.Size = new System.Drawing.Size(114, 27);
            this.cmd_sendCc.TabIndex = 16;
            this.cmd_sendCc.TabStop = false;
            this.cmd_sendCc.Text = "Cc";
            this.cmd_sendCc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_sendCc.UseVisualStyleBackColor = true;
            this.cmd_sendCc.Click += new System.EventHandler(this.cmd_sendCc_Click);
            // 
            // cmd_txt_getFolder
            // 
            this.cmd_txt_getFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_txt_getFolder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_txt_getFolder.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmd_txt_getFolder.Location = new System.Drawing.Point(113, 91);
            this.cmd_txt_getFolder.Name = "cmd_txt_getFolder";
            this.cmd_txt_getFolder.Size = new System.Drawing.Size(114, 27);
            this.cmd_txt_getFolder.TabIndex = 16;
            this.cmd_txt_getFolder.TabStop = false;
            this.cmd_txt_getFolder.Text = "Anhang";
            this.cmd_txt_getFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_txt_getFolder.UseVisualStyleBackColor = true;
            this.cmd_txt_getFolder.Click += new System.EventHandler(this.cmd_txt_getFolder_Click);
            // 
            // cmd_Betreff
            // 
            this.cmd_Betreff.Enabled = false;
            this.cmd_Betreff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Betreff.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_Betreff.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmd_Betreff.Location = new System.Drawing.Point(113, 123);
            this.cmd_Betreff.Name = "cmd_Betreff";
            this.cmd_Betreff.Size = new System.Drawing.Size(114, 27);
            this.cmd_Betreff.TabIndex = 16;
            this.cmd_Betreff.TabStop = false;
            this.cmd_Betreff.Text = "Betreff";
            this.cmd_Betreff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_Betreff.UseVisualStyleBackColor = true;
            // 
            // txt_mailBody
            // 
            this.txt_mailBody.Location = new System.Drawing.Point(12, 193);
            this.txt_mailBody.Name = "txt_mailBody";
            this.txt_mailBody.Size = new System.Drawing.Size(860, 479);
            this.txt_mailBody.TabIndex = 4;
            this.txt_mailBody.Text = "";
            // 
            // cmd_getOutlookSignature
            // 
            this.cmd_getOutlookSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_getOutlookSignature.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_getOutlookSignature.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmd_getOutlookSignature.Location = new System.Drawing.Point(691, 158);
            this.cmd_getOutlookSignature.Name = "cmd_getOutlookSignature";
            this.cmd_getOutlookSignature.Size = new System.Drawing.Size(181, 30);
            this.cmd_getOutlookSignature.TabIndex = 18;
            this.cmd_getOutlookSignature.TabStop = false;
            this.cmd_getOutlookSignature.Text = "Outlook Signatur einfügen";
            this.cmd_getOutlookSignature.UseVisualStyleBackColor = true;
            this.cmd_getOutlookSignature.Click += new System.EventHandler(this.cmd_getOutlookSignature_Click);
            // 
            // lbl_warn
            // 
            this.lbl_warn.AutoSize = true;
            this.lbl_warn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_warn.ForeColor = System.Drawing.Color.Red;
            this.lbl_warn.Location = new System.Drawing.Point(42, 675);
            this.lbl_warn.Name = "lbl_warn";
            this.lbl_warn.Size = new System.Drawing.Size(0, 18);
            this.lbl_warn.TabIndex = 19;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(14, 677);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(10, 15);
            this.lbl_status.TabIndex = 20;
            this.lbl_status.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_warn);
            this.Controls.Add(this.cmd_getOutlookSignature);
            this.Controls.Add(this.txt_mailBody);
            this.Controls.Add(this.cmd_Betreff);
            this.Controls.Add(this.cmd_txt_getFolder);
            this.Controls.Add(this.cmd_sendCc);
            this.Controls.Add(this.cmd_sendTo);
            this.Controls.Add(this.txt_send_Betreff);
            this.Controls.Add(this.txt_attchment);
            this.Controls.Add(this.txt_send_Cc);
            this.Controls.Add(this.txt_send_To);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.cmd_getFile);
            this.Controls.Add(this.cmd_getFolder);
            this.Controls.Add(this.cmd_send);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 750);
            this.MinimumSize = new System.Drawing.Size(900, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAT v.3.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmd_send;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private Button cmd_getFolder;
        private Button cmd_getFile;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button16;
        private TextBox txt_send_To;
        private TextBox txt_send_Cc;
        private TextBox txt_attchment;
        private TextBox txt_send_Betreff;
        private Button cmd_sendTo;
        private Button cmd_sendCc;
        private Button cmd_txt_getFolder;
        private Button cmd_Betreff;
        private RichTextBox txt_mailBody;
        private ToolStripMenuItem einstellungenToolStripMenuItem;
        private ToolStripMenuItem schließenToolStripMenuItem;
        private ToolStripMenuItem kundenToolStripMenuItem;
        private ToolStripMenuItem alleAnzeigenToolStripMenuItem;
        private ToolStripMenuItem neuenKundenAnlegenToolStripMenuItem;
        private ToolStripMenuItem überToolStripMenuItem;
        private ToolStripMenuItem dokumentationToolStripMenuItem;
        private ToolStripMenuItem bugreportToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private Button cmd_getOutlookSignature;
        private Label lbl_warn;
        private Label lbl_status;
    }
}