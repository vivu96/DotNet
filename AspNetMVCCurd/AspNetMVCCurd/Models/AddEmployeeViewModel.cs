namespace AspNetMVCCurd.Models
{
    public class AddEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public int Phone { get; set; }

        public double Salary { get; set; }

        public DateTime dateofBirth { get; set; }
        public string Department { get; set; }
   

    }
}
