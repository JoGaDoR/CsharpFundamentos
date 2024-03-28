using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosClasses.Pessoa;

    public class Pessoa
    {
        private string? nome;

        public string Nome
        {
            get { return nome ?? ""; }
            set { nome = value; }
        }
    }
