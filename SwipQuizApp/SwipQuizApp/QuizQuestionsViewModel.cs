using System;
using System.Collections.Generic;
using System.Text;

namespace SwipQuizApp
{
    public class QuizQuestionsViewModel
    {


        public QuizQuestionsViewModel(string title, bool answer)
        {

            Title = title;
            Answer = answer;
        }

        public string Title { private set; get; }

        public bool Answer { private set; get; }

        public string Image { private set; get; }

        static QuizQuestionsViewModel()
        {
            All = new List<QuizQuestionsViewModel>
            {

                new QuizQuestionsViewModel("Are Husky puppies the cutest ever?", true),

                new QuizQuestionsViewModel("Is this a good question?", false),

                new QuizQuestionsViewModel("Did Joshua Below write this code?", true),

                new QuizQuestionsViewModel("is this a quiz?", true),

                new QuizQuestionsViewModel("Is there 28 hours in a day?", false),


            };
        }

        public static IList<QuizQuestionsViewModel> All { private set; get; }


    }

}
