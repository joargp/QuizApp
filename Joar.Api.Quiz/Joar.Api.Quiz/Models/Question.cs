using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joar.Api.Quiz.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

        public float Rating { get; set; }
    }
}