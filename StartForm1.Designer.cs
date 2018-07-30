namespace CoCaNgua
{
    partial class StartForm1
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
            this.LabelCaiDat = new System.Windows.Forms.Label();
            this.LabelDiTruoc = new System.Windows.Forms.Label();
            this.GroupBoxDiTruoc = new System.Windows.Forms.GroupBox();
            this.RBtnChooseGreen = new System.Windows.Forms.RadioButton();
            this.RBtnChooseYellow = new System.Windows.Forms.RadioButton();
            this.RBtnChooseBlue = new System.Windows.Forms.RadioButton();
            this.RBtnChooseRed = new System.Windows.Forms.RadioButton();
            this.ButtonStartForm1 = new System.Windows.Forms.Button();
            this.GroupBoxDiTruoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelCaiDat
            // 
            this.LabelCaiDat.AutoSize = true;
            this.LabelCaiDat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCaiDat.Location = new System.Drawing.Point(224, 26);
            this.LabelCaiDat.Name = "LabelCaiDat";
            this.LabelCaiDat.Size = new System.Drawing.Size(83, 30);
            this.LabelCaiDat.TabIndex = 0;
            this.LabelCaiDat.Text = "Cài Đặt";
            // 
            // LabelDiTruoc
            // 
            this.LabelDiTruoc.AutoSize = true;
            this.LabelDiTruoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDiTruoc.Location = new System.Drawing.Point(55, 87);
            this.LabelDiTruoc.Name = "LabelDiTruoc";
            this.LabelDiTruoc.Size = new System.Drawing.Size(401, 42);
            this.LabelDiTruoc.TabIndex = 1;
            this.LabelDiTruoc.Text = "Chọn màu cờ đi trước:\r\nLưu ý: Thứ tự đi trước xếp theo chiều ngược kim đồng hồ\r\n";
            // 
            // GroupBoxDiTruoc
            // 
            this.GroupBoxDiTruoc.Controls.Add(this.RBtnChooseGreen);
            this.GroupBoxDiTruoc.Controls.Add(this.RBtnChooseYellow);
            this.GroupBoxDiTruoc.Controls.Add(this.RBtnChooseBlue);
            this.GroupBoxDiTruoc.Controls.Add(this.RBtnChooseRed);
            this.GroupBoxDiTruoc.Location = new System.Drawing.Point(57, 156);
            this.GroupBoxDiTruoc.Name = "GroupBoxDiTruoc";
            this.GroupBoxDiTruoc.Size = new System.Drawing.Size(399, 182);
            this.GroupBoxDiTruoc.TabIndex = 2;
            this.GroupBoxDiTruoc.TabStop = false;
            // 
            // RBtnChooseGreen
            // 
            this.RBtnChooseGreen.Image = global::CoCaNgua.Properties.Resources.GreenHorse;
            this.RBtnChooseGreen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBtnChooseGreen.Location = new System.Drawing.Point(301, 39);
            this.RBtnChooseGreen.Name = "RBtnChooseGreen";
            this.RBtnChooseGreen.Size = new System.Drawing.Size(50, 43);
            this.RBtnChooseGreen.TabIndex = 1;
            this.RBtnChooseGreen.UseVisualStyleBackColor = true;
            // 
            // RBtnChooseYellow
            // 
            this.RBtnChooseYellow.Image = global::CoCaNgua.Properties.Resources.YellowHorse;
            this.RBtnChooseYellow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBtnChooseYellow.Location = new System.Drawing.Point(301, 103);
            this.RBtnChooseYellow.Name = "RBtnChooseYellow";
            this.RBtnChooseYellow.Size = new System.Drawing.Size(50, 43);
            this.RBtnChooseYellow.TabIndex = 2;
            this.RBtnChooseYellow.UseVisualStyleBackColor = true;
            // 
            // RBtnChooseBlue
            // 
            this.RBtnChooseBlue.Image = global::CoCaNgua.Properties.Resources.BlueHorse;
            this.RBtnChooseBlue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBtnChooseBlue.Location = new System.Drawing.Point(50, 103);
            this.RBtnChooseBlue.Name = "RBtnChooseBlue";
            this.RBtnChooseBlue.Size = new System.Drawing.Size(50, 43);
            this.RBtnChooseBlue.TabIndex = 3;
            this.RBtnChooseBlue.UseVisualStyleBackColor = true;
            // 
            // RBtnChooseRed
            // 
            this.RBtnChooseRed.Checked = true;
            this.RBtnChooseRed.Image = global::CoCaNgua.Properties.Resources.RedHorse;
            this.RBtnChooseRed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBtnChooseRed.Location = new System.Drawing.Point(50, 39);
            this.RBtnChooseRed.Name = "RBtnChooseRed";
            this.RBtnChooseRed.Size = new System.Drawing.Size(50, 43);
            this.RBtnChooseRed.TabIndex = 0;
            this.RBtnChooseRed.TabStop = true;
            this.RBtnChooseRed.Tag = "";
            this.RBtnChooseRed.UseVisualStyleBackColor = true;
            // 
            // ButtonStartForm1
            // 
            this.ButtonStartForm1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartForm1.Location = new System.Drawing.Point(217, 386);
            this.ButtonStartForm1.Name = "ButtonStartForm1";
            this.ButtonStartForm1.Size = new System.Drawing.Size(100, 51);
            this.ButtonStartForm1.TabIndex = 3;
            this.ButtonStartForm1.Text = "Next";
            this.ButtonStartForm1.UseVisualStyleBackColor = true;
            this.ButtonStartForm1.Click += new System.EventHandler(this.ButtonStartForm1_Click);
            // 
            // StartForm1
            // 
            this.AcceptButton = this.ButtonStartForm1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 465);
            this.Controls.Add(this.ButtonStartForm1);
            this.Controls.Add(this.GroupBoxDiTruoc);
            this.Controls.Add(this.LabelDiTruoc);
            this.Controls.Add(this.LabelCaiDat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::CoCaNgua.Properties.Resources.CoCaNguaIcon;
            this.MaximizeBox = false;
            this.Name = "StartForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.GroupBoxDiTruoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCaiDat;
        private System.Windows.Forms.Label LabelDiTruoc;
        private System.Windows.Forms.GroupBox GroupBoxDiTruoc;
        private System.Windows.Forms.RadioButton RBtnChooseRed;
        private System.Windows.Forms.RadioButton RBtnChooseGreen;
        private System.Windows.Forms.RadioButton RBtnChooseYellow;
        private System.Windows.Forms.RadioButton RBtnChooseBlue;
        private System.Windows.Forms.Button ButtonStartForm1;
    }
}