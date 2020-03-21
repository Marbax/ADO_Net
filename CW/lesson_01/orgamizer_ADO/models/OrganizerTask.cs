namespace orgamizer_ADO.models
{
    public class OrganizerTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Term { get; set; }

        public int CategoryId { get; set; }
    }
}
