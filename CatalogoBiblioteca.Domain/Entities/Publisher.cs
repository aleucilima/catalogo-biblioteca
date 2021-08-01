namespace CatalogoBiblioteca.Domain.Entities
{
    public class Publisher
    {
        public int Id { get; set; }

        public string CNPJ { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}