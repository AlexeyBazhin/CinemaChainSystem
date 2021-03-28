
namespace CinemaChainSystem
{
    partial class SessionInfo
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
            this.filmComboBox = new System.Windows.Forms.ComboBox();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.filmLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.hallComboBox = new System.Windows.Forms.ComboBox();
            this.hallLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filmComboBox
            // 
            this.filmComboBox.FormattingEnabled = true;
            this.filmComboBox.Location = new System.Drawing.Point(102, 260);
            this.filmComboBox.Name = "filmComboBox";
            this.filmComboBox.Size = new System.Drawing.Size(344, 23);
            this.filmComboBox.TabIndex = 34;
            this.filmComboBox.SelectedIndexChanged += new System.EventHandler(this.filmComboBox_SelectedIndexChanged);
            this.filmComboBox.TextChanged += new System.EventHandler(this.filmComboBox_TextChanged);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(188, 178);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(258, 23);
            this.priceTxtBox.TabIndex = 32;
            this.priceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputDigsComa);
            this.priceTxtBox.Leave += new System.EventHandler(this.priceTxtBox_Leave);
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(139, 221);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.typeTxtBox.Size = new System.Drawing.Size(308, 23);
            this.typeTxtBox.TabIndex = 31;
            this.typeTxtBox.Leave += new System.EventHandler(this.typeTxtBox_Leave);
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Location = new System.Drawing.Point(151, 129);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.Size = new System.Drawing.Size(295, 23);
            this.dateTxtBox.TabIndex = 29;
            this.dateTxtBox.TextChanged += new System.EventHandler(this.dateTxtBox_TextChanged);
            this.dateTxtBox.Enter += new System.EventHandler(this.dateTxtBox_Enter);
            this.dateTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputDigsSpace);
            this.dateTxtBox.Leave += new System.EventHandler(this.dateTxtBox_Leave);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(132, 341);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 36);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(18, 341);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(94, 36);
            this.OKBtn.TabIndex = 27;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // filmLabel
            // 
            this.filmLabel.AutoSize = true;
            this.filmLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmLabel.Location = new System.Drawing.Point(19, 252);
            this.filmLabel.Name = "filmLabel";
            this.filmLabel.Size = new System.Drawing.Size(78, 28);
            this.filmLabel.TabIndex = 26;
            this.filmLabel.Text = "Фильм:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(18, 121);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(123, 28);
            this.dateLabel.TabIndex = 25;
            this.dateLabel.Text = "Дата сеанса:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeLabel.Location = new System.Drawing.Point(18, 213);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(115, 28);
            this.typeLabel.TabIndex = 23;
            this.typeLabel.Text = "Тип сеанса:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(132, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(197, 28);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Название операции";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(18, 170);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(164, 28);
            this.priceLabel.TabIndex = 21;
            this.priceLabel.Text = "Стоимость (руб):";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(18, 71);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 28);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "ID:";
            // 
            // hallComboBox
            // 
            this.hallComboBox.FormattingEnabled = true;
            this.hallComboBox.Location = new System.Drawing.Point(103, 299);
            this.hallComboBox.Name = "hallComboBox";
            this.hallComboBox.Size = new System.Drawing.Size(344, 23);
            this.hallComboBox.TabIndex = 36;
            this.hallComboBox.SelectedIndexChanged += new System.EventHandler(this.hallComboBox_SelectedIndexChanged);
            this.hallComboBox.TextChanged += new System.EventHandler(this.hallComboBox_TextChanged);
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hallLabel.Location = new System.Drawing.Point(19, 293);
            this.hallLabel.Name = "hallLabel";
            this.hallLabel.Size = new System.Drawing.Size(48, 28);
            this.hallLabel.TabIndex = 35;
            this.hallLabel.Text = "Зал:";
            // 
            // SessionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 395);
            this.Controls.Add(this.hallComboBox);
            this.Controls.Add(this.hallLabel);
            this.Controls.Add(this.filmComboBox);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.typeTxtBox);
            this.Controls.Add(this.dateTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.filmLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "SessionInfo";
            this.Text = "SessionInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox filmComboBox;
        public System.Windows.Forms.TextBox priceTxtBox;
        public System.Windows.Forms.TextBox typeTxtBox;
        public System.Windows.Forms.TextBox dateTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label filmLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label typeLabel;
        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.ComboBox hallComboBox;
        private System.Windows.Forms.Label hallLabel;
    }
}