using PokeDexApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp.Models
{

    public class MsPageMenuItem
    {
        public MsPageMenuItem()
        {
            TargetType = typeof(MsPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}