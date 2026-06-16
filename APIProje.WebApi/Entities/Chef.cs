namespace APIProje.WebApi.Entities
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string NameSurname { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
    }
}