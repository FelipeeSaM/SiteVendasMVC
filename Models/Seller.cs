using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVendasMVC.Models {
    public class Seller {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord SR) {
            Sales.Add(SR);
        }

        public void RemoveSales(SalesRecord SR) {
            Sales.Remove(SR);
        }

        public double TotalSales(DateTime initial, DateTime final) {
            return Sales.Where(sr => sr.date >= initial && sr.date <= final).Sum(sr => sr.amount);
        }
    }
}
