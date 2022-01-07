using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.FluentMap.Dommel.Mapping;
using Domain.Entities;

namespace Repository.Mappers
{
    public class TeamMap : DommelEntityMap<Team>
    {
        public TeamMap()
        {
            ToTable("TB_TIME");
            Map(x => x.id).ToColumn("ID").IsKey();
            Map(x => x.Name).ToColumn("NM_TIME");
        }
    }
}
