using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipQuizApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IList<string> strList = new List<string>();
        IList<string> imageList = new List<string>();
        IList<QuizQuestionsViewModel> questions = new List<QuizQuestionsViewModel>();
        private int correct;
        private int wrong;

        int index;
        public MainPage()
        {
            questions = QuizQuestionsViewModel.All;

            InitializeComponent();
            //strList.Add("Flower Box");
            //strList.Add("Onion Patch");
            //strList.Add("Lettuce Lattice");
            //strList.Add("Tomato Tub");
            //imageList.Add("flower_box.jpg");
            //imageList.Add("flower_box.jpg");
            //imageList.Add("flower_box.jpg");
            //imageList.Add("flower_box.jpg");
            index = 0;
        }

        //void ResetQuiz(object sender, EventArgs e)
        //{

        //}


        void OnSwiped(object sender, SwipedEventArgs e)
        {
            if(index < questions.Count)
            {
                theLabel.Text = e.Direction.ToString() + " " + index;
                if (e.Direction == SwipeDirection.Right)
                {
                    if (questions[index].Answer == false)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (e.Direction == SwipeDirection.Left)
                {
                    if (questions[index].Answer == true)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
            }            

            if (index >= questions.Count - 1)
            {
                theLabel.Text = "You Answered: " + correct + " correct" + " / Wrong: " + wrong;
                theImage.Source = "finished.png";
                //this is for the if check on line 47
                index++;
            }
            else
            {
                theLabel.Text = questions[index].Title;
                theImage.Source = questions[index].Image;
                index++;
            }


        }

    }
}
