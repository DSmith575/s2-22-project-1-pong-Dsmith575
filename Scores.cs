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
        protected const int NEWSCORE = 4; //Array position for inserting newest score to txt file
        protected string[] addScore = new string[1];

        //Shifts the lineReader array to the left to make room for new highscores
        protected string[] lineReaderShift = new string[MAXSCORELIST];
        protected string pFinalScore = " ";
        protected string cFinalScore = " ";
        protected string highScoreDisplay = " ";

        protected int lineCount; //variable for n lines in txt file

        //Pulls the variables from controller class and adds them to an array
        public void StoreScores(string playScore, string cpuScore)
        {
            pFinalScore = playScore;
            cFinalScore = cpuScore;
            addScore[0] = $"Player: {pFinalScore} | CPU: {cFinalScore}";
            string finalScore = "Final Score!";
            MessageBox.Show(addScore[0], finalScore);
            SaveScores();
            LoadScoreToMessageBox();
        }

        //Creates on startup if no file exists
        public void CreateScoreBoard()
        {
            StreamWriter sw = new StreamWriter(@"../../HighScores.txt");
            sw.Close();
        }


        //Writes from array to text file.
        public void SaveScores()
        {
            //Checks how many lines there are in txt file and stores in variable
            lineCount = File.ReadAllLines(@"../../HighScores.txt").Count();

            if (lineCount < MAXSCORELIST) //If less than 5 lines, appends file to insert new value(score)
            {
                StreamWriter sw = new StreamWriter(@"../../HighScores.txt", true);
                sw.WriteLine($"{addScore[0]}");
                sw.Close();
            }

            if (lineCount >= MAXSCORELIST) //If there are more than 5 lines of text, sorts the arrays into a new array shifted left (remove first line)
            {

                string[] lineReader = File.ReadAllLines(@"../../HighScores.txt");

                for (int i = 1; i < lineReader.Length; i++)
                {
                    lineReaderShift[i - 1] = lineReader[i];
                }

                //Adds the latest score to the last slot of the array
                lineReaderShift[NEWSCORE] = addScore[0];

                StreamWriter sw = new StreamWriter(@"../../HighScores.txt");
                {
                    for (int i = 0; i < lineReaderShift.Length; i++)
                    {
                        sw.WriteLine(lineReaderShift[i]);
                    }
                }
                sw.Close();
            }
        }

        public void LoadScoreToMessageBox()
        {
            string displayScores = string.Join(Environment.NewLine, lineReaderShift);
            string scoreBoard = "ScoreBoard";
            MessageBox.Show(displayScores, scoreBoard);
        }
    }
}
