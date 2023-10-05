using Owin;

namespace Digital_Clock_WFApp.Chat
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app) => app.MapSignalR();
    }
}
