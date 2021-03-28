
namespace CinemaChainSystem
{
    partial class CityInfo
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(124, 127);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(315, 23);
            this.nameTxtBox.TabIndex = 33;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            this.nameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.charsKeyPress);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(341, 243);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 36);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(227, 243);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(94, 36);
            this.OKBtn.TabIndex = 27;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(124, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(197, 28);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Название операции";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(10, 122);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 28);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Название:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(10, 64);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 28);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "ID:";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionLabel.Location = new System.Drawing.Point(10, 178);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(81, 28);
            this.regionLabel.TabIndex = 34;
            this.regionLabel.Text = "Регион:";
            // 
            // regionTxtBox
            // 
            this.regionTxtBox.Location = new System.Drawing.Point(124, 183);
            this.regionTxtBox.Name = "regionTxtBox";
            this.regionTxtBox.Size = new System.Drawing.Size(315, 23);
            this.regionTxtBox.TabIndex = 35;
            this.regionTxtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            this.regionTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.charsKeyPress);
            // 
            // CityInfo
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(443, 286);
            this.Controls.Add(this.regionTxtBox);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "CityInfo";
            this.Text = "CityInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OKBtn;
        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label regionLabel;
        public System.Windows.Forms.TextBox regionTxtBox;
    }
}