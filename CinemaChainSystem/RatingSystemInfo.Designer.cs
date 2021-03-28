
namespace CinemaChainSystem
{
    partial class RatingSystemInfo
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
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(120, 127);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(107, 23);
            this.nameTxtBox.TabIndex = 41;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(130, 170);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 36);
            this.cancelBtn.TabIndex = 40;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(16, 170);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(94, 36);
            this.OKBtn.TabIndex = 39;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(30, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(197, 28);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.Text = "Название операции";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(6, 122);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 28);
            this.nameLabel.TabIndex = 37;
            this.nameLabel.Text = "Название:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(6, 64);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 28);
            this.IDLabel.TabIndex = 36;
            this.IDLabel.Text = "ID:";
            // 
            // RatingSystemInfo
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(255, 230);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "RatingSystemInfo";
            this.Text = "RatingSystemInfo";
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
    }
}