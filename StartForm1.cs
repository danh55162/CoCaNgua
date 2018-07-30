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
    public partial class StartForm1 : Form
    {
        #region Method

        // Default by system
        public StartForm1()
        {
            InitializeComponent();
        }

        private void SwitchToForm2()
        {
            // this ở đây như là một object thể hiện cho class StartForm1
            this.Hide();
            StartForm2 Form2 = new StartForm2();
            Form2.ShowDialog();
            this.Close();
        }

        #endregion

        private void ButtonStartForm1_Click(object sender, EventArgs e)
        {
            if (RBtnChooseRed.Checked == true)
            {
                PlayerIndex.RedIndex = 1;
                PlayerIndex.BlueIndex = 2;
                PlayerIndex.YellowIndex = 3;
                PlayerIndex.GreenIndex = 4;
                SwitchToForm2();
            }
            else if (RBtnChooseBlue.Checked == true)
            {
                PlayerIndex.BlueIndex = 1;
                PlayerIndex.YellowIndex = 2;
                PlayerIndex.GreenIndex = 3;
                PlayerIndex.RedIndex = 4;
                SwitchToForm2();
            }
            else if (RBtnChooseYellow.Checked == true)
            {
                PlayerIndex.YellowIndex = 1;
                PlayerIndex.GreenIndex = 2;
                PlayerIndex.RedIndex = 3;
                PlayerIndex.BlueIndex = 4;
                SwitchToForm2();
            }
            else if (RBtnChooseGreen.Checked == true)
            {
                PlayerIndex.GreenIndex = 1;
                PlayerIndex.RedIndex = 2;
                PlayerIndex.BlueIndex = 3;
                PlayerIndex.YellowIndex = 4;
                SwitchToForm2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn màu cờ đi trước", "LỖI!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
