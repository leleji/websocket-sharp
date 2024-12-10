// See https://aka.ms/new-console-template for more information
using WebSocketSharp;

Console.WriteLine("Hello, World!");

var wsUrl = "wss://webcast3-ws-web-lq.douyin.com/webcast/im/push/?app_name=douyin_web&version_code=180800&webcast_sdk_version=1.3.0&update_version_code=1.3.0&compress=gzip&imprp=u6ywl_b3cAwAUCxYAAAAAAAABZSSe&internal_ext=internal_src:dim|wss_push_room_id:7159215242470378253|wss_push_did:7129619158803629606|dim_log_id:202210280223440101351620330E0972A3|fetch_time:1666895024543|start_time:0|seq:1|next_cursor:t-1666895024543_r-1_d-1_u-1_h-1|next_live_cursor:u-1_d-1|door:0-n45|wss_info:0-1666895024543-0-0&cursor=t-1666895024543_r-1_d-1_u-1_h-1&host=https://live.douyin.com&aid=6383&live_id=1&did_rule=3&debug=false&entpoint=live_pc&device_platform=web&cookie_enabled=true&screen_width=1920&screen_height=1080&browser_language=zh-CN&browser_platform=Win32&browser_name=Mozilla&browser_version=5.0%20(Windows%20NT%2010.0;%20Win64;%20x64)%20AppleWebKit/537.36%20(KHTML,%20like%20Gecko)%20Chrome/106.0.0.0%20Safari/537.36&browser_online=true&tz_name=Asia/Shanghai&identity=audience&room_id=7159215242470378253&heartbeatDuration=0";
wsUrl=System.Web.HttpUtility.HtmlDecode(wsUrl);
var wSocket = new WebSocket(wsUrl);
wSocket.EmitOnPing = false;
wSocket.Origin = "https://live.douyin.com";
wSocket.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
wSocket.Headers.Add("Cookie", "ttwid=1%7CBzYAxRRpGzvfqG-CHvVC3cd718-q8CqAu9GKvRf-PQk%7C1666895366%7C24af476aa5fdf37fc4320b7341104971e793fceedad1c8783a9ce1ea31c64a3b");
//wSocket.Headers.Add("Connection", "Upgrade");
wSocket.Headers.Add("Pragma", "no-cache");
wSocket.Headers.Add("Cache-Control", "no-cache");
wSocket.Headers.Add("Accept-Encoding", "gzip, deflate, br");
wSocket.Headers.Add("Accept-Language", "zh-CN,zh;q=0.9,en;q=0.8");
wSocket.Compression = CompressionMethod.Deflate;
#if DEBUG
wSocket.SetProxy("http://192.168.5.10:8888", null, null);
#endif
wSocket.OnClose += (sender, e) =>
{
    Console.WriteLine("连接服务器错误..");

};
wSocket.OnError += (sender, e) =>
{
    Console.WriteLine("连接服务器错误..");
};

wSocket.OnOpen += (sender, e) =>
{
    Console.WriteLine("连接成功..");
};
wSocket.OnMessage += (sender, e) =>
{
    //Task.Run(async () => await ProtobufDeserialize(e.RawData));
};
try
{
    wSocket.Connect();

}
catch (Exception ez)
{

    throw;
}
