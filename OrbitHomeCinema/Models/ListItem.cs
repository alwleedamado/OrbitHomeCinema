using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitHomeCinema.Models
{
    public record ListItem(int Id, string Name, Action Open);
}
