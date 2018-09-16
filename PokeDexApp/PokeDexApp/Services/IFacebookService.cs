using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp.Services
{
    public interface IFacebookService
    {
        Task<bool> LoginAsync();
        string UserId { get;  }
        string AccessToken { get;  }        
    }
}
