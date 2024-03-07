using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIsLife
{
    public partial class FrmSave : Form
    {
        // VALUES
        #region
        public FrmChessIsLife Main;
        #endregion

        // FORM
        #region
        public FrmSave()
        {
            InitializeComponent();
        }
        #endregion

        // BUTTON
        #region
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Main.filePath = TxtFilePath.Text + ".txt";
            Main.SaveMove(Main.filePath);
            this.Close();
        }
        #endregion
    }
}
