
namespace CinemaChainSystem
{
    partial class HallInfo
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
            this.numberTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cinemaLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.placesInARowLabel = new System.Windows.Forms.Label();
            this.rowsCountLabel = new System.Windows.Forms.Label();
            this.rowsCountTxtBox = new System.Windows.Forms.TextBox();
            this.placesInARowTxtBox = new System.Windows.Forms.TextBox();
            this.cinemaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // numberTxtBox
            // 
            this.numberTxtBox.Location = new System.Drawing.Point(136, 118);
            this.numberTxtBox.Name = "numberTxtBox";
            this.numberTxtBox.Size = new System.Drawing.Size(299, 23);
            this.numberTxtBox.TabIndex = 32;
            this.numberTxtBox.TextChanged += new System.EventHandler(this.numberTxtBox_TextChanged);
            this.numberTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyDigs);
            this.numberTxtBox.Leave += new System.EventHandler(this.numberTxtBox_Leave);
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(136, 156);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(299, 41);
            this.descriptionTxtBox.TabIndex = 30;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(121, 352);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 36);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(7, 352);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(94, 36);
            this.OKBtn.TabIndex = 27;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // cinemaLabel
            // 
            this.cinemaLabel.AutoSize = true;
            this.cinemaLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaLabel.Location = new System.Drawing.Point(7, 304);
            this.cinemaLabel.Name = "cinemaLabel";
            this.cinemaLabel.Size = new System.Drawing.Size(112, 28);
            this.cinemaLabel.TabIndex = 26;
            this.cinemaLabel.Text = "Кинотеатр:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(7, 169);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(108, 28);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "Описание:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(121, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(197, 28);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Название операции";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLabel.Location = new System.Drawing.Point(7, 110);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(123, 28);
            this.numberLabel.TabIndex = 21;
            this.numberLabel.Text = "Номер зала:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(7, 69);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 28);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "ID:";
            // 
            // placesInARowLabel
            // 
            this.placesInARowLabel.AutoSize = true;
            this.placesInARowLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placesInARowLabel.Location = new System.Drawing.Point(7, 255);
            this.placesInARowLabel.Name = "placesInARowLabel";
            this.placesInARowLabel.Size = new System.Drawing.Size(125, 28);
            this.placesInARowLabel.TabIndex = 37;
            this.placesInARowLabel.Text = "Мест в ряду:";
            // 
            // rowsCountLabel
            // 
            this.rowsCountLabel.AutoSize = true;
            this.rowsCountLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowsCountLabel.Location = new System.Drawing.Point(7, 217);
            this.rowsCountLabel.Name = "rowsCountLabel";
            this.rowsCountLabel.Size = new System.Drawing.Size(185, 28);
            this.rowsCountLabel.TabIndex = 38;
            this.rowsCountLabel.Text = "Количество рядов:";
            // 
            // rowsCountTxtBox
            // 
            this.rowsCountTxtBox.Location = new System.Drawing.Point(198, 222);
            this.rowsCountTxtBox.Name = "rowsCountTxtBox";
            this.rowsCountTxtBox.Size = new System.Drawing.Size(55, 23);
            this.rowsCountTxtBox.TabIndex = 39;
            this.rowsCountTxtBox.TextChanged += new System.EventHandler(this.countsTxtBox_TextChanged);
            this.rowsCountTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyDigs);
            // 
            // placesInARowTxtBox
            // 
            this.placesInARowTxtBox.Location = new System.Drawing.Point(136, 260);
            this.placesInARowTxtBox.Name = "placesInARowTxtBox";
            this.placesInARowTxtBox.Size = new System.Drawing.Size(55, 23);
            this.placesInARowTxtBox.TabIndex = 40;
            this.placesInARowTxtBox.TextChanged += new System.EventHandler(this.countsTxtBox_TextChanged);
            this.placesInARowTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyDigs);
            // 
            // cinemaComboBox
            // 
            this.cinemaComboBox.FormattingEnabled = true;
            this.cinemaComboBox.Location = new System.Drawing.Point(136, 309);
            this.cinemaComboBox.Name = "cinemaComboBox";
            this.cinemaComboBox.Size = new System.Drawing.Size(299, 23);
            this.cinemaComboBox.TabIndex = 41;
            this.cinemaComboBox.SelectedIndexChanged += new System.EventHandler(this.cinemaComboBox_SelectedIndexChanged);
            this.cinemaComboBox.TextChanged += new System.EventHandler(this.cinemaComboBox_TextChanged);
            // 
            // HallInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(441, 405);
            this.Controls.Add(this.placesInARowTxtBox);
            this.Controls.Add(this.rowsCountTxtBox);
            this.Controls.Add(this.rowsCountLabel);
            this.Controls.Add(this.placesInARowLabel);
            this.Controls.Add(this.numberTxtBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.cinemaLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.cinemaComboBox);
            this.Name = "HallInfo";
            this.Text = "HallInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox numberTxtBox;
        public System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numberLabel;
        public System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label placesInARowLabel;
        private System.Windows.Forms.Label rowsCountLabel;
        public System.Windows.Forms.ComboBox placesInARowConboBox;
        public System.Windows.Forms.ComboBox placesInARowComboBox;
        public System.Windows.Forms.TextBox rowsCountTxtBox;
        public System.Windows.Forms.TextBox placesInARowTxtBox;
        public System.Windows.Forms.Label cinemaLabel;
        public System.Windows.Forms.ComboBox cinemaComboBox;
    }
}