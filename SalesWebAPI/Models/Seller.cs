using System.ComponentModel.DataAnnotations;

namespace SalesWebAPI.Models
{
    public class Seller
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve ter no mínimo {2} e no máximo {1} ")] // 0 - Propriedade, 1 - Máximo, 2 - Mínimo
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [EmailAddress(ErrorMessage = "Entre com um e-mail válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")] //apelido da tabela que será mostrado na view
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} Requerido")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(100.0,50000.0, ErrorMessage = "{0} deve ser de no mínimo {1} e no máximo {2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department departament)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
