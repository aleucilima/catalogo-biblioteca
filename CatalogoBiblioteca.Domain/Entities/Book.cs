namespace CatalogoBiblioteca.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string Release { get; set; }

        public virtual Publisher Publisher { get; set; }

        public int PublisherId { get; set; }

        public virtual Author Author { get; set; }

        public int AuthorId { get; set; }
    }
}