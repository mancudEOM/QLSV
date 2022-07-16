namespace QLSV.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public string? Semeter { get; set; }
        public DateTime StartDateRent { get; set; }
        public DateTime DueDateRent { get; set; }             

    }
}