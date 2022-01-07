using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //colunas que serão chave estrangeiras da tabela
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
