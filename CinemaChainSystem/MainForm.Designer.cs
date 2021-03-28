
namespace CinemaChainSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.headerGrpBox = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.loginTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.srchGrpBox = new System.Windows.Forms.GroupBox();
            this.atrbChekListBox = new System.Windows.Forms.CheckedListBox();
            this.splitterCheckList = new System.Windows.Forms.Splitter();
            this.admSrchPanel = new System.Windows.Forms.Panel();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueComboBox = new System.Windows.Forms.ComboBox();
            this.atrbLabel = new System.Windows.Forms.Label();
            this.atrbComboBox = new System.Windows.Forms.ComboBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.labelAdminSearch = new System.Windows.Forms.Label();
            this.splitterAdmSearch = new System.Windows.Forms.Splitter();
            this.splitterCashierSearch = new System.Windows.Forms.Splitter();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.sessToLabel = new System.Windows.Forms.Label();
            this.sessToComboBox = new System.Windows.Forms.ComboBox();
            this.filmLabel = new System.Windows.Forms.Label();
            this.filmComboBox = new System.Windows.Forms.ComboBox();
            this.sessFromLabel = new System.Windows.Forms.Label();
            this.sessFromComboBox = new System.Windows.Forms.ComboBox();
            this.cinemaLabel = new System.Windows.Forms.Label();
            this.cinemaComboBox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.headerSplitter = new System.Windows.Forms.Splitter();
            this.FilmInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.sessHoursLabel = new System.Windows.Forms.Label();
            this.sessDateLabel = new System.Windows.Forms.Label();
            this.rubsLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.ticketActionBtn = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.posterPanel = new System.Windows.Forms.Panel();
            this.posterPicBox = new System.Windows.Forms.PictureBox();
            this.splitterFilmInfo = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.srchGrpBox.SuspendLayout();
            this.admSrchPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.FilmInfoGrpBox.SuspendLayout();
            this.posterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerGrpBox
            // 
            this.headerGrpBox.BackColor = System.Drawing.Color.White;
            this.headerGrpBox.Controls.Add(this.exitBtn);
            this.headerGrpBox.Controls.Add(this.enterBtn);
            this.headerGrpBox.Controls.Add(this.passwordTxtBox);
            this.headerGrpBox.Controls.Add(this.loginTxtBox);
            this.headerGrpBox.Controls.Add(this.passwordLabel);
            this.headerGrpBox.Controls.Add(this.loginLabel);
            this.headerGrpBox.Controls.Add(this.userLabel);
            this.headerGrpBox.Controls.Add(this.headerLabel);
            this.headerGrpBox.Controls.Add(this.logoPicBox);
            this.headerGrpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerGrpBox.Location = new System.Drawing.Point(0, 0);
            this.headerGrpBox.Name = "headerGrpBox";
            this.headerGrpBox.Size = new System.Drawing.Size(1275, 83);
            this.headerGrpBox.TabIndex = 0;
            this.headerGrpBox.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Enabled = false;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(1197, 51);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(68, 24);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enterBtn.Font = new System.Drawing.Font("Arial Narrow", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterBtn.Location = new System.Drawing.Point(1197, 19);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(68, 24);
            this.enterBtn.TabIndex = 7;
            this.enterBtn.Text = "Войти";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxtBox.Location = new System.Drawing.Point(1054, 54);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(126, 23);
            this.passwordTxtBox.TabIndex = 6;
            // 
            // loginTxtBox
            // 
            this.loginTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTxtBox.Location = new System.Drawing.Point(1054, 20);
            this.loginTxtBox.Name = "loginTxtBox";
            this.loginTxtBox.Size = new System.Drawing.Size(126, 23);
            this.loginTxtBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(987, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 22);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Пароль:";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(987, 19);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 22);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин:";
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(774, 36);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(152, 22);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Пользователь: кассир";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(78, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(220, 60);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Моё кино";
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.SlateBlue;
            this.logoPicBox.Image = global::CinemaChainSystem.Properties.Resources.logoHeader;
            this.logoPicBox.Location = new System.Drawing.Point(6, 15);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(66, 65);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            // 
            // srchGrpBox
            // 
            this.srchGrpBox.BackColor = System.Drawing.Color.White;
            this.srchGrpBox.Controls.Add(this.atrbChekListBox);
            this.srchGrpBox.Controls.Add(this.splitterCheckList);
            this.srchGrpBox.Controls.Add(this.admSrchPanel);
            this.srchGrpBox.Controls.Add(this.splitterAdmSearch);
            this.srchGrpBox.Controls.Add(this.splitterCashierSearch);
            this.srchGrpBox.Controls.Add(this.searchPanel);
            this.srchGrpBox.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.srchGrpBox.Location = new System.Drawing.Point(6, 123);
            this.srchGrpBox.Name = "srchGrpBox";
            this.srchGrpBox.Size = new System.Drawing.Size(722, 326);
            this.srchGrpBox.TabIndex = 2;
            this.srchGrpBox.TabStop = false;
            this.srchGrpBox.Text = "Параметры поиска:";
            // 
            // atrbChekListBox
            // 
            this.atrbChekListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atrbChekListBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.atrbChekListBox.FormattingEnabled = true;
            this.atrbChekListBox.Location = new System.Drawing.Point(546, 155);
            this.atrbChekListBox.Name = "atrbChekListBox";
            this.atrbChekListBox.Size = new System.Drawing.Size(173, 165);
            this.atrbChekListBox.TabIndex = 18;
            this.atrbChekListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.atrbChekListBox_ItemCheck);
            // 
            // splitterCheckList
            // 
            this.splitterCheckList.BackColor = System.Drawing.Color.Gray;
            this.splitterCheckList.Location = new System.Drawing.Point(543, 155);
            this.splitterCheckList.Name = "splitterCheckList";
            this.splitterCheckList.Size = new System.Drawing.Size(3, 165);
            this.splitterCheckList.TabIndex = 17;
            this.splitterCheckList.TabStop = false;
            // 
            // admSrchPanel
            // 
            this.admSrchPanel.Controls.Add(this.valueLabel);
            this.admSrchPanel.Controls.Add(this.valueComboBox);
            this.admSrchPanel.Controls.Add(this.atrbLabel);
            this.admSrchPanel.Controls.Add(this.atrbComboBox);
            this.admSrchPanel.Controls.Add(this.modelLabel);
            this.admSrchPanel.Controls.Add(this.modelComboBox);
            this.admSrchPanel.Controls.Add(this.labelAdminSearch);
            this.admSrchPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.admSrchPanel.Enabled = false;
            this.admSrchPanel.Location = new System.Drawing.Point(3, 155);
            this.admSrchPanel.Name = "admSrchPanel";
            this.admSrchPanel.Size = new System.Drawing.Size(540, 165);
            this.admSrchPanel.TabIndex = 16;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueLabel.Location = new System.Drawing.Point(50, 117);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(77, 22);
            this.valueLabel.TabIndex = 20;
            this.valueLabel.Text = "Значение:";
            // 
            // valueComboBox
            // 
            this.valueComboBox.Enabled = false;
            this.valueComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueComboBox.FormattingEnabled = true;
            this.valueComboBox.Location = new System.Drawing.Point(138, 114);
            this.valueComboBox.Name = "valueComboBox";
            this.valueComboBox.Size = new System.Drawing.Size(176, 28);
            this.valueComboBox.Sorted = true;
            this.valueComboBox.TabIndex = 19;
            this.valueComboBox.SelectedIndexChanged += new System.EventHandler(this.valueComboBox_SelectedIndexChanged);
            this.valueComboBox.TextChanged += new System.EventHandler(this.valueComboBox_TextChanged);
            // 
            // atrbLabel
            // 
            this.atrbLabel.AutoSize = true;
            this.atrbLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.atrbLabel.Location = new System.Drawing.Point(3, 83);
            this.atrbLabel.Name = "atrbLabel";
            this.atrbLabel.Size = new System.Drawing.Size(129, 22);
            this.atrbLabel.TabIndex = 18;
            this.atrbLabel.Text = "Атрибут cущности:";
            // 
            // atrbComboBox
            // 
            this.atrbComboBox.Enabled = false;
            this.atrbComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.atrbComboBox.FormattingEnabled = true;
            this.atrbComboBox.Location = new System.Drawing.Point(138, 80);
            this.atrbComboBox.Name = "atrbComboBox";
            this.atrbComboBox.Size = new System.Drawing.Size(176, 28);
            this.atrbComboBox.TabIndex = 17;
            this.atrbComboBox.SelectedIndexChanged += new System.EventHandler(this.atrbComboBox_SelectedIndexChanged);
            this.atrbComboBox.TextChanged += new System.EventHandler(this.atrbComboBox_TextChanged);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelLabel.Location = new System.Drawing.Point(50, 47);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(77, 22);
            this.modelLabel.TabIndex = 16;
            this.modelLabel.Text = "Сущность:";
            // 
            // modelComboBox
            // 
            this.modelComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Items.AddRange(new object[] {
            "Фильм",
            "Сеанс",
            "Билет",
            "Зал",
            "Кинотеатр",
            "Город",
            "Рейтинговая система",
            "Место"});
            this.modelComboBox.Location = new System.Drawing.Point(138, 46);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(176, 28);
            this.modelComboBox.TabIndex = 15;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            this.modelComboBox.TextChanged += new System.EventHandler(this.modelComboBox_TextChanged);
            // 
            // labelAdminSearch
            // 
            this.labelAdminSearch.AutoSize = true;
            this.labelAdminSearch.Location = new System.Drawing.Point(6, 11);
            this.labelAdminSearch.Name = "labelAdminSearch";
            this.labelAdminSearch.Size = new System.Drawing.Size(160, 26);
            this.labelAdminSearch.TabIndex = 0;
            this.labelAdminSearch.Text = "Администратор:";
            // 
            // splitterAdmSearch
            // 
            this.splitterAdmSearch.BackColor = System.Drawing.Color.Gray;
            this.splitterAdmSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterAdmSearch.Location = new System.Drawing.Point(3, 320);
            this.splitterAdmSearch.Name = "splitterAdmSearch";
            this.splitterAdmSearch.Size = new System.Drawing.Size(716, 3);
            this.splitterAdmSearch.TabIndex = 15;
            this.splitterAdmSearch.TabStop = false;
            // 
            // splitterCashierSearch
            // 
            this.splitterCashierSearch.BackColor = System.Drawing.Color.Gray;
            this.splitterCashierSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterCashierSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterCashierSearch.Enabled = false;
            this.splitterCashierSearch.Location = new System.Drawing.Point(3, 152);
            this.splitterCashierSearch.Name = "splitterCashierSearch";
            this.splitterCashierSearch.Size = new System.Drawing.Size(716, 3);
            this.splitterCashierSearch.TabIndex = 14;
            this.splitterCashierSearch.TabStop = false;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.sessToLabel);
            this.searchPanel.Controls.Add(this.sessToComboBox);
            this.searchPanel.Controls.Add(this.filmLabel);
            this.searchPanel.Controls.Add(this.filmComboBox);
            this.searchPanel.Controls.Add(this.sessFromLabel);
            this.searchPanel.Controls.Add(this.sessFromComboBox);
            this.searchPanel.Controls.Add(this.cinemaLabel);
            this.searchPanel.Controls.Add(this.cinemaComboBox);
            this.searchPanel.Controls.Add(this.cityLabel);
            this.searchPanel.Controls.Add(this.cityComboBox);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(3, 29);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(716, 123);
            this.searchPanel.TabIndex = 13;
            // 
            // sessToLabel
            // 
            this.sessToLabel.AutoSize = true;
            this.sessToLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessToLabel.Location = new System.Drawing.Point(364, 48);
            this.sessToLabel.Name = "sessToLabel";
            this.sessToLabel.Size = new System.Drawing.Size(85, 22);
            this.sessToLabel.TabIndex = 24;
            this.sessToLabel.Text = "Сеансы по:";
            // 
            // sessToComboBox
            // 
            this.sessToComboBox.Enabled = false;
            this.sessToComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessToComboBox.FormattingEnabled = true;
            this.sessToComboBox.Location = new System.Drawing.Point(455, 45);
            this.sessToComboBox.Name = "sessToComboBox";
            this.sessToComboBox.Size = new System.Drawing.Size(234, 28);
            this.sessToComboBox.Sorted = true;
            this.sessToComboBox.TabIndex = 23;
            this.sessToComboBox.SelectedIndexChanged += new System.EventHandler(this.sessComboBoxes_SelectedIndexChanged);
            this.sessToComboBox.TextChanged += new System.EventHandler(this.sessComboBoxes_TextChanged);
            // 
            // filmLabel
            // 
            this.filmLabel.AutoSize = true;
            this.filmLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmLabel.Location = new System.Drawing.Point(26, 85);
            this.filmLabel.Name = "filmLabel";
            this.filmLabel.Size = new System.Drawing.Size(58, 22);
            this.filmLabel.TabIndex = 22;
            this.filmLabel.Text = "Фильм:";
            // 
            // filmComboBox
            // 
            this.filmComboBox.Enabled = false;
            this.filmComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmComboBox.FormattingEnabled = true;
            this.filmComboBox.Location = new System.Drawing.Point(95, 82);
            this.filmComboBox.Name = "filmComboBox";
            this.filmComboBox.Size = new System.Drawing.Size(202, 28);
            this.filmComboBox.Sorted = true;
            this.filmComboBox.TabIndex = 21;
            this.filmComboBox.SelectedIndexChanged += new System.EventHandler(this.filmComboBox_SelectedIndexChanged);
            this.filmComboBox.TextChanged += new System.EventHandler(this.filmComboBox_TextChanged);
            // 
            // sessFromLabel
            // 
            this.sessFromLabel.AutoSize = true;
            this.sessFromLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessFromLabel.Location = new System.Drawing.Point(373, 14);
            this.sessFromLabel.Name = "sessFromLabel";
            this.sessFromLabel.Size = new System.Drawing.Size(76, 22);
            this.sessFromLabel.TabIndex = 20;
            this.sessFromLabel.Text = "Сеансы с:";
            // 
            // sessFromComboBox
            // 
            this.sessFromComboBox.Enabled = false;
            this.sessFromComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessFromComboBox.FormattingEnabled = true;
            this.sessFromComboBox.Location = new System.Drawing.Point(455, 11);
            this.sessFromComboBox.Name = "sessFromComboBox";
            this.sessFromComboBox.Size = new System.Drawing.Size(234, 28);
            this.sessFromComboBox.Sorted = true;
            this.sessFromComboBox.TabIndex = 19;
            this.sessFromComboBox.SelectedIndexChanged += new System.EventHandler(this.sessComboBoxes_SelectedIndexChanged);
            this.sessFromComboBox.TextChanged += new System.EventHandler(this.sessComboBoxes_TextChanged);
            // 
            // cinemaLabel
            // 
            this.cinemaLabel.AutoSize = true;
            this.cinemaLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaLabel.Location = new System.Drawing.Point(4, 48);
            this.cinemaLabel.Name = "cinemaLabel";
            this.cinemaLabel.Size = new System.Drawing.Size(80, 22);
            this.cinemaLabel.TabIndex = 16;
            this.cinemaLabel.Text = "Кинотеатр:";
            // 
            // cinemaComboBox
            // 
            this.cinemaComboBox.Enabled = false;
            this.cinemaComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaComboBox.FormattingEnabled = true;
            this.cinemaComboBox.Location = new System.Drawing.Point(95, 45);
            this.cinemaComboBox.Name = "cinemaComboBox";
            this.cinemaComboBox.Size = new System.Drawing.Size(202, 28);
            this.cinemaComboBox.Sorted = true;
            this.cinemaComboBox.TabIndex = 15;
            this.cinemaComboBox.SelectedIndexChanged += new System.EventHandler(this.cinemaComboBox_SelectedIndexChanged);
            this.cinemaComboBox.TextChanged += new System.EventHandler(this.cinemaComboBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(31, 11);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(53, 22);
            this.cityLabel.TabIndex = 14;
            this.cityLabel.Text = "Город:";
            // 
            // cityComboBox
            // 
            this.cityComboBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "gf",
            "gf",
            "hnbg"});
            this.cityComboBox.Location = new System.Drawing.Point(95, 11);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(202, 28);
            this.cityComboBox.Sorted = true;
            this.cityComboBox.TabIndex = 13;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            this.cityComboBox.TextChanged += new System.EventHandler(this.cityComboBox_TextChanged);
            // 
            // headerSplitter
            // 
            this.headerSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSplitter.Enabled = false;
            this.headerSplitter.Location = new System.Drawing.Point(0, 83);
            this.headerSplitter.Name = "headerSplitter";
            this.headerSplitter.Size = new System.Drawing.Size(1275, 10);
            this.headerSplitter.TabIndex = 4;
            this.headerSplitter.TabStop = false;
            // 
            // FilmInfoGrpBox
            // 
            this.FilmInfoGrpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmInfoGrpBox.Controls.Add(this.sessHoursLabel);
            this.FilmInfoGrpBox.Controls.Add(this.sessDateLabel);
            this.FilmInfoGrpBox.Controls.Add(this.rubsLabel);
            this.FilmInfoGrpBox.Controls.Add(this.hoursLabel);
            this.FilmInfoGrpBox.Controls.Add(this.priceLabel);
            this.FilmInfoGrpBox.Controls.Add(this.lengthLabel);
            this.FilmInfoGrpBox.Controls.Add(this.filmNameLabel);
            this.FilmInfoGrpBox.Controls.Add(this.ticketActionBtn);
            this.FilmInfoGrpBox.Controls.Add(this.descriptionLabel);
            this.FilmInfoGrpBox.Controls.Add(this.descriptionTxtBox);
            this.FilmInfoGrpBox.Controls.Add(this.posterPanel);
            this.FilmInfoGrpBox.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmInfoGrpBox.Location = new System.Drawing.Point(743, 117);
            this.FilmInfoGrpBox.Name = "FilmInfoGrpBox";
            this.FilmInfoGrpBox.Size = new System.Drawing.Size(523, 638);
            this.FilmInfoGrpBox.TabIndex = 5;
            this.FilmInfoGrpBox.TabStop = false;
            this.FilmInfoGrpBox.Text = "Информация о сеансе";
            // 
            // sessHoursLabel
            // 
            this.sessHoursLabel.AutoSize = true;
            this.sessHoursLabel.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessHoursLabel.Location = new System.Drawing.Point(340, 431);
            this.sessHoursLabel.Name = "sessHoursLabel";
            this.sessHoursLabel.Size = new System.Drawing.Size(143, 21);
            this.sessHoursLabel.TabIndex = 29;
            this.sessHoursLabel.Text = "ЧЧ.ММ. ДД.ММ.ГГГГ";
            // 
            // sessDateLabel
            // 
            this.sessDateLabel.AutoSize = true;
            this.sessDateLabel.Font = new System.Drawing.Font("Impact", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessDateLabel.Location = new System.Drawing.Point(280, 428);
            this.sessDateLabel.Name = "sessDateLabel";
            this.sessDateLabel.Size = new System.Drawing.Size(54, 23);
            this.sessDateLabel.TabIndex = 28;
            this.sessDateLabel.Text = "Дата:";
            // 
            // rubsLabel
            // 
            this.rubsLabel.AutoSize = true;
            this.rubsLabel.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rubsLabel.Location = new System.Drawing.Point(390, 395);
            this.rubsLabel.Name = "rubsLabel";
            this.rubsLabel.Size = new System.Drawing.Size(72, 21);
            this.rubsLabel.TabIndex = 27;
            this.rubsLabel.Text = "руб. коп.";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Impact", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursLabel.Location = new System.Drawing.Point(162, 393);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(65, 23);
            this.hoursLabel.TabIndex = 26;
            this.hoursLabel.Text = "ч. мин.";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Impact", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(280, 393);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(104, 23);
            this.priceLabel.TabIndex = 25;
            this.priceLabel.Text = "Стоимость:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Impact", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthLabel.Location = new System.Drawing.Point(20, 393);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(134, 23);
            this.lengthLabel.TabIndex = 24;
            this.lengthLabel.Text = "Длительность:";
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.Font = new System.Drawing.Font("Impact", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmNameLabel.Location = new System.Drawing.Point(156, 32);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(228, 79);
            this.filmNameLabel.TabIndex = 23;
            this.filmNameLabel.Text = "Название фильма";
            this.filmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticketActionBtn
            // 
            this.ticketActionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketActionBtn.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketActionBtn.Location = new System.Drawing.Point(156, 591);
            this.ticketActionBtn.Name = "ticketActionBtn";
            this.ticketActionBtn.Size = new System.Drawing.Size(228, 41);
            this.ticketActionBtn.TabIndex = 22;
            this.ticketActionBtn.Text = "Купить / забронировать билет";
            this.ticketActionBtn.UseVisualStyleBackColor = true;
            this.ticketActionBtn.Click += new System.EventHandler(this.ticketActionBtn_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Impact", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(20, 430);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(95, 23);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Описание:";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTxtBox.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTxtBox.Location = new System.Drawing.Point(20, 459);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.ReadOnly = true;
            this.descriptionTxtBox.Size = new System.Drawing.Size(487, 126);
            this.descriptionTxtBox.TabIndex = 1;
            // 
            // posterPanel
            // 
            this.posterPanel.BackColor = System.Drawing.Color.White;
            this.posterPanel.Controls.Add(this.posterPicBox);
            this.posterPanel.Location = new System.Drawing.Point(156, 114);
            this.posterPanel.Name = "posterPanel";
            this.posterPanel.Size = new System.Drawing.Size(228, 254);
            this.posterPanel.TabIndex = 0;
            // 
            // posterPicBox
            // 
            this.posterPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.posterPicBox.Location = new System.Drawing.Point(6, 6);
            this.posterPicBox.Name = "posterPicBox";
            this.posterPicBox.Size = new System.Drawing.Size(215, 240);
            this.posterPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterPicBox.TabIndex = 0;
            this.posterPicBox.TabStop = false;
            // 
            // splitterFilmInfo
            // 
            this.splitterFilmInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterFilmInfo.Enabled = false;
            this.splitterFilmInfo.Location = new System.Drawing.Point(1272, 93);
            this.splitterFilmInfo.Name = "splitterFilmInfo";
            this.splitterFilmInfo.Size = new System.Drawing.Size(3, 666);
            this.splitterFilmInfo.TabIndex = 6;
            this.splitterFilmInfo.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.dataGridContextMenuStrip;
            this.dataGridView1.Location = new System.Drawing.Point(6, 455);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(722, 300);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridContextMenuStrip
            // 
            this.dataGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.dataGridContextMenuStrip.Name = "dataGridContextMenuStrip";
            this.dataGridContextMenuStrip.Size = new System.Drawing.Size(155, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1275, 759);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitterFilmInfo);
            this.Controls.Add(this.FilmInfoGrpBox);
            this.Controls.Add(this.headerSplitter);
            this.Controls.Add(this.headerGrpBox);
            this.Controls.Add(this.srchGrpBox);
            this.Name = "MainForm";
            this.Text = "Информационная система для сети кинотеатров";
            this.headerGrpBox.ResumeLayout(false);
            this.headerGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.srchGrpBox.ResumeLayout(false);
            this.admSrchPanel.ResumeLayout(false);
            this.admSrchPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.FilmInfoGrpBox.ResumeLayout(false);
            this.FilmInfoGrpBox.PerformLayout();
            this.posterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.posterPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox headerGrpBox;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox srchGrpBox;
        private System.Windows.Forms.Splitter headerSplitter;
        private System.Windows.Forms.GroupBox FilmInfoGrpBox;
        private System.Windows.Forms.Splitter splitterFilmInfo;
        private System.Windows.Forms.Splitter splitterCashierSearch;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label sessToLabel;
        private System.Windows.Forms.ComboBox sessToComboBox;
        private System.Windows.Forms.Label filmLabel;
        private System.Windows.Forms.ComboBox filmComboBox;
        private System.Windows.Forms.Label sessFromLabel;
        private System.Windows.Forms.ComboBox sessFromComboBox;
        private System.Windows.Forms.Label cinemaLabel;
        private System.Windows.Forms.ComboBox cinemaComboBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Splitter splitterCheckList;
        private System.Windows.Forms.Panel admSrchPanel;
        private System.Windows.Forms.Splitter splitterAdmSearch;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label labelAdminSearch;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ComboBox valueComboBox;
        private System.Windows.Forms.Label atrbLabel;
        private System.Windows.Forms.ComboBox atrbComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox atrbChekListBox;
        private System.Windows.Forms.Panel posterPanel;
        private System.Windows.Forms.PictureBox posterPicBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Button ticketActionBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox loginTxtBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ContextMenuStrip dataGridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem2;
        private System.Windows.Forms.Label filmNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label rubsLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label sessHoursLabel;
        private System.Windows.Forms.Label sessDateLabel;
    }
}

