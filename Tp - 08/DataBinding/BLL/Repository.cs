using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repository
    {
        public List<Client> ClientList { get; set; } = new List<Client>();


        public void Incluir(Client client)
        {
            ClientList.Add(client);
        }

       
        public void Remover(Client client)
        {
                 
            ClientList.Remove(client);

        }
    }
}
