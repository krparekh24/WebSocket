using System.Net.Http;
// create web socket connection.
private async Task HandleWebSocketConnection(HttpContext context, WebSocket webSocket)
{
try
{
using (var httpClient = new HttpClient())
{
while (webSocket.State == WebSocketState.Open)
{
// Make an HTTP request to the external API
var response = await httpClient.GetAsync("http://dev-sample-api.tsl-timing.com/");
if (response.IsSuccessStatusCode)
{
var data = await response.Content.ReadAsStringAsync();
var buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(data));
await webSocket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
}
await Task.Delay(2000); // Simulate data updates every 2 seconds
}
}
}
catch (Exception ex)
{
// Handle exceptions
}
finally
{
if (webSocket.State == WebSocketState.Open)
{
await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Connection closed", CancellationToken.None);
}
webSocket.Dispose();
}
}