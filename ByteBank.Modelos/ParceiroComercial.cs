using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        AutenticarHelper _autenticarHelper = new AutenticarHelper();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticarHelper.CompararSenhar(Senha, senha);
        }
    }
}