using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        public TodoItem[] Items {get; set;}//Guardar en la variable Items un arreglo de TodoItems

    }
}