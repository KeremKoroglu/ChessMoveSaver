using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIsLife
{
    public partial class FrmChessIsLife : Form
    {
        // VALUE
        #region
        readonly FrmSave Save = new FrmSave();

        readonly List<string> moves = new List<string>();
        public string filePath;
        string whiteMove;
        int moveNumber = 1;
        int moveHalf = 0;
        #endregion

        // FORM
        #region
        public FrmChessIsLife()
        {
            InitializeComponent();
        }
        private void FrmChessIsLife_Load(object sender, EventArgs e)
        {
            // Country Code
            #region
            List<string> countryCodes = new List<string>();

            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo region = new RegionInfo(culture.Name);
                string countryCode = region.ThreeLetterISORegionName;

                if (!countryCodes.Contains(countryCode))
                {
                    countryCodes.Add(countryCode);
                }
            }

            countryCodes.Sort();

            foreach (string code in countryCodes)
            {
                CmbWhiteNational.Items.Add(code);
                CmbBlackNational.Items.Add(code);
            }
            #endregion
        }
        #endregion

        // BUTTON
        #region
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddMove(TxtMove.Text);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save.Main = this;
            Save.ShowDialog();
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;

                string path = Path.Combine(selectedPath, filePath);

                SaveMove(path);

                MessageBox.Show("Game file copied successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        // TEXTBOX
        #region
        private void TxtMove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddMove(TxtMove.Text);
                TxtMove.Clear();
            }
        }
        #endregion

        // CHECKBOX
        #region
        private void ChbDateNull_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbDateNull.Checked == true)
            {
                DtpDate.Enabled = false;
            }
            else
            {
                DtpDate.Enabled = true;
            }
        }
        #endregion

        // METOD
        #region
        public void SaveMove(string filePath)
        {
            string whiteName = string.IsNullOrEmpty(TxtWhiteName.Text) ? "White" : TxtWhiteName.Text;
            string whiteSurname = string.IsNullOrEmpty(TxtWhiteSurname.Text) ? "" : TxtWhiteSurname.Text;
            string whiteElo = string.IsNullOrEmpty(TxtWhiteElo.Text) ? "?" : TxtWhiteElo.Text;
            string whiteNational = string.IsNullOrEmpty(CmbWhiteNational.Text) ? "World" : CmbWhiteNational.Text;
            string whiteTeam = string.IsNullOrEmpty(TxtWhiteTeam.Text) ? "No Team" : TxtWhiteTeam.Text;

            string blackName = string.IsNullOrEmpty(TxtBlackName.Text) ? "White" : TxtBlackName.Text;
            string blackSurname = string.IsNullOrEmpty(TxtBlackSurname.Text) ? "" : TxtBlackSurname.Text;
            string blackElo = string.IsNullOrEmpty(TxtBlackElo.Text) ? "?" : TxtBlackElo.Text;
            string blackNational = string.IsNullOrEmpty(CmbBlackNational.Text) ? "World" : CmbBlackNational.Text;
            string blackTeam = string.IsNullOrEmpty(TxtBlackTeam.Text) ? "No Team" : TxtBlackTeam.Text;

            string round = string.IsNullOrEmpty(TxtRound.Text) ? "?" : TxtRound.Text;
            string date = ChbDateNull.Checked ? "No Date" : DtpDate.Value.ToString("yyyyMMdd"); ;
            string result = string.IsNullOrEmpty(CmbResult.Text) ? "?" : CmbResult.Text;

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"White : {whiteSurname}, {whiteName} -- Elo : {whiteElo} -- National : {whiteNational} -- Team : {whiteTeam}");
                writer.WriteLine();
                writer.WriteLine($"Black : {blackSurname}, {blackName} -- Elo : {blackElo} -- National : {blackNational} -- Team : {blackTeam}");
                writer.WriteLine();
                writer.WriteLine($"Round {round} -- Date : {date} -- Result : {result}");
                writer.WriteLine();
                writer.WriteLine();

                foreach (var item in moves)
                {
                    writer.WriteLine(item);
                }
            }
        }

        void AddMove(string move)
        {
            if (!string.IsNullOrEmpty(move))
            {
                if (moveHalf % 2 == 0)
                {
                    whiteMove = move;
                    moves.Add($"{moveNumber}- {whiteMove}, ");
                }
                else
                {
                    moves.RemoveAt(moves.Count - 1);
                    moves.Add($"{moveNumber}- {whiteMove}, {move}");
                    moveNumber++;
                }

                moveHalf++;
                LstMoves.Items.Clear();
                foreach (var item in moves)
                {
                    LstMoves.Items.Add(item);
                }
            }
        }
        #endregion       
    }
}
