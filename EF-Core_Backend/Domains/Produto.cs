using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Backend.Domains
{

    public class Produto : BaseDomain
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        [NotMapped]
        [JsonIgnore]
        public IFormFile Imagem { get; set; }

        public string UrlImagem { get; set; }

        public List<PedidoItem> PedidosItens { get; set; }

        public Produto()
        {
           Id = Guid.NewGuid();
        }
    }
}