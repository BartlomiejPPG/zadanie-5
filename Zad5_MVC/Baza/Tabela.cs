using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Zad5_MVC.Baza
{
    public class Tabela
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string PESEL { get; set; } = default!;
        public int BirthYear { get; set; } = default!;
        public int Płeć { get; set; } = default!;
    }
}
