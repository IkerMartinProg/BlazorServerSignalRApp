using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Hubs
{
    public class ChatHub : Hub
    {
        /* 
            El método "SendMessage" recibe dos campos: el nombre del usuario 
            y su correspondiente mensaje.
            El contenido, anteriormente mencionado, se enviará a todas las
            ventanas que hayan accedido al chat común.
        */

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
