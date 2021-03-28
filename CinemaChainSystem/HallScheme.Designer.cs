
namespace CinemaChainSystem
{
    partial class HallScheme
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
            this.screenPanel = new System.Windows.Forms.Panel();
            this.screenLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.cancelRadioButton = new System.Windows.Forms.RadioButton();
            this.chooseRadioButton = new System.Windows.Forms.RadioButton();
            this.placeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.screenPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenPanel
            // 
            this.screenPanel.BackColor = System.Drawing.Color.Gray;
            this.screenPanel.Controls.Add(this.screenLabel);
            this.screenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenPanel.Location = new System.Drawing.Point(0, 0);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(724, 46);
            this.screenPanel.TabIndex = 1;
            // 
            // screenLabel
            // 
            this.screenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.screenLabel.BackColor = System.Drawing.Color.Black;
            this.screenLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.screenLabel.ForeColor = System.Drawing.Color.White;
            this.screenLabel.Location = new System.Drawing.Point(284, 0);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(117, 46);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "ЭКРАН";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Silver;
            this.infoPanel.Controls.Add(this.priceLabel);
            this.infoPanel.Controls.Add(this.buyBtn);
            this.infoPanel.Controls.Add(this.cancelBtn);
            this.infoPanel.Controls.Add(this.bookBtn);
            this.infoPanel.Controls.Add(this.cancelRadioButton);
            this.infoPanel.Controls.Add(this.chooseRadioButton);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 546);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(724, 112);
            this.infoPanel.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(391, 3);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(113, 28);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Стоимость:";
            // 
            // buyBtn
            // 
            this.buyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buyBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyBtn.Location = new System.Drawing.Point(391, 69);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(94, 36);
            this.buyBtn.TabIndex = 13;
            this.buyBtn.Text = "Купить";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(619, 69);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 36);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // bookBtn
            // 
            this.bookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookBtn.Location = new System.Drawing.Point(491, 69);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(122, 36);
            this.bookBtn.TabIndex = 11;
            this.bookBtn.Text = "Забронировать";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // cancelRadioButton
            // 
            this.cancelRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelRadioButton.AutoSize = true;
            this.cancelRadioButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelRadioButton.Location = new System.Drawing.Point(12, 72);
            this.cancelRadioButton.Name = "cancelRadioButton";
            this.cancelRadioButton.Size = new System.Drawing.Size(220, 29);
            this.cancelRadioButton.TabIndex = 2;
            this.cancelRadioButton.TabStop = true;
            this.cancelRadioButton.Text = "Отменить выбор места";
            this.cancelRadioButton.UseVisualStyleBackColor = true;
            // 
            // chooseRadioButton
            // 
            this.chooseRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseRadioButton.AutoSize = true;
            this.chooseRadioButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseRadioButton.Location = new System.Drawing.Point(12, 17);
            this.chooseRadioButton.Name = "chooseRadioButton";
            this.chooseRadioButton.Size = new System.Drawing.Size(152, 29);
            this.chooseRadioButton.TabIndex = 0;
            this.chooseRadioButton.TabStop = true;
            this.chooseRadioButton.Text = "Выбрать место";
            this.chooseRadioButton.UseVisualStyleBackColor = true;
            // 
            // placeListView
            // 
            this.placeListView.AutoArrange = false;
            this.placeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.placeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeListView.HideSelection = false;
            this.placeListView.Location = new System.Drawing.Point(0, 46);
            this.placeListView.Name = "placeListView";
            this.placeListView.Size = new System.Drawing.Size(724, 500);
            this.placeListView.TabIndex = 3;
            this.placeListView.UseCompatibleStateImageBehavior = false;
            this.placeListView.Resize += new System.EventHandler(this.placeListView_Resize);
            // 
            // HallScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 658);
            this.Controls.Add(this.placeListView);
            this.Controls.Add(this.screenPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "HallScheme";
            this.Text = "Схема зала";
            this.screenPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.RadioButton chooseRadioButton;
        private System.Windows.Forms.RadioButton cancelRadioButton;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.ListView placeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Label priceLabel;
    }
}