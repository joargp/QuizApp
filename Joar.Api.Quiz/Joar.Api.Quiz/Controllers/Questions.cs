using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Joar.Api.Quiz.Models;

namespace Joar.Api.Quiz.Controllers
{
	public class QuestionsController : ApiController
	{
	    private readonly IQuestionRepository questionRepository = new QuestionRepository();

      // If you are using Dependency Injection, you can delete the following constructor
        public QuestionsController() : this(new QuestionRepository())
        {
        }

        public QuestionsController(IQuestionRepository countryRepository)
        {
            this.questionRepository = countryRepository;
        }

		public IEnumerable<Question> GetAll()
		{
		    return questionRepository.All;
		}

		public Question Get(int id)
		{
		    return questionRepository.Find(id);
		}

		public HttpResponseMessage Post(Question item)
		{
			throw new NotImplementedException();
		}

		public HttpResponseMessage Put(int id, Question item)
		{
			throw new NotImplementedException();
		}

		public HttpResponseMessage Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}