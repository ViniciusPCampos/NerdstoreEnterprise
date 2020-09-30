using NSE.Core.DomainObjects;

namespace NSE.Clients.API.Models
{
    public class Cliente : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public bool Excluido { get; private set; }
        public Endereco Endereco { get; private set; }

        public Cliente(string name, string email, string cpf)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            Excluido = false;
        }
    }

    public class Endereco : Entity
    {
        
    }
}