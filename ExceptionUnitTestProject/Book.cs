using System;

namespace ExceptionUnitTestProject
{
   public class Book
    {
        private const string YearRange = "Year must be between 1100 and 2019";
        private const string TwoCharLong = "Title must be 2 character long";
        private string _title;
        private int _year;


        public string Title
        {
            get { return _title;}
            set
            {
                CheckTitle(value);
                _title = value;
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                CheckYear(value);
                _year = value;
            }
        }

        public Book(string title, int year)
        {
            CheckTitle(title);
            CheckYear(year);
            _title = title;
            _year = year;
        }

        public Book()
        {

        }

        // Throw exception if value not fulfill the requirement  
        public void CheckTitle(string title)
        {
            if (title != null && (!string.IsNullOrEmpty(title) && (title.Length < 2)) )
            {
                throw  new ArgumentException(TwoCharLong);
            }
        }
        public void CheckYear(int year)
        {
            if ((year < 1100) || (year > 2019))
            {
                throw new ArgumentOutOfRangeException(YearRange);
            }
        }   
    }
}
