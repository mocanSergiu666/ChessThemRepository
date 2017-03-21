var connectionModeId;
var chessHub = $.connection.chessHub;
var connectionOptions = { transport: ["webSockets", "serverSentEvents", "foreverFrame", "longPolling"] };

function onHubError() {

}

function onHubConnectionSlow() {

}

function onHubDisconnected() {

}

function onHubStartDone() {
	var url = "/Home/Connect/";
	window.location.href = window.location.origin + url;
}

function onHubStartFail() {
	var options = {
		backdrop: "static",
		keyboard: true,
		show: true
	};
	$("#connection-fail").modal(options);
}

$.connection.hub.logging = true;
$.connection.hub.error(onHubError);
$.connection.hub.connectionSlow(onHubConnectionSlow);
$.connection.hub.disconnected(onHubDisconnected);

function connect(modeId) {
	connectionModeId = modeId;
	$.connection.hub.start().done(onHubStartDone).fail(onHubStartFail);
}
