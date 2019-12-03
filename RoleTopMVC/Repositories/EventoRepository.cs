using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class EventoRepository
    {
        private const string PATH = "Database/Evento.csv";

        public List<Evento> ObterTodos()
        {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                string[] dados = linha.Split(";");
                evento.Nome = dados[0];
                eventos.Add(evento);
            }

            return eventos;
        }
        
    }
}