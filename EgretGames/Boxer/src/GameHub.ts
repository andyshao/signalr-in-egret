/// <reference path="../libs/jquery/jquery.d.ts" />
/// <reference path="../libs/signalr/signalr.d.ts" />

interface IGameClient {
    serverNotify(message: string): void;
}

interface IGameServer {
    sendToServer(message: string): JQueryPromise<string>;
}

interface Proxy extends SignalR.Hub.Proxy {
    client: IGameClient;
    server: IGameServer;
}

interface SignalR {
    gameHub: Proxy;
}
