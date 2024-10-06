namespace HumbleCompany.web.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly contractDate { get; set; }

        public bool IsActive { get; set; }
    }
 }
