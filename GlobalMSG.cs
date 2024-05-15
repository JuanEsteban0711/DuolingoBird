using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSG_GameOver
{
    class GlobalMSG
    {
        public static string ResultDialog;
        public static void MessageBox_Show(string ScoreActual, string ScoreAnt)
        {
            MSG_Game_Over MSG = new MSG_Game_Over();
            MSG.Score.Text = ScoreActual;
            MSG.Best.Text = ScoreAnt;

            
            MSG.ShowDialog();

            if (MSG.DialogResult == DialogResult.Yes)
            {
               ResultDialog = "Yes";
            }
            else if(MSG.DialogResult == DialogResult.No)
            {
                ResultDialog = "No";
            }

            MSG.Close();
        }
    }
}
