using System;

namespace CinemalyticsCSharpSDK.Model.Question
{
    public class Question
    {
        public String Id { get; set; }
        public QuestionTemplate QuestionTemplate { get; set; }
        public String EntityId { get; set; }
        public String EntityType { get; set; }
        public String BriefAnswer { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
