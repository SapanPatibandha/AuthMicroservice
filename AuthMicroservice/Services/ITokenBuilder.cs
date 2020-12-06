using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthMicroservice.Services
{
    public interface ITokenBuilder
    {
        string BuildToken(string username);
    }
}
