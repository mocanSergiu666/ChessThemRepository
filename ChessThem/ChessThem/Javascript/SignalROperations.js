var chessHub = $.connection.chessHub;

chessHub.client.recieveMessage = function (sender, message) {
	var $message = $("<div />", {
		role: "alert",
		text: [sender, message].join(": ")
	});

	$message.addClass("alert chat-message");

	$(".chat-messages").append($message);
}

chessHub.client.performPlayerMove = function (from, to) {

}

function initializeConnection() {	
	var connectionOptions = { transport: ["webSockets", "serverSentEvents", "foreverFrame", "longPolling"] };
	$.connection.hub.logging = true;
	$.connection.hub.error(onHubError);
	$.connection.hub.connectionSlow(onHubConnectionSlow);
	$.connection.hub.disconnected(onHubDisconnected);
	$.connection.hub.url = "/chesssignalr"
	$.connection.hub.start().done(onHubStartDone).fail(onHubStartFail);
}

function tryMove() {
	return chessHub.server.tryMove();
}

function sendMessage(message) {
	chessHub.server.sendMessage(message);
}
