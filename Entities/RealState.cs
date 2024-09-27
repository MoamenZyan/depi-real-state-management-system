namespace depi_real_state_management_system.Entities
{
    // RealState entity ---> الانتيتي الخاصه بالعقارات
    public class RealState
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; } // يوزر صاحب العقار او المكان دا

        public virtual ApplicationUser User { get; set; } = null!; // reference بتاع اليوزر
    }
}
