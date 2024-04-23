using DISample.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISample.Services
{
    public class ProductServices : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return [
                new () {Id = 1, Name = "Alex"},
                new () {Id = 2, Name = "Sancho"},
                new () {Id = 3, Name = "Ronaldo"},
                new () {Id = 4, Name = "Messi"},
                new () {Id = 5, Name = "Mbappe"}
            ];
        }
    }
}
