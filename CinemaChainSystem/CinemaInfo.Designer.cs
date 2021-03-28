
namespace CinemaChainSystem
{
    partial class CinemaInfo
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
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.cDateTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cityLabel = new System.Windows.Forms.Label();
            this.сDateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.oDateLabel = new System.Windows.Forms.Label();
            this.oDateTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(95, 420);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(350, 23);
            this.cityComboBox.TabIndex = 34;
            this.cityComboBox.TextChanged += new System.EventHandler(this.cityComboBox_TextChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(131, 131);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(315, 23);
            this.nameTxtBox.TabIndex = 33;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(221, 185);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(224, 23);
            this.phoneTxtBox.TabIndex = 32;
            this.phoneTxtBox.TextChanged += new System.EventHandler(this.phoneTxtBox_TextChanged);
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(94, 249);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.addressTxtBox.Size = new System.Drawing.Size(352, 23);
            this.addressTxtBox.TabIndex = 31;
            // 
            // cDateTxtBox
            // 
            this.cDateTxtBox.Enabled = false;
            this.cDateTxtBox.Location = new System.Drawing.Point(172, 372);
            this.cDateTxtBox.Name = "cDateTxtBox";
            this.cDateTxtBox.Size = new System.Drawing.Size(273, 23);
            this.cDateTxtBox.TabIndex = 29;
            this.cDateTxtBox.TextChanged += new System.EventHandler(this.DateTxtBox_TextChanged);
            this.cDateTxtBox.Enter += new System.EventHandler(this.cDateTxtBox_Enter);
            this.cDateTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyDigs);
            this.cDateTxtBox.Leave += new System.EventHandler(this.cDateTxtBox_Leave);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(131, 468);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 36);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(17, 468);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(94, 36);
            this.OKBtn.TabIndex = 27;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(17, 414);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 28);
            this.cityLabel.TabIndex = 26;
            this.cityLabel.Text = "Город:";
            // 
            // сDateLabel
            // 
            this.сDateLabel.AutoSize = true;
            this.сDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.сDateLabel.Location = new System.Drawing.Point(17, 364);
            this.сDateLabel.Name = "сDateLabel";
            this.сDateLabel.Size = new System.Drawing.Size(148, 28);
            this.сDateLabel.TabIndex = 25;
            this.сDateLabel.Text = "Дата закрытия:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(17, 241);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(71, 28);
            this.addressLabel.TabIndex = 23;
            this.addressLabel.Text = "Адрес:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(131, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(197, 28);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Название операции";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(17, 177);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(198, 28);
            this.phoneLabel.TabIndex = 21;
            this.phoneLabel.Text = "Телефонный номер:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(17, 126);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 28);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Название:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(17, 68);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 28);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "ID:";
            // 
            // oDateLabel
            // 
            this.oDateLabel.AutoSize = true;
            this.oDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oDateLabel.Location = new System.Drawing.Point(17, 306);
            this.oDateLabel.Name = "oDateLabel";
            this.oDateLabel.Size = new System.Drawing.Size(149, 28);
            this.oDateLabel.TabIndex = 35;
            this.oDateLabel.Text = "Дата открытия:";
            // 
            // oDateTxtBox
            // 
            this.oDateTxtBox.Location = new System.Drawing.Point(172, 314);
            this.oDateTxtBox.Name = "oDateTxtBox";
            this.oDateTxtBox.Size = new System.Drawing.Size(273, 23);
            this.oDateTxtBox.TabIndex = 37;
            this.oDateTxtBox.TextChanged += new System.EventHandler(this.DateTxtBox_TextChanged);
            this.oDateTxtBox.Enter += new System.EventHandler(this.oDateTxtBox_Enter);
            this.oDateTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyDigs);
            this.oDateTxtBox.Leave += new System.EventHandler(this.oDateTxtBox_Leave);
            // 
            // CinemaInfo
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(463, 518);
            this.Controls.Add(this.oDateTxtBox);
            this.Controls.Add(this.oDateLabel);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.cDateTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.сDateLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "CinemaInfo";
            this.Text = "CinemaInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cityComboBox;
        public System.Windows.Forms.TextBox nameTxtBox;
        public System.Windows.Forms.TextBox phoneTxtBox;
        public System.Windows.Forms.TextBox addressTxtBox;
        public System.Windows.Forms.TextBox cDateTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label сDateLabel;
        private System.Windows.Forms.Label addressLabel;
        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label oDateLabel;
        public System.Windows.Forms.TextBox oDateTxtBox;
    }
}