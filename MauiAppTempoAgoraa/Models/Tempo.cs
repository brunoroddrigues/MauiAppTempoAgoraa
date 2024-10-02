using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTempoAgoraa.Models
{
    public class Tempo
    {
        public string? title { get; set; }
        public string? temperature { get; set; }
        public string? wind { get; set; }
        public string? humidity { get; set; } 
        public string? visibility { get; set; }
        public string? sunrise { get; set; }
        public string? sunset { get; set; }
        public string? weather { get; set; }
        public string? weatherDescription { get; set; }
    } // fim da classe 
}
