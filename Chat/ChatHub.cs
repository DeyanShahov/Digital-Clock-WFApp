using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Clock_WFApp.Chat
{
    public class ChatHub : Hub
    {
        public static List<string> Usernames = new List<string>();
        public static List<string> Messages = new List<string>();
        public static int MaxMessages = 50;

        public void Send(string message, string username)
        {
            Messages.Add($"{username}: {message}");

            if(Messages.Count > MaxMessages )
            {
                Messages = Messages.Skip(Messages.Count - MaxMessages).ToList();
            }

            //Clients.All.Send(message, username);
            Clients.All.Send(message, username);
        }

        public void RegisterUser(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                if (!Usernames.Contains(username))
                {
                    Usernames.Add(username);
                    Clients.All.Send($"{username} logged in.");
                }
                else
                {
                    Clients.Caller.Send($"Name {username} already exist.");
                }
            }         
        }

        public void ChangeUsername(string oldUsername, string newUsername)
        {
            if (!string.IsNullOrEmpty(oldUsername) && !string.IsNullOrEmpty(newUsername))
            {
                if(Usernames.Contains(oldUsername) && !Usernames.Contains(newUsername))
                {
                    Usernames[Usernames.IndexOf(oldUsername)] = newUsername;
                    Clients.All.Send($"{oldUsername} change his name to {newUsername}.");
                }
                else
                {
                    Clients.Caller.Send($"Name {newUsername} already exist.");
                }
            }
        }

        public void UnregisterUser(string username)
        {
            Usernames.Remove(username);
            Clients.All.Send($"{username} leave chat.");
        }

    }
}
