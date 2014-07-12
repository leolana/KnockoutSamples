using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjGridJson.Models
{
    public class Bonus
    {
        private Idade idade;

        public double ConcederBonusIdoso(int idade)
        {
            this.idade.idade = idade;
            return this.idade.idade * 5.9;
        }
    }
}