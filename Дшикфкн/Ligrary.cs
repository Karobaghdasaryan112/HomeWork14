using Library;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryes
{
    internal class Library : IEnumerable
    {
        public Books[] Books = new Books[]
        {
            new Books("The Algorithm Design Manual", "Steven S. Skiena", "Эта книга предлагает практический подход к проектированию алгоритмов, с упором на реальное применение."),
            new Books("Introduction to Algorithms", "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein", "Охватывает широкий спектр алгоритмов и их приложений."),
            new Books("Algorithms", "Robert Sedgewick, Kevin Wayne", "Основные алгоритмы и структуры данных с практическими примерами и задачами."),
            new Books("Data Structures and Algorithm Analysis in C#", "Michael T. Goodrich, Roberto Tamassia, Michael H. Goldwasser", "Фокусируется на анализе структур данных и алгоритмов в C#."),
            new Books("Effective Java", "Joshua Bloch", "Советы по лучшему использованию языка программирования (много принципов применимо и к C#)."),
            new Books("Clean Code", "Robert C. Martin", "Как писать чистый и поддерживаемый код."),
            new Books("Design Patterns: Elements of Reusable Object-Oriented Software", "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", "Книга по проектированию шаблонов для объектно-ориентированного программирования."),
            new Books("The Pragmatic Programmer", "Andrew Hunt, David Thomas", "Советы и лучшие практики для программистов."),
            new Books("Refactoring: Improving the Design of Existing Code", "Martin Fowler", "Методы улучшения дизайна существующего кода."),
            new Books("Understanding Machine Learning: From Theory to Algorithms", "Shai Shalev-Shwartz, Shai Ben-David", "Основы машинного обучения от теории до практических алгоритмов.")
        };
        public Library()
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {   
            return new LibraryEnumerator(Books);
        }
    }
    internal class LibraryEnumerator : IEnumerator
    {
        private Books[] _books;
        private int _CurrentIndex = -1;
        public LibraryEnumerator(Books[] books)
        {
            _books = books;
        }
        public bool MoveNext()
        {
            _CurrentIndex++;
            if(_CurrentIndex < _books.Length)
            {
                return true;
            }
            return false;
        }
        public Object Current
        {
            get
            {
                if (_CurrentIndex < 0 || _CurrentIndex >=_books.Length)
                {
                    throw new InvalidOperationException();
                }
                return _books[_CurrentIndex];
            }
        }
        public void Reset()
        {
            _CurrentIndex = -1;
        }
    }

}
