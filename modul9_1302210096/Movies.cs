namespace modul9_1302210096
{
    public class Movies
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; } = new List<string>();
        public string Description { get; set; }


        public Movies(string Title, string Director, List<string> Stars, string Description)
        {
            this.Title = Title;
            this.Director = Director;
            this.Stars = Stars;
            this.Description = Description;

        }
    }
}
