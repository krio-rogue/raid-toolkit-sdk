using System;
using System.Threading.Tasks;
using SuperSocket;
using SuperSocket.Channel;
using SuperSocket.WebSocket.Server;

namespace Raid.Service
{
    public class SessionFactory : ISessionFactory
    {
        public int SessionCount { get; private set; }
        public SessionFactory()
        {
        }

        public Type SessionType => typeof(WebSocketSession);

        public IAppSession Create()
        {
            WebSocketSession session = new WebSocketSession();
            session.Connected += OnConnected;
            session.Closed += OnClosed;
            return session;
        }

        private ValueTask OnClosed(object sender, CloseEventArgs e)
        {
            --SessionCount;
            return ValueTask.CompletedTask;
        }

        private ValueTask OnConnected(object sender, EventArgs e)
        {
            ++SessionCount;
            return ValueTask.CompletedTask;
        }
    }
}