using Microsoft.AspNetCore.SignalR;

namespace SampleSignalRDemo.Hubs {
    public class ChatHub:Hub {//中心控制器
        /// <summary>
        /// 服务器端发送消息
        /// </summary>
        /// <param name="message"></param>
        [HubMethodName("SendMessage")]
        public void SendMessage(string message) {
            Clients.All.SendAsync("ReceiveMessage",message);//客户端接收消息方法
        }
    }
}