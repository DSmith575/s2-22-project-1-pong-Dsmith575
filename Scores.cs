using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using static System.Formats.Asn1.AsnWriter;
using System.IO;

namespace Pong
{
    public class Scores
    {
        protected const int MAXSCORELIST = 5;
        protected string[] addScore = new string[1];
        protected string[] scoreBoard = new string[1];


        protected string pFinalScore = " ";
        protected string cFinalScore = " ";
        protected string highScoreDisplay = " ";



        //Pulls the variables from controller class and adds them to an array
        public void StoreScores(string playScore, string cpuScore)
        {
            pFinalScore = playScore;
            cFinalScore = cpuScore;
            addScore[0] = $"Player: {pFinalScore} | CPU: {cFinalScore}";
            MessageBox.Show(addScore[0]);
            SaveScores();
        }

        //Writes from array to text file.
        public void SaveScores()
        {
            StreamWriter sw = new StreamWriter(@"../../HighScores.txt", true);
            //int lineCount = File.ReadAllLines(@"../../HighScores.txt").Length;
            //if (lineCount < MAXSCORELIST)
            //{
                sw.WriteLine($"{addScore[0]}");
                sw.Close();
            //}
            


        }
       
        public void LoadScoreToMessageBox()
        {
            scoreBoard = File.ReadLines(@"../../HighScores.txt").ToArray();
            highScoreDisplay = string.Join(Environment.NewLine, scoreBoard);
            MessageBox.Show(highScoreDisplay);

        }











    }
}
