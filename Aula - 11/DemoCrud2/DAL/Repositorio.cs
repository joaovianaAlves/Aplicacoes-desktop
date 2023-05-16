using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL
{
    public class Repositorio
    {

        private IMongoCollection<Agenda> _agenda;

        public List<Agenda> ListaAgenda
        {
            get
            {
                var filter = Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>();
            }
        }

        public Repositorio()
        {
            var mongoClient = new MongoClient("mongodb+srv://joao216508:1234@cluster0.ppcpyai.mongodb.net/Agenda?retryWrites=true&w=majority");
            var mongoDatabase = mongoClient.GetDatabase("Agenda");
            _agenda = mongoDatabase.GetCollection<Agenda>("agenda");

        }

    }
}