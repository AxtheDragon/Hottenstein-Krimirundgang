namespace Krimirundgang
{
    public class Tour
    {
        public string Name { get; set; }

        public string Content { get; set; }

        public Tour(string name, string content = null)
        {
            Name = name;
            Content = content;
        }
    }
}