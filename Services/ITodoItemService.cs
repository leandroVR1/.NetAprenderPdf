using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services{

    public interface ITodoItemService
    {
        /*El tipo  Task  es similar un futuro o promesa, y se usa aquí porque este
        método sera asíncrono. En otras palabras es posible que el método no pueda
        ser capaz de regresar la lista de tareas pendientes de forma inmediata porque
        necesita primero interactuar con la base de datos primero*/
        Task<TodoItem[]> GetIncompleteItemsAsync();

        Task<bool> AddItemAsync(TodoItem newItem);
    }
}