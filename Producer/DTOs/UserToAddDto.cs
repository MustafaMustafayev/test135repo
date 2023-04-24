namespace Producer.DTOs
{
    public record UserToAddDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
