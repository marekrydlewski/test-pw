﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using RydlewskiJablonski.Quiz.DAO.BO;
using RydlewskiJablonski.Quiz.Interfaces;

namespace RydlewskiJablonski.Quiz.UI.ViewModels
{
    public class AnswerViewModel : INotifyPropertyChanged
    {
        private IAnswer _answer;

        public AnswerViewModel(IAnswer answer)
        {
            _answer = answer;
            _isSelectedAnswer = false;
        }

        public AnswerViewModel()
        {
            _answer = new Answer();
            _isSelectedAnswer = false;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Id
        {
            get { return _answer.Id; }
            set
            {
                _answer.Id = value;
                OnPropertyChanged();
            }
        }

        public string Text
        {
            get { return _answer.Text; }
            set
            {
                _answer.Text = value;
                OnPropertyChanged();
            }
        }

        public bool IsCorrect
        {
            get { return _answer.IsCorrect; }
            set
            {
                _answer.IsCorrect = value;
                OnPropertyChanged();
            }
        }

        private bool _isSelectedAnswer;

        public bool IsSelectedAnswer
        {
            get { return _isSelectedAnswer; }
            set
            {
                _isSelectedAnswer = value;
                OnPropertyChanged();
            }
        }
    }
}