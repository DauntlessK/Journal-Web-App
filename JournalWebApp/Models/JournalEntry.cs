namespace JournalWebApp.Models
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Entry { get; set; }

        public JournalEntry()
        {
               
        }
    }
}
