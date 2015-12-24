
open System.Net.Sockets
open System.Text

let client = new TcpClient()
client.Connect("127.0.0.1", 4711)

let stream = client.GetStream()
let msg = Encoding.UTF8.GetBytes("chat.post(Merry Christmas from F#)\n")
stream.Write(msg, 0, msg.Length)

