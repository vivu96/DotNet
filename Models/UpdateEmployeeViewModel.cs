namespace AspNetMVCCurd.Models
{
    public class UpdateEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public int Phone { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }
        public DateTime dateofBirth { get; set; }
    }
}
