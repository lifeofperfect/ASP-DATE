using DatingAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser request);
    }
}
