using System.Configuration;
using System.Drawing.Drawing2D;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using static System.Formats.Asn1.AsnWriter;

namespace Pong
{
    public class Scores
    {
        protected string[] scoreBoard = new string[1];

        protected string pFinalScore = " ";
        protected string cFinalScore = " ";

        public void ArrayTester()
        {
            scoreBoard[0] = $"Player: {pFinalScore} | CPU: {cFinalScore}";
        }


        public void LoadScoreToMessageBox()
        {
        }

        public void StoreScores(string playScore, string cpuScore)
        {
            pFinalScore = playScore;
            cFinalScore = cpuScore;
            ArrayTester();
            MessageBox.Show(scoreBoard[0]);
            SaveScores();
        }

        public void SaveScores()
        {
            StreamWriter sr = new StreamWriter(@"../../HighScores.txt", true);
                sr.WriteLine($"{scoreBoard[0]}");
            sr.Close();
        }




    }
}
