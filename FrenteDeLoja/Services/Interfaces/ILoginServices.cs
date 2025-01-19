using FrenteDeLoja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeLoja.Services.Interfaces
{
    public interface ILoginServices
    {
        Task<Usuario> Login(string login, string senha);
    }
}
