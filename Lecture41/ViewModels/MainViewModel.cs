using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture41.Command;
using System.Windows.Input;

namespace Lecture41.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private BaseViewModel selectedViewModel;

        public BaseViewModel SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        public ICommand UpdateViewCommand { get; set; }
        public MainViewModel()
        {
            UpdateViewCommand = new DelegateCommand(ViewSelector, canExecute);
            selectedViewModel = new HomeViewModel();
        }

        bool canExecute(object o)
        {
            return true;
        }

        void ViewSelector(object o)
        {

            if ((o as string).Equals("Student"))
            {
                SelectedViewModel = new StudentViewModel();
            }
            else if ((o as string).Equals("Course"))
            {
                SelectedViewModel = new CourseViewModel();
            }
            else if ((o as string).Equals("Home"))
            {
                SelectedViewModel = new HomeViewModel();
            }
        }
    }
}
