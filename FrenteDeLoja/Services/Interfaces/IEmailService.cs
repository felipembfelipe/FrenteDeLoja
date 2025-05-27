using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeLoja.Services.Interfaces
{
    public interface IEmailService
    {
        Task<bool> EnviarEmailRecuperacao(string destino, string usuario, string senha);
    }
}
