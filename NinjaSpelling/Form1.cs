using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinjaSpelling
{
    public partial class Form1 : Form
    {
        // declare variables to use for the list of phrases
        private string phrase;
        private string[] words;
        private string hideWord;

        // declare variables to use for the timer
        private int secs = 120;
        private TimeSpan t;

        // declare variable to use for the score and lifes
        private int totalCorrect = 0;
        private int totalWrong = 0;
        private int attemptsLife = 5;

        // declare variable to use to speeak
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10
            SetTimer();
        }

        // initialize timer from 2min
        private void SetTimer()
        {
            secs = 120;
            t = TimeSpan.FromSeconds(secs);
            label2.Text = $"{t.Minutes.ToString().PadLeft(2, '0')}:{t.Seconds.ToString().PadLeft(2, '0')}";
            timer1.Enabled = true;
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            gameScreen.Visible = true;
            startBut.Visible = false;
            scoreScreen.Visible = false;
            attemptsLife = 5;
            ClearPhrase();
            SetTimer();
        }

        // get new phrase from the list
        private void ClearPhrase()
        {

            var fullPath = $"{AppDomain.CurrentDomain.BaseDirectory}Files\\wordlist.txt";
            var s = GetPhrase(fullPath);
            txbWord.Text = s;
            labRemainingLives.Text = (attemptsLife).ToString();
            textLetter.Text = string.Empty;
        }

        // get new phrase from the list
        private string GetPhrase(string pathSource)
        {
            List<string> lisPrhases = new List<string>();
            using (StreamReader sr = new StreamReader(pathSource))
            {
                while (sr.Peek() >= 0) // make the porgam pick the next phrase
                {
                    string line = sr.ReadLine();
                    lisPrhases.Add(line);
                }
            }

            var x = lisPrhases.Count();
            var r = new Random();
            var n = r.Next(0, x - 1);

            phrase = lisPrhases.ToArray()[n];

            words = phrase.Split(' ');
            phrase = string.Empty;

            hideWord = words[0];

            for (int i = 2; i < words.Length; i++)
            {
                phrase += $"{words[i]} ";
            }

            phrase = phrase.Trim();
            words = phrase.Split(' ');

            synthesizer.SpeakAsync(phrase);

            return phrase.ToLower().Replace(hideWord, "_");
        }

        // check typed word
        private void textLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var dword = textLetter.Text;
                if (dword.ToLower().Equals(hideWord))
                {
                    // set successfully message depend on level
                    var message = string.Empty;
                    switch (attemptsLife)
                    {
                        case 4:
                            message = "brillant, keep yourself in the lead";
                            break;
                        case 3:
                            message = "Congratulations, you're the super sumo of nimja spelling";
                            break;
                        case 2:
                            message = "keep going, never give up";
                            break;
                        case 1:
                            message = "you've almost lost pal";
                            break;
                    }

                    synthesizer.SpeakAsync(message);
                    txbWord.Text = txbWord.Text.Replace("_", dword);
                    ClearPhrase();
                    totalCorrect++;
                }
                else
                {
                    // if the word is not correct, take one life and check if it's the last one to end the game and show the scores
                    attemptsLife -= 1;
                    labRemainingLives.Text = (attemptsLife).ToString();
                    totalWrong++;
                    if (attemptsLife == 0)
                    {
                        synthesizer.Speak("Game Over, Baby!");
                        timer1.Enabled = false;
                        gameScreen.Visible = false;
                        startBut.Visible = true;
                        scoreScreen.Visible = true;
                        lblTotalC.Text = $"Correct: {totalCorrect}";
                        lblTotalW.Text = $"Wrong: {totalWrong}";
                    }
                }
            }
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            // repeat the phrase
            synthesizer.SpeakAsync(phrase);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // remove one second from the timer
            secs -= 1;
            t = TimeSpan.FromSeconds(secs);
            label2.Text = $"{t.Minutes.ToString().PadLeft(2, '0')}:{t.Seconds.ToString().PadLeft(2, '0')}";

            // if time is out end the game and show the scores
            if (secs.Equals(0))
            {
                timer1.Enabled = false;
                synthesizer.Speak("Time Out!");
                scoreScreen.Visible = true;
                lblTotalC.Text = $"Correct: {totalCorrect}";
                lblTotalW.Text = $"Wrong: {totalWrong}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
