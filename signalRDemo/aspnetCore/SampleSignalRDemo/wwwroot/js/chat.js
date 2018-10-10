var connection = new signalR.HubConnectionBuilder().withUrl("/ChatHub").build();//创建链接
connection.on("ReceiveMessage", function (message) {//客户端ReceiveMessage方法 从中心接收消息并处理
    var li = '<li>' + message + '</li>';
    $("#messages").append(li);
});
connection.start().catch(function (err) {//开始链接
//    return console.error(err.toString());//打印错误日志
});
$("#send").click(function () {//点击发送按钮
    if ($("#sendMsg").val().trim() !== "") {
        var message = $("#sendMsg").val().trim();
        connection.invoke("SendMessage", message).then(result => {//回调函数
            $("#sendMsg").val("");
        }).catch(function (err) {//调用中心SendMessage方法
//            return console.error(err.toString());//打印错误日志
        });
    }
});