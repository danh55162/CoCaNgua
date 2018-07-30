using System.Drawing;
using System.Windows.Forms;

namespace CoCaNgua
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnThrowBlock = new System.Windows.Forms.Button();
            this.BtnBlock2 = new System.Windows.Forms.Button();
            this.BtnBlock1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // BtnThrowBlock
            // 
            this.BtnThrowBlock.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThrowBlock.Location = new System.Drawing.Point(675, 51);
            this.BtnThrowBlock.Name = "BtnThrowBlock";
            this.BtnThrowBlock.Size = new System.Drawing.Size(175, 100);
            this.BtnThrowBlock.TabIndex = 1;
            this.BtnThrowBlock.Text = "ĐỔ";
            this.BtnThrowBlock.UseVisualStyleBackColor = true;
            // 
            // BtnBlock2
            // 
            this.BtnBlock2.BackgroundImage = global::CoCaNgua.Properties.Resources._1;
            this.BtnBlock2.Enabled = false;
            this.BtnBlock2.Location = new System.Drawing.Point(1096, 50);
            this.BtnBlock2.Name = "BtnBlock2";
            this.BtnBlock2.Size = new System.Drawing.Size(100, 100);
            this.BtnBlock2.TabIndex = 3;
            this.BtnBlock2.UseVisualStyleBackColor = true;
            // 
            // BtnBlock1
            // 
            this.BtnBlock1.BackgroundImage = global::CoCaNgua.Properties.Resources._1;
            this.BtnBlock1.Enabled = false;
            this.BtnBlock1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBlock1.Location = new System.Drawing.Point(958, 50);
            this.BtnBlock1.Name = "BtnBlock1";
            this.BtnBlock1.Size = new System.Drawing.Size(100, 100);
            this.BtnBlock1.TabIndex = 4;
            this.BtnBlock1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnThrowBlock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 739);
            this.Controls.Add(this.BtnBlock1);
            this.Controls.Add(this.BtnBlock2);
            this.Controls.Add(this.BtnThrowBlock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = global::CoCaNgua.Properties.Resources.CoCaNguaIcon;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Cá Ngựa v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Use for CreateAndDrawHouse
        private void DrawHouse(Button House, int Width, int Height, Color PlayerColor)
        {
            House.Size = new Size(234, 234);
            House.Location = new Point(Width, Height);
            House.Enabled = false;
            House.FlatStyle = FlatStyle.Flat;
            House.FlatAppearance.BorderColor = PlayerColor;
            House.FlatAppearance.BorderSize = 15;
            this.Controls.Add(House);
            House.SendToBack();
        }

        // Use for DrawName
        private void DrawName(Button name, int WidthLocation, int HeigtLocation, Color color)
        {
            StartForm2 dataStartForm2 = new StartForm2();
            string btnText = "";
            if (color == Color.Red)
            {
                btnText = 
            }
            name = new Button()
            {
                Enabled = true,
                Text = Text,
                Font = new Font("Segoe UI", 11.25F),
                Location = new Point(WidthLocation, HeigtLocation),
                Size = new Size(100, 32),
                ForeColor = color,
            };
            this.Controls.Add(name);
            name.BringToFront();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private Button BtnThrowBlock;
        private Button BtnBlock2;
        private Button BtnBlock1;
        private ToolStripMenuItem helpToolStripMenuItem1;
    }
}

