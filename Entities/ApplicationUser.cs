namespace depi_real_state_management_system.Entities
{
    // User entity ----> الانتيتي بتاعه اليوزر
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual List<RealState> RealStates { get; set; } = new List<RealState>(); // references ---> كل العقارات بتاعه اليوزر لو عنده
    }
}
