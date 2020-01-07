using MediaFoundation.OPM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Media;

namespace TaalGame
{
    public partial class Taalform : Form
    {
        private List<Question> StamQuestions = new List<Question>();
        private List<Question> StateQuestions = new List<Question>();
        private List<Question> currentQuestions { get; set; }
        
        Random rnd = new Random();
        public int numberQuestion;
        private int score;

        public Taalform()
        {
            InitializeComponent();
            currentQuestions = StamQuestions;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            #region Stam Questions
            StamQuestions.Add(new Question(questionText: "Wat is de stam van lopen", correctAnswer: "lop", new[] { "lop", "loop", "lope", "loope" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van roepen", correctAnswer: "roep", new[] { "roepe", "roepp", "roep", "rop" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van eten", correctAnswer: "et", new[] { "eten", "et", "eet", "ete" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van fietsen", correctAnswer: "fiets", new[] { "fiet", "fietse", "fietsen", "fiets" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van stelen", correctAnswer: "stel", new[] { "stel", "steel", "stele", "stelen" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van werken", correctAnswer: "werk", new[] { "werk", "werke", "werkk", "werken" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van spelen", correctAnswer: "spel", new[] { "spel", "speel", "spele", "spell" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van lezen", correctAnswer: "lez", new[] { "lees", "lez", "leze", "les" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van rijden", correctAnswer: "rijd", new[] { "rijt", "rijd", "rijde", "rijte" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van zwemmen", correctAnswer: "zwemm", new[] { "zwem", "zwemm", "zweme", "zwemme" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van rennen", correctAnswer: "renn", new[] { "ren", "renn", "reen", "rene" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van krijgen", correctAnswer: "krijg", new[] { "kreeg", "krijge", "krijg", "krijgen" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van delen", correctAnswer: "del", new[] { "dele", "deel", "del", "delen" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van beven", correctAnswer: "bev", new[] { "beef", "beve", "bev", "beev" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van geven", correctAnswer: "gev", new[] { "geef", "gef", "gev", "gev" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van draaien", correctAnswer: "draai", new[] { "draie", "draaie", "drai", "draai" }));
            #endregion
            #region State Questions
            StateQuestions.Add(new Question(questionText: "(Lopen) Ik .... naar huis.", correctAnswer: "loop", new []{"loop","loopt","lopen","loopd"}));
            StateQuestions.Add(new Question(questionText: "(Fietsen) Piet .... graag in de middag.", correctAnswer: "fietst", new[] { "fiets", "fietse", "fietst", "fietsen" }));
            StateQuestions.Add(new Question(questionText: "(Roepen) Jan.... naar Jannike.", correctAnswer: "roept", new[] { "roep", "roepen", "roept", "roepd" }));
            StateQuestions.Add(new Question(questionText: "(Maken) Wij .... ons huiswerk.", correctAnswer: "maken", new[] { "maakd", "maak", "maakt", "maken" }));
            StateQuestions.Add(new Question(questionText: "(Geven) Ik .... Mandy een cadeau.", correctAnswer: "geef", new[] { "geeft", "geef", "geven", "geefd" }));
            #endregion
            SetUI();
        }
        
        
    public void GiveAnswerA(object sender, EventArgs e)
        {
            if (TextAnswerA.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                score++;
                SetUI();
            }
        }
    private void GiveAnswerB(object sender, EventArgs e)
        {
            if (TextAnswerB.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                score++;
                SetUI();
            }
        }
    private void GiveAnswerC(object sender, EventArgs e)
        {
            if (TextAnswerC.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                score++;
                SetUI();
            }
        }
    private void GiveAnswerD(object sender, EventArgs e)
        {
            if (TextAnswerD.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                score++;
                SetUI();
            }
        }

        private void SetUI()
        {
            numberQuestion = rnd.Next(0, currentQuestions.Count);

            CurrentQuestion.Text = currentQuestions[numberQuestion].QuestionText;
            TextAnswerA.Text = currentQuestions[numberQuestion].Answers[0];
            TextAnswerB.Text = currentQuestions[numberQuestion].Answers[1];
            TextAnswerC.Text = currentQuestions[numberQuestion].Answers[2];
            TextAnswerD.Text = currentQuestions[numberQuestion].Answers[3];

            ResultAnswer.Text = "Punten : "+score.ToString();
        }

        private void ChangeToStam(object sender, EventArgs e)
        {
            currentQuestions = StamQuestions;
            score = 0;
            SetUI();
        }

        private void ChangeToSpelling(object sender, EventArgs e)
        {
            currentQuestions = StateQuestions;
            score = 0;
            SetUI();
        }

        private void Taalform_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    e.Handled = true;
                    AnswerA.PerformClick();
                    break;
                case Keys.B:
                    e.Handled = true;
                    AnswerB.PerformClick();
                    break;
                case Keys.C:
                    e.Handled = true;
                    AnswerC.PerformClick();
                    break;
                case Keys.D:
                    e.Handled = true;
                    AnswerD.PerformClick();
                    break;
            }
        }
    }
}
