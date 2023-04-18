using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

    namespace bll
    {
        public class ConsultaCep
        {
            private readonly HttpClient _httpClient;
            public ConsultaCep()
            {
                _httpClient = new HttpClient();
            }
            
            public cep Consultar(string CepConsulta)
            {
            //cep cepRetorno = new cep();
            //cepRetorno.Bairro = "Boqueirao";
            //cepRetorno.Logradouro = "Rua Oswaldo Cruz";
            //cepRetorno.Complemento = "lado par";
            //cepRetorno.Ddd = "13";
            //cepRetorno.Localidade = "Santos";
            //cepRetorno.Cep = "11045-90";

                return _httpClient.GetFromJsonAsync<cep>($"https://viacep.com.br/ws/{CepConsulta}/json/") .Result;
         
            }

        }
    }

