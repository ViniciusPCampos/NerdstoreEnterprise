using System.Text.RegularExpressions;
using NSE.Core.DomainObjects;

namespace NSE.Clients.API.Models
{
    public class Email
    {
        public const int EnderecoMaxLength = 254;
        public const int EnderecoMinLength = 5;
        
        public string Endereco { get; private set; }

        // EF
        public Email()
        {
                
        }

        public Email(string endereco)
        {
            if(Validar(endereco)) throw new DomainException("E-mail inválido.");
            Endereco = endereco;
        }

        public static bool Validar(string email)
        {
            var regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            return regex.IsMatch(email);
        }
    }
}