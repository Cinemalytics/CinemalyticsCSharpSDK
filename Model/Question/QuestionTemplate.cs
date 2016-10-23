using System;
using System.Collections.Generic;

namespace CinemalyticsCSharpSDK.Model.Question
{
    public class QuestionTemplate
    {
        public String Title { get; set; }
        public List<AnswerOption> AnswerOptions { get; set; }
        public int AnswerKey { get; set; }
    }
}
