using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SampleSignalRDemo.Modules.Chat {
    /// <summary>
    /// 发送消息服务器枢纽
    /// 通过枢纽分发给所有客户端
    /// </summary>
    [HubName("ChatHub")]//枢纽命名为ChatHub 否则默认名称为类目(首字母小写)
    public class ChatHub:Hub {
        /// <summary>
        /// 发送Message
        /// </summary>
        [HubMethodName("SendMessage")]//命名服务器函数的名称 否则默认为函数名称(首字母小写) 
        public void SendMessage(string msg) {
            //调用客户端func SendMessage
            Clients.All.LoadMessage(msg);
        }
    }
}