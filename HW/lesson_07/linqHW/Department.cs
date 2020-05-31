namespace linqHW
{
    class Department
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public override string ToString() => $"{Id} , {Country} , {City}";
    }

}
