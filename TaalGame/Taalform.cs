using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace TaalGame
{
    public partial class Taalform : Form
    {
        private List<Question> currentQuestions { get; set; }
        private List<Question> StamQuestions = new List<Question>();
        private List<Question> StateQuestions = new List<Question>();
        private List<Question> SubjectQuestions = new List<Question>();
        private List<Button> answerButtons = new List<Button>();

        private static SerialPort usedPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        private Messages messages = new Messages(usedPort);

        private Random rnd = new Random();
        public int numberQuestion;
        private int correct;
        private int incorrect;
        private int total;
        private int score;

        public Taalform()
        {
            InitializeComponent();
            currentQuestions = StamQuestions;
            answerButtons.Add(AnswerA);
            answerButtons.Add(AnswerB);
            answerButtons.Add(AnswerC);
            answerButtons.Add(AnswerD);

            foreach (var button in answerButtons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = BackColor;
                button.FlatAppearance.MouseOverBackColor = BackColor;
                button.FlatAppearance.MouseDownBackColor = BackColor;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            #region Stam Questions

            StamQuestions.Add(new Question(questionText: "Wat is de stam van lopen", correctAnswer: "loop",
                new[] { "lop", "loop", "lope", "loope" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van roepen", correctAnswer: "roep",
                new[] { "roepe", "roepp", "roep", "rop" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van eten", correctAnswer: "eet",
                new[] { "eten", "et", "eet", "ete" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van fietsen", correctAnswer: "fiets",
                new[] { "fiet", "fietse", "fietsen", "fiets" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van stelen", correctAnswer: "steel",
                new[] { "stel", "steel", "stele", "stelen" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van werken", correctAnswer: "werk",
                new[] { "werk", "werke", "werkk", "werken" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van spelen", correctAnswer: "speel",
                new[] { "spel", "speel", "spele", "spell" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van lezen", correctAnswer: "lees",
                new[] { "lees", "lez", "leze", "les" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van rijden", correctAnswer: "rijd",
                new[] { "rijt", "rijd", "rijde", "rijte" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van zwemmen", correctAnswer: "zwem",
                new[] { "zwem", "zwemm", "zweme", "zwemme" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van rennen", correctAnswer: "ren",
                new[] { "ren", "renn", "reen", "rene" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van krijgen", correctAnswer: "krijg",
                new[] { "kreeg", "krijge", "krijg", "krijgen" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van delen", correctAnswer: "deel",
                new[] { "dele", "deel", "del", "delen" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van beven", correctAnswer: "beef",
                new[] { "beef", "beve", "bev", "beev" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van geven", correctAnswer: "geef",
                new[] { "geef", "gef", "gev", "gev" }));
            StamQuestions.Add(new Question(questionText: "Wat is de stam van draaien", correctAnswer: "draai",
                new[] { "draie", "draaie", "drai", "draai" }));

            #endregion Stam Questions

            #region State Questions

            StateQuestions.Add(new Question(questionText: "(Lopen) Ik .... naar huis.", correctAnswer: "loop",
                new[] { "loop", "loopt", "lopen", "loopd" }));
            StateQuestions.Add(new Question(questionText: "(Fietsen) Piet .... graag in de middag.",
                correctAnswer: "fietst", new[] { "fiets", "fietse", "fietst", "fietsen" }));
            StateQuestions.Add(new Question(questionText: "(Roepen) Jan.... naar Jannike.", correctAnswer: "roept",
                new[] { "roep", "roepen", "roept", "roepd" }));
            StateQuestions.Add(new Question(questionText: "(Maken) Wij .... ons huiswerk.", correctAnswer: "maken",
                new[] { "maakd", "maak", "maakt", "maken" }));
            StateQuestions.Add(new Question(questionText: "(Geven) Ik .... Mandy een cadeau.", correctAnswer: "geef",
                new[] { "geeft", "geef", "geven", "geefd" }));

            #endregion State Questions

            #region Subject Questions

            SubjectQuestions.Add(new Question("Wij zijn naar een voetbal wedstrijd gegaan.", "Wij",
                new[] { "Wij", "naar", "voetbal", "wedstrijd" }));
            SubjectQuestions.Add(new Question("Gisteren is de bank beroofd.", "de bank",
                new[] { "bank", "de bank", "Gisteren", "is" }));
            SubjectQuestions.Add(new Question("De supermarkt zit helemaal vol met eten.", "De supermarkt",
                new[] { "eten", "vol met eten", "De supermarkt", "supermarkt" }));
            SubjectQuestions.Add(new Question("Zorg ervoor dat jij je huiswerk morgen af hebt.", "jij",
                new[] { "je", "huiswerk", "Zorg", "jij" }));
            SubjectQuestions.Add(new Question("Ik speel graag met mijn vrienden spelletjes.", "Ik",
                new[] { "Ik", "vrienden", "spelletjes", "mijn vrienden" }));
            SubjectQuestions.Add(new Question("Voor het avondeten moet jij je handen wassen.", "jij",
                new[] { "avondeten", "jij", "je", "wassen" }));
            SubjectQuestions.Add(new Question("Ik heb mijn telefoon gisteren laten vallen.", "Ik",
                new[] { "mijn telefoon", "telefoon", "Ik", "vallen" }));
            SubjectQuestions.Add(new Question("Britt is gisteren ziek naar huis gegaan.", "Britt",
                new[] { "huis", "gegaan", "ziek", "Britt" }));
            SubjectQuestions.Add(new Question("Ik en Rick hebben gisteren een tekening gemaakt.", "Ik en Rick",
                new[] { "Ik en Rick", "Rick", "Ik", "tekening" }));
            SubjectQuestions.Add(new Question("Mijn opa heeft een grote postzegel verzameling.", "Mijn opa",
                new[] { "opa", "Mijn opa", "postzegel", "grote postzegel" }));

            #endregion Subject Questions

            SetUI();
            CheckSignal.Start();
        }

        public void GiveAnswerA(object sender, EventArgs e)
        {
            if (TextAnswerA.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                CorrectAnswer();
                SetUI();
            }
            if (TextAnswerA.Text != currentQuestions[numberQuestion].CorrectAnswer)
            {
                IncorrectAnswer();
                SetUI();
            }
        }

        private void GiveAnswerB(object sender, EventArgs e)
        {
            if (TextAnswerB.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                CorrectAnswer();
                SetUI();
            }
            if (TextAnswerB.Text != currentQuestions[numberQuestion].CorrectAnswer)
            {
                IncorrectAnswer();
                SetUI();
            }
        }

        private void GiveAnswerC(object sender, EventArgs e)
        {
            if (TextAnswerC.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                CorrectAnswer();
                SetUI();
            }
            if (TextAnswerC.Text != currentQuestions[numberQuestion].CorrectAnswer)
            {
                IncorrectAnswer();
                SetUI();
            }
        }

        private void GiveAnswerD(object sender, EventArgs e)
        {
            if (TextAnswerD.Text == currentQuestions[numberQuestion].CorrectAnswer)
            {
                CorrectAnswer();
                SetUI();
            }
            if (TextAnswerD.Text != currentQuestions[numberQuestion].CorrectAnswer)
            {
                IncorrectAnswer();
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

            ScoreLive.Text = score.ToString();
            messages.clearIncomingData();
            total++;

            using (dbi441943Entities DbContext = new dbi441943Entities())
            {
                var getUser = DbContext.AspNetUsers.Where(s => s.Email == "ryanhouben1998@gmail.com").FirstOrDefault();

                var newScore = new LanguageGameScore()
                {
                    AspNetUser = getUser,
                    Correct = correct,
                    InCorrect = incorrect,
                    TotalScore = total,
                    ResultDateTime = DateTime.Now
                };

                DbContext.LanguageGameScores.Add(newScore);

                DbContext.SaveChanges();
            }
        }

        private void CorrectAnswer()
        {
            correct++;
            score++;
        }

        private void IncorrectAnswer()
        {
            incorrect++;
            score--;

            if (score < 0)
            {
                score = 0;
            }
        }

        private void ChangeToStam(object sender, EventArgs e)
        {
            currentQuestions = StamQuestions;
            correct = 0;
            SetUI();
        }

        private void ChangeToSpelling(object sender, EventArgs e)
        {
            currentQuestions = StateQuestions;
            correct = 0;
            SetUI();
        }

        private void ChangeToSubject(object sender, EventArgs e)
        {
            currentQuestions = SubjectQuestions;
            correct = 0;
            SetUI();
        }

        private void CheckSignal_Tick(object sender, EventArgs e)
        {
            messages.Receive(usedPort);

            switch (messages.extractedData)
            {
                case "A":
                    AnswerA.PerformClick();
                    break;

                case "B":
                    AnswerB.PerformClick();
                    break;

                case "C":
                    AnswerC.PerformClick();
                    break;

                case "D":
                    AnswerD.PerformClick();
                    break;

                case "1":
                    ModeStam.PerformClick();
                    break;

                case "2":
                    ModeSpelling.PerformClick();
                    break;

                case "3":
                    ModeSubject.PerformClick();
                    break;

                case "4":
                    StartTest.PerformClick();
                    break;
            }

            /*
                        if (messages.extractedData == "A")
                        {
                            AnswerA.PerformClick();
                        }

                        if (messages.extractedData == "B")
                        {
                            AnswerB.PerformClick();
                        }

                        if (messages.extractedData == "C")
                        {
                            AnswerC.PerformClick();
                        }

                        if (messages.extractedData == "D")
                        {
                            AnswerD.PerformClick();
                        }

                        if (messages.extractedData == "1")
                        {
                            ModeStam.PerformClick();
                        }

                        if (messages.extractedData == "2")
                        {
                            ModeSpelling.PerformClick();
                        }

                        if (messages.extractedData == "3")
                        {
                            ModeSubject.PerformClick();
                        }

                        if (messages.extractedData == "4")
                        {
                            StartTest.PerformClick();
                        }*/
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            List<Question> TestQuestions = new List<Question>();
            for (int i = 0; i < 20; i++)
            {
                int GetQuestion = rnd.Next(0, 4);
                switch (GetQuestion)
                {
                    case 1:
                        TestQuestions.Add(StamQuestions[rnd.Next(0, StamQuestions.Count)]);
                        break;

                    case 2:
                        TestQuestions.Add(StateQuestions[rnd.Next(0, StateQuestions.Count)]);
                        break;

                    case 3:
                        TestQuestions.Add(SubjectQuestions[rnd.Next(0, SubjectQuestions.Count)]);
                        break;
                }
            }

            currentQuestions = TestQuestions;
            correct = 0;
            SetUI();
        }
    }
}