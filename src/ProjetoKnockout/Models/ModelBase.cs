using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoKnockout.Entities;

namespace ProjetoKnockout.Models
{
    public class ModelBase
    {
        public DatabaseContext Context { get; set; }
        public HttpSessionStateBase Session { get; set; }
        public virtual void LoadDefaultValues() { }
    }
}