using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBPM
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string ImagePath { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string questionText, string imagePath, string correctAnswer)
        {
            QuestionText = questionText;
            ImagePath = imagePath;
            CorrectAnswer = correctAnswer;
        }
    }
}
