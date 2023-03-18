namespace Aplikacja
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.labelHomeTelefon2 = new System.Windows.Forms.Label();
            this.labelHomeAutor2 = new System.Windows.Forms.Label();
            this.linkLabelHomeEmail = new System.Windows.Forms.LinkLabel();
            this.labelHomeKomentarz = new System.Windows.Forms.Label();
            this.labelHomeTelefon = new System.Windows.Forms.Label();
            this.labelHomeEmail = new System.Windows.Forms.Label();
            this.labelHomeAutor = new System.Windows.Forms.Label();
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.labelImportPodpis = new System.Windows.Forms.Label();
            this.labelImportPlikNazwa = new System.Windows.Forms.Label();
            this.labelImportPlik = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.labelImportStanowisko = new System.Windows.Forms.Label();
            this.labelImportKod = new System.Windows.Forms.Label();
            this.labelImportImie = new System.Windows.Forms.Label();
            this.labelImportNazwisko = new System.Windows.Forms.Label();
            this.labelImportDzial = new System.Windows.Forms.Label();
            this.comboBoxImportStanowisko = new System.Windows.Forms.ComboBox();
            this.comboBoxImportKod = new System.Windows.Forms.ComboBox();
            this.comboBoxImportImie = new System.Windows.Forms.ComboBox();
            this.comboBoxImportNazwisko = new System.Windows.Forms.ComboBox();
            this.comboBoxImportDzial = new System.Windows.Forms.ComboBox();
            this.buttonLoadExcel = new System.Windows.Forms.Button();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.labelEksportPodpis = new System.Windows.Forms.Label();
            this.buttonExportCsv = new System.Windows.Forms.Button();
            this.buttonExportXml = new System.Windows.Forms.Button();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.buttonDatabasePath = new System.Windows.Forms.Button();
            this.labelDatabasePath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOpcjePodpis = new System.Windows.Forms.Label();
            this.buttonCreateDatabase = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHome);
            this.tabControl.Controls.Add(this.tabPageImport);
            this.tabControl.Controls.Add(this.tabPageExport);
            this.tabControl.Controls.Add(this.tabPageOptions);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(240, 226);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.labelHomeTelefon2);
            this.tabPageHome.Controls.Add(this.labelHomeAutor2);
            this.tabPageHome.Controls.Add(this.linkLabelHomeEmail);
            this.tabPageHome.Controls.Add(this.labelHomeKomentarz);
            this.tabPageHome.Controls.Add(this.labelHomeTelefon);
            this.tabPageHome.Controls.Add(this.labelHomeEmail);
            this.tabPageHome.Controls.Add(this.labelHomeAutor);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(232, 200);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // labelHomeTelefon2
            // 
            this.labelHomeTelefon2.AutoSize = true;
            this.labelHomeTelefon2.Location = new System.Drawing.Point(58, 60);
            this.labelHomeTelefon2.Name = "labelHomeTelefon2";
            this.labelHomeTelefon2.Size = new System.Drawing.Size(67, 13);
            this.labelHomeTelefon2.TabIndex = 9;
            this.labelHomeTelefon2.Text = "539 682 649";
            // 
            // labelHomeAutor2
            // 
            this.labelHomeAutor2.AutoSize = true;
            this.labelHomeAutor2.Location = new System.Drawing.Point(58, 6);
            this.labelHomeAutor2.Name = "labelHomeAutor2";
            this.labelHomeAutor2.Size = new System.Drawing.Size(102, 13);
            this.labelHomeAutor2.TabIndex = 8;
            this.labelHomeAutor2.Text = "Dominik Karczewski";
            // 
            // linkLabelHomeEmail
            // 
            this.linkLabelHomeEmail.AutoSize = true;
            this.linkLabelHomeEmail.Location = new System.Drawing.Point(58, 34);
            this.linkLabelHomeEmail.Name = "linkLabelHomeEmail";
            this.linkLabelHomeEmail.Size = new System.Drawing.Size(141, 13);
            this.linkLabelHomeEmail.TabIndex = 7;
            this.linkLabelHomeEmail.TabStop = true;
            this.linkLabelHomeEmail.Text = "dom.karczewski@gmail.com";
            this.linkLabelHomeEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMail_LinkClicked);
            // 
            // labelHomeKomentarz
            // 
            this.labelHomeKomentarz.AutoSize = true;
            this.labelHomeKomentarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHomeKomentarz.Location = new System.Drawing.Point(7, 79);
            this.labelHomeKomentarz.Name = "labelHomeKomentarz";
            this.labelHomeKomentarz.Size = new System.Drawing.Size(216, 117);
            this.labelHomeKomentarz.TabIndex = 5;
            this.labelHomeKomentarz.Text = resources.GetString("labelHomeKomentarz.Text");
            // 
            // labelHomeTelefon
            // 
            this.labelHomeTelefon.AutoSize = true;
            this.labelHomeTelefon.Location = new System.Drawing.Point(6, 60);
            this.labelHomeTelefon.Name = "labelHomeTelefon";
            this.labelHomeTelefon.Size = new System.Drawing.Size(46, 13);
            this.labelHomeTelefon.TabIndex = 4;
            this.labelHomeTelefon.Text = "Telefon:";
            // 
            // labelHomeEmail
            // 
            this.labelHomeEmail.AutoSize = true;
            this.labelHomeEmail.Location = new System.Drawing.Point(6, 34);
            this.labelHomeEmail.Name = "labelHomeEmail";
            this.labelHomeEmail.Size = new System.Drawing.Size(35, 13);
            this.labelHomeEmail.TabIndex = 3;
            this.labelHomeEmail.Text = "Email:";
            // 
            // labelHomeAutor
            // 
            this.labelHomeAutor.AutoSize = true;
            this.labelHomeAutor.Location = new System.Drawing.Point(6, 6);
            this.labelHomeAutor.Name = "labelHomeAutor";
            this.labelHomeAutor.Size = new System.Drawing.Size(35, 13);
            this.labelHomeAutor.TabIndex = 2;
            this.labelHomeAutor.Text = "Autor:";
            // 
            // tabPageImport
            // 
            this.tabPageImport.Controls.Add(this.labelImportPodpis);
            this.tabPageImport.Controls.Add(this.labelImportPlikNazwa);
            this.tabPageImport.Controls.Add(this.labelImportPlik);
            this.tabPageImport.Controls.Add(this.buttonImport);
            this.tabPageImport.Controls.Add(this.labelImportStanowisko);
            this.tabPageImport.Controls.Add(this.labelImportKod);
            this.tabPageImport.Controls.Add(this.labelImportImie);
            this.tabPageImport.Controls.Add(this.labelImportNazwisko);
            this.tabPageImport.Controls.Add(this.labelImportDzial);
            this.tabPageImport.Controls.Add(this.comboBoxImportStanowisko);
            this.tabPageImport.Controls.Add(this.comboBoxImportKod);
            this.tabPageImport.Controls.Add(this.comboBoxImportImie);
            this.tabPageImport.Controls.Add(this.comboBoxImportNazwisko);
            this.tabPageImport.Controls.Add(this.comboBoxImportDzial);
            this.tabPageImport.Controls.Add(this.buttonLoadExcel);
            this.tabPageImport.Location = new System.Drawing.Point(4, 22);
            this.tabPageImport.Name = "tabPageImport";
            this.tabPageImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImport.Size = new System.Drawing.Size(232, 200);
            this.tabPageImport.TabIndex = 1;
            this.tabPageImport.Text = "Import";
            this.tabPageImport.UseVisualStyleBackColor = true;
            // 
            // labelImportPodpis
            // 
            this.labelImportPodpis.AutoSize = true;
            this.labelImportPodpis.Location = new System.Drawing.Point(130, 187);
            this.labelImportPodpis.Name = "labelImportPodpis";
            this.labelImportPodpis.Size = new System.Drawing.Size(102, 13);
            this.labelImportPodpis.TabIndex = 15;
            this.labelImportPodpis.Text = "Dominik Karczewski";
            // 
            // labelImportPlikNazwa
            // 
            this.labelImportPlikNazwa.AutoSize = true;
            this.labelImportPlikNazwa.Enabled = false;
            this.labelImportPlikNazwa.Location = new System.Drawing.Point(68, 6);
            this.labelImportPlikNazwa.Name = "labelImportPlikNazwa";
            this.labelImportPlikNazwa.Size = new System.Drawing.Size(91, 13);
            this.labelImportPlikNazwa.TabIndex = 14;
            this.labelImportPlikNazwa.Text = "Nie wybrano pliku";
            // 
            // labelImportPlik
            // 
            this.labelImportPlik.AutoSize = true;
            this.labelImportPlik.Location = new System.Drawing.Point(6, 6);
            this.labelImportPlik.Name = "labelImportPlik";
            this.labelImportPlik.Size = new System.Drawing.Size(24, 13);
            this.labelImportPlik.TabIndex = 12;
            this.labelImportPlik.Text = "Plik";
            // 
            // buttonImport
            // 
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(150, 157);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 11;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // labelImportStanowisko
            // 
            this.labelImportStanowisko.AutoSize = true;
            this.labelImportStanowisko.Location = new System.Drawing.Point(6, 133);
            this.labelImportStanowisko.Name = "labelImportStanowisko";
            this.labelImportStanowisko.Size = new System.Drawing.Size(62, 13);
            this.labelImportStanowisko.TabIndex = 10;
            this.labelImportStanowisko.Text = "Stanowisko";
            // 
            // labelImportKod
            // 
            this.labelImportKod.AutoSize = true;
            this.labelImportKod.Location = new System.Drawing.Point(6, 106);
            this.labelImportKod.Name = "labelImportKod";
            this.labelImportKod.Size = new System.Drawing.Size(26, 13);
            this.labelImportKod.TabIndex = 9;
            this.labelImportKod.Text = "Kod";
            // 
            // labelImportImie
            // 
            this.labelImportImie.AutoSize = true;
            this.labelImportImie.Location = new System.Drawing.Point(6, 79);
            this.labelImportImie.Name = "labelImportImie";
            this.labelImportImie.Size = new System.Drawing.Size(26, 13);
            this.labelImportImie.TabIndex = 8;
            this.labelImportImie.Text = "Imię";
            // 
            // labelImportNazwisko
            // 
            this.labelImportNazwisko.AutoSize = true;
            this.labelImportNazwisko.Location = new System.Drawing.Point(6, 52);
            this.labelImportNazwisko.Name = "labelImportNazwisko";
            this.labelImportNazwisko.Size = new System.Drawing.Size(53, 13);
            this.labelImportNazwisko.TabIndex = 7;
            this.labelImportNazwisko.Text = "Nazwisko";
            // 
            // labelImportDzial
            // 
            this.labelImportDzial.AutoSize = true;
            this.labelImportDzial.Location = new System.Drawing.Point(6, 25);
            this.labelImportDzial.Name = "labelImportDzial";
            this.labelImportDzial.Size = new System.Drawing.Size(32, 13);
            this.labelImportDzial.TabIndex = 6;
            this.labelImportDzial.Text = "Dział";
            // 
            // comboBoxImportStanowisko
            // 
            this.comboBoxImportStanowisko.FormattingEnabled = true;
            this.comboBoxImportStanowisko.Location = new System.Drawing.Point(71, 130);
            this.comboBoxImportStanowisko.Name = "comboBoxImportStanowisko";
            this.comboBoxImportStanowisko.Size = new System.Drawing.Size(155, 21);
            this.comboBoxImportStanowisko.TabIndex = 5;
            // 
            // comboBoxImportKod
            // 
            this.comboBoxImportKod.FormattingEnabled = true;
            this.comboBoxImportKod.Location = new System.Drawing.Point(71, 103);
            this.comboBoxImportKod.Name = "comboBoxImportKod";
            this.comboBoxImportKod.Size = new System.Drawing.Size(155, 21);
            this.comboBoxImportKod.TabIndex = 4;
            // 
            // comboBoxImportImie
            // 
            this.comboBoxImportImie.FormattingEnabled = true;
            this.comboBoxImportImie.Location = new System.Drawing.Point(71, 76);
            this.comboBoxImportImie.Name = "comboBoxImportImie";
            this.comboBoxImportImie.Size = new System.Drawing.Size(155, 21);
            this.comboBoxImportImie.TabIndex = 3;
            // 
            // comboBoxImportNazwisko
            // 
            this.comboBoxImportNazwisko.FormattingEnabled = true;
            this.comboBoxImportNazwisko.Location = new System.Drawing.Point(71, 49);
            this.comboBoxImportNazwisko.Name = "comboBoxImportNazwisko";
            this.comboBoxImportNazwisko.Size = new System.Drawing.Size(155, 21);
            this.comboBoxImportNazwisko.TabIndex = 2;
            // 
            // comboBoxImportDzial
            // 
            this.comboBoxImportDzial.FormattingEnabled = true;
            this.comboBoxImportDzial.Location = new System.Drawing.Point(71, 22);
            this.comboBoxImportDzial.Name = "comboBoxImportDzial";
            this.comboBoxImportDzial.Size = new System.Drawing.Size(155, 21);
            this.comboBoxImportDzial.TabIndex = 1;
            // 
            // buttonLoadExcel
            // 
            this.buttonLoadExcel.Location = new System.Drawing.Point(9, 157);
            this.buttonLoadExcel.Name = "buttonLoadExcel";
            this.buttonLoadExcel.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadExcel.TabIndex = 0;
            this.buttonLoadExcel.Text = "Wczytaj plik";
            this.buttonLoadExcel.UseVisualStyleBackColor = true;
            this.buttonLoadExcel.Click += new System.EventHandler(this.buttonLoadExcel_Click);
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.labelEksportPodpis);
            this.tabPageExport.Controls.Add(this.buttonExportCsv);
            this.tabPageExport.Controls.Add(this.buttonExportXml);
            this.tabPageExport.Location = new System.Drawing.Point(4, 22);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(232, 200);
            this.tabPageExport.TabIndex = 2;
            this.tabPageExport.Text = "Eksport";
            this.tabPageExport.UseVisualStyleBackColor = true;
            // 
            // labelEksportPodpis
            // 
            this.labelEksportPodpis.AutoSize = true;
            this.labelEksportPodpis.Location = new System.Drawing.Point(130, 187);
            this.labelEksportPodpis.Name = "labelEksportPodpis";
            this.labelEksportPodpis.Size = new System.Drawing.Size(102, 13);
            this.labelEksportPodpis.TabIndex = 4;
            this.labelEksportPodpis.Text = "Dominik Karczewski";
            // 
            // buttonExportCsv
            // 
            this.buttonExportCsv.Location = new System.Drawing.Point(7, 58);
            this.buttonExportCsv.Name = "buttonExportCsv";
            this.buttonExportCsv.Size = new System.Drawing.Size(218, 46);
            this.buttonExportCsv.TabIndex = 3;
            this.buttonExportCsv.Text = "Eksport do pliku CSV";
            this.buttonExportCsv.UseVisualStyleBackColor = true;
            this.buttonExportCsv.Click += new System.EventHandler(this.buttonExportCsv_Click);
            // 
            // buttonExportXml
            // 
            this.buttonExportXml.Location = new System.Drawing.Point(7, 6);
            this.buttonExportXml.Name = "buttonExportXml";
            this.buttonExportXml.Size = new System.Drawing.Size(218, 46);
            this.buttonExportXml.TabIndex = 2;
            this.buttonExportXml.Text = "Eksport do pliku XML";
            this.buttonExportXml.UseVisualStyleBackColor = true;
            this.buttonExportXml.Click += new System.EventHandler(this.buttonExportXml_Click);
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.buttonDatabasePath);
            this.tabPageOptions.Controls.Add(this.labelDatabasePath);
            this.tabPageOptions.Controls.Add(this.label5);
            this.tabPageOptions.Controls.Add(this.labelOpcjePodpis);
            this.tabPageOptions.Controls.Add(this.buttonCreateDatabase);
            this.tabPageOptions.Controls.Add(this.buttonDrop);
            this.tabPageOptions.Controls.Add(this.textBoxDatabase);
            this.tabPageOptions.Controls.Add(this.textBoxPassword);
            this.tabPageOptions.Controls.Add(this.textBoxLogin);
            this.tabPageOptions.Controls.Add(this.textBoxServer);
            this.tabPageOptions.Controls.Add(this.label4);
            this.tabPageOptions.Controls.Add(this.label3);
            this.tabPageOptions.Controls.Add(this.label2);
            this.tabPageOptions.Controls.Add(this.label1);
            this.tabPageOptions.Controls.Add(this.buttonCheck);
            this.tabPageOptions.Controls.Add(this.buttonClean);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(232, 200);
            this.tabPageOptions.TabIndex = 3;
            this.tabPageOptions.Text = "Opcje";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // buttonDatabasePath
            // 
            this.buttonDatabasePath.Location = new System.Drawing.Point(154, 114);
            this.buttonDatabasePath.Name = "buttonDatabasePath";
            this.buttonDatabasePath.Size = new System.Drawing.Size(74, 26);
            this.buttonDatabasePath.TabIndex = 30;
            this.buttonDatabasePath.Text = "Wybierz";
            this.buttonDatabasePath.UseVisualStyleBackColor = true;
            this.buttonDatabasePath.Click += new System.EventHandler(this.buttonDatabasePath_Click);
            // 
            // labelDatabasePath
            // 
            this.labelDatabasePath.AutoSize = true;
            this.labelDatabasePath.Enabled = false;
            this.labelDatabasePath.Location = new System.Drawing.Point(7, 127);
            this.labelDatabasePath.Name = "labelDatabasePath";
            this.labelDatabasePath.Size = new System.Drawing.Size(84, 13);
            this.labelDatabasePath.TabIndex = 29;
            this.labelDatabasePath.Text = "Wybierz ścieżkę";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Folder plików baz danych";
            // 
            // labelOpcjePodpis
            // 
            this.labelOpcjePodpis.AutoSize = true;
            this.labelOpcjePodpis.Location = new System.Drawing.Point(130, 187);
            this.labelOpcjePodpis.Name = "labelOpcjePodpis";
            this.labelOpcjePodpis.Size = new System.Drawing.Size(102, 13);
            this.labelOpcjePodpis.TabIndex = 27;
            this.labelOpcjePodpis.Text = "Dominik Karczewski";
            // 
            // buttonCreateDatabase
            // 
            this.buttonCreateDatabase.Enabled = false;
            this.buttonCreateDatabase.Location = new System.Drawing.Point(79, 151);
            this.buttonCreateDatabase.Name = "buttonCreateDatabase";
            this.buttonCreateDatabase.Size = new System.Drawing.Size(74, 20);
            this.buttonCreateDatabase.TabIndex = 26;
            this.buttonCreateDatabase.Text = "Utwórz bazę";
            this.buttonCreateDatabase.UseVisualStyleBackColor = true;
            this.buttonCreateDatabase.Click += new System.EventHandler(this.buttonCreateDatabase_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(154, 151);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(74, 20);
            this.buttonDrop.TabIndex = 25;
            this.buttonDrop.Text = "Usuń bazę";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(47, 88);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(181, 20);
            this.textBoxDatabase.TabIndex = 23;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(47, 60);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(181, 20);
            this.textBoxPassword.TabIndex = 22;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(47, 34);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(181, 20);
            this.textBoxLogin.TabIndex = 21;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(47, 6);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(181, 20);
            this.textBoxServer.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Baza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Serwer";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(4, 151);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(74, 20);
            this.buttonCheck.TabIndex = 14;
            this.buttonCheck.Text = "Sprawdź";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(4, 177);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(74, 20);
            this.buttonClean.TabIndex = 13;
            this.buttonClean.Text = "Wyczyść";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 229);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Dominik Karczewski";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageImport.ResumeLayout(false);
            this.tabPageImport.PerformLayout();
            this.tabPageExport.ResumeLayout(false);
            this.tabPageExport.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageImport;
        private System.Windows.Forms.TabPage tabPageExport;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Button buttonCreateDatabase;
        private System.Windows.Forms.Button buttonLoadExcel;
        private System.Windows.Forms.Label labelImportStanowisko;
        private System.Windows.Forms.Label labelImportKod;
        private System.Windows.Forms.Label labelImportImie;
        private System.Windows.Forms.Label labelImportNazwisko;
        private System.Windows.Forms.Label labelImportDzial;
        private System.Windows.Forms.ComboBox comboBoxImportStanowisko;
        private System.Windows.Forms.ComboBox comboBoxImportKod;
        private System.Windows.Forms.ComboBox comboBoxImportImie;
        private System.Windows.Forms.ComboBox comboBoxImportNazwisko;
        private System.Windows.Forms.ComboBox comboBoxImportDzial;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExportXml;
        private System.Windows.Forms.Button buttonExportCsv;
        private System.Windows.Forms.Label labelImportPlik;
        private System.Windows.Forms.Label labelImportPlikNazwa;
        private System.Windows.Forms.Label labelHomeTelefon;
        private System.Windows.Forms.Label labelHomeEmail;
        private System.Windows.Forms.Label labelHomeAutor;
        private System.Windows.Forms.Label labelImportPodpis;
        private System.Windows.Forms.Label labelEksportPodpis;
        private System.Windows.Forms.Label labelOpcjePodpis;
        private System.Windows.Forms.Label labelHomeKomentarz;
        private System.Windows.Forms.LinkLabel linkLabelHomeEmail;
        private System.Windows.Forms.Label labelHomeTelefon2;
        private System.Windows.Forms.Label labelHomeAutor2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDatabasePath;
        private System.Windows.Forms.Label labelDatabasePath;
    }
}

