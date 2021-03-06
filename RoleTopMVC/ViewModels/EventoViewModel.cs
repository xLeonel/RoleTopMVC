using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class EventoViewModel : BaseViewModel
    {
        public List<Evento> Eventos { get; set; }
        public List<Evento> EventosAprovado { get; set; }
        public List<Evento> EventosReprovado { get; set; }
        public Cliente Cliente { get; set; }
        public List<Evento> Pacotes { get; set; }
        public string[]  StatusEnum {get;set;}
        public string[]  PrivacidadeEvento {get;set;}
        public string[] StatusClienteEnum {get;set;}
        public List<Pergunta> Perguntas {get;set;}
        public string FotoEvento {get;set;}
        public List<Cliente> Clientes {get;set;}
        public List<Cliente> ClientesBanido { get; set; }
       
        public EventoViewModel()
        {
            this.Cliente = new Cliente();
            this.Eventos = new List<Evento>();
            this.EventosAprovado = new List<Evento>();
            this.EventosReprovado = new List<Evento>();
            this.Pacotes = new List<Evento>();
        }

    }
}