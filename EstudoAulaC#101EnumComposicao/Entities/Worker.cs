using EstudoAulaC_101EnumComposicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_101EnumComposicao.Entities
{
    internal class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> contracts { get; set; } = new List<HourContract>();
        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
