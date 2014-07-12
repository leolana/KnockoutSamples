using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjGridJson.Models
{
    public class Pessoa1
    {
        private String _nome;
        private String _sobrenome;
        private String _idade;

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public String Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }

        public String Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
    }
}