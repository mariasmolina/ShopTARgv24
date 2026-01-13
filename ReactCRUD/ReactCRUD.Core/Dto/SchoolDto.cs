namespace ReactCRUD.Core.Dto
{
    public class SchoolDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int StudentCount { get; set; }
    }
}
