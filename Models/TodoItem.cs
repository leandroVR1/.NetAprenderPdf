using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id {get;set;}//un GUID o un Identificador Global Único.
        public bool IsDone {get;set;}
        [Required]
        public string Title {get;set;}
        public DateTimeOffset? DueAt {get;set;}
    }
}