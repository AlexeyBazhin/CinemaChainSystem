
namespace CinemaChainSystem
{
    partial class FilmInfo
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.posterLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.releaseLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.releaseDateTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.posterTxtBox = new System.Windows.Forms.TextBox();
            this.lengthTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(12, 80);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 28);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 138);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 28);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Название:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthLabel.Location = new System.Drawing.Point(12, 189);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(198, 28);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "Длительность (мин):";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(126, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(197, 28);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Название операции";
            // 
            // posterLabel
            // 
            this.posterLabel.AutoSize = true;
            this.posterLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.posterLabel.Location = new System.Drawing.Point(12, 253);
            this.posterLabel.Name = "posterLabel";
            this.posterLabel.Size = new System.Drawing.Size(177, 28);
            this.posterLabel.TabIndex = 5;
            this.posterLabel.Text = "Ссылка на постер:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(12, 348);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(108, 28);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Описание:";
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.releaseLabel.Location = new System.Drawing.Point(12, 391);
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(127, 28);
            this.releaseLabel.TabIndex = 7;
            this.releaseLabel.Text = "Дата релиза:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ratingLabel.Location = new System.Drawing.Point(12, 449);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(247, 28);
            this.ratingLabel.TabIndex = 8;
            this.ratingLabel.Text = "Возрастное ограничение:";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(12, 543);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(94, 36);
            this.OKBtn.TabIndex = 9;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(126, 543);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 36);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // releaseDateTxtBox
            // 
            this.releaseDateTxtBox.Location = new System.Drawing.Point(145, 399);
            this.releaseDateTxtBox.Name = "releaseDateTxtBox";
            this.releaseDateTxtBox.Size = new System.Drawing.Size(295, 23);
            this.releaseDateTxtBox.TabIndex = 11;
            this.releaseDateTxtBox.TextChanged += new System.EventHandler(this.releaseDateTxtBox_TextChanged);
            this.releaseDateTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyDigs);
            this.releaseDateTxtBox.Leave += new System.EventHandler(this.releaseDateTxtBox_Leave);
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(125, 303);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(315, 73);
            this.descriptionTxtBox.TabIndex = 13;
            // 
            // posterTxtBox
            // 
            this.posterTxtBox.Location = new System.Drawing.Point(195, 261);
            this.posterTxtBox.Name = "posterTxtBox";
            this.posterTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.posterTxtBox.Size = new System.Drawing.Size(246, 23);
            this.posterTxtBox.TabIndex = 14;
            // 
            // lengthTxtBox
            // 
            this.lengthTxtBox.Location = new System.Drawing.Point(216, 197);
            this.lengthTxtBox.Name = "lengthTxtBox";
            this.lengthTxtBox.Size = new System.Drawing.Size(224, 23);
            this.lengthTxtBox.TabIndex = 15;
            this.lengthTxtBox.TextChanged += new System.EventHandler(this.lengthTxtBox_TextChanged);
            this.lengthTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOnlyDigs);
            this.lengthTxtBox.Leave += new System.EventHandler(this.lengthTxtBox_Leave);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(126, 143);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(315, 23);
            this.nameTxtBox.TabIndex = 16;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(265, 455);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(175, 23);
            this.ratingComboBox.TabIndex = 18;
            this.ratingComboBox.TextChanged += new System.EventHandler(this.ratingComboBox_TextChanged);
            // 
            // FilmInfo
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(463, 591);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.lengthTxtBox);
            this.Controls.Add(this.posterTxtBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.releaseDateTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.releaseLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.posterLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "FilmInfo";
            this.Text = "FilmInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label posterLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label releaseLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.TextBox releaseDateTxtBox;
        public System.Windows.Forms.TextBox descriptionTxtBox;
        public System.Windows.Forms.TextBox posterTxtBox;
        public System.Windows.Forms.TextBox lengthTxtBox;
        public System.Windows.Forms.TextBox nameTxtBox;
        public System.Windows.Forms.ComboBox ratingComboBox;
    }
}