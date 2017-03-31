var chessHub = $.connection.chessHub;

chessHub.client.recieveMessage = function (sender, message) {
	var $message = $("<div />", {
		role: "alert",
		text: [sender, message].join(": ")
	});

	$message.addClass("alert chat-message");

	var $messages = $(".chat-messages").first();
	$messages.append($message);
	$messages.scrollTop($messages.prop("scrollHeight"));
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

function getBoardState() {
	chessHub.server.getBoardState().done(setBoardState);
}
