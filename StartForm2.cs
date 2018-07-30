using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaNgua
{
    public partial class StartForm2 : Form
    {
        #region Method
        public StartForm2()
        {
            InitializeComponent();
        }

        private void CheckName(TextBox textBox, string Message, ref bool Check)
        {
            if (textBox.Text == "")
            {
                DialogResult result = MessageBox.Show(Message, "Chưa chọn tên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:  
                        break;
                    case DialogResult.No:   Check = false;
                        break;
                }
            }
        }

        private string GetName(Color color)
        {
            string Name = "";
            if (color == Color.Red)
            {
                Name = txBRedPlayerName.Text;
            }
            else if (color == Color.Blue)
            {

            }

        }

        #endregion

        private void ButtonStartForm2_Click(object sender, EventArgs e)
        {
            string Ask = "Bạn có chắc chắn không muốn chọn tên cho quân ";
            bool Check = true;
            if (Check == true)
            {
                CheckName(txBRedPlayerName, Ask + "Đỏ?", ref Check);
            }
            if (Check == true)
            {
                CheckName(txBBluePlayerName, Ask + "Xanh Dương", ref Check);
            }
            if (Check == true)
            {
                CheckName(txBYellowPlayerName, Ask + "Vàng?", ref Check);
            }
            if (Check == true)
            {
                CheckName(txBGreenPlayerName, Ask + "Xanh Lá Cây?", ref Check);
            }
            if (Check == true)
            {
                Hide(); // StartForm2
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog(); // MainForm
                Close();
            }
        }
    }
}
