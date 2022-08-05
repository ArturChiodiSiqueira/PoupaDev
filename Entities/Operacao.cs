using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoupaDev.Enums;

namespace PoupaDev.Entities
{
        public class Operacao
        {
            public Operacao(decimal valor, TipoOperacao tipo, int idObjetivo)
        {
            Id = new Random().Next(1, 1000);
            Valor = valor;
            Tipo = tipo;
            IdObjetivo = idObjetivo;
            DataOperacao = DateTime.Now;
            IdObjetivo = idObjetivo;
        }

        public int Id { get; private set; }
            public decimal Valor { get; private set; }
            public TipoOperacao Tipo { get; private set; }
            public DateTime DataOperacao { get; set; }
            public int IdObjetivo { get; set; }
    }
}
