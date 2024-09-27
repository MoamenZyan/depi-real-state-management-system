namespace depi_real_state_management_system.Entities
{
    // انتيتي بستلم فيها بيانات تسجيل دخول اليوزر
    public class UserCredentials
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
