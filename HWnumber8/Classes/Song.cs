using System;

namespace HWnumber8Lab.Classes
{
    internal class Song
    {
        private string name;
        private string author;

        public Song(string nameOfSong, string authorOfSong)
        {
            name = nameOfSong;
            author = authorOfSong;
        }

        public Song()
        {
        }

        #region Methods

        /// <summary>
        /// Метод для заполнения названия композиции
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Метод для заполнения имени автора
        /// </summary>
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        /// <summary>
        /// Метод для заполнения поля prev
        /// </summary>
        public void inputPrev()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }
        /// <summary>
        /// Метод для вывода информации о песне на печать
        /// </summary>
        public void Title()
        {
            Console.WriteLine(Name + Author);
        }

        #endregion

    }
}
