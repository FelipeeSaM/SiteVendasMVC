using System.Collections.Generic;
using System;
using System.Linq;

namespace SiteVendasMVC.Models {
    public class Department {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //department possui vários vendedores

        public Department() {

        }

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }

        public void AddSaller(Seller seller) {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime dataInicial, DateTime dataFinal) {
            return Sellers.Sum(seller => seller.TotalSales(dataInicial, dataFinal));
        }
    }
}
