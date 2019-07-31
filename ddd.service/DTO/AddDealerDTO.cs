using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.service.DTO
{
    public class AddDealerDTO
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public decimal EleMoney { get; set; }
        public Guid? Parentid { get; set; }
        public List<string> ContactNames { get; set; }
        public List<string> ContactTels { get; set; }
        public List<string> ContactProvinces { get; set; }
        public List<string> ContactCities { get; set; }
        public List<string> ContactZeors { get; set; }
        public List<string> ContactStreets { get; set; }
        public List<int> IsDefaultContact { get; set; }
    }
}
