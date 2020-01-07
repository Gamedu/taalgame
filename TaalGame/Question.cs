using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaalGame
{
    class Question
    {
        public Question(string questionText, string correctAnswer, string[] answers)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
            Answers = answers;
        }
        
        public string QuestionText { get; set; }
        public string [] Answers { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
