namespace Producer.DTOs
{
    public record UserToUpdateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
