function onHubError() {

}

function onHubConnectionSlow() {

}

function onHubDisconnected() {

}

function onHubStartDone() {
	getBoardState();
}

function onHubStartFail() {
	var modalOptions = {
		backdrop: "static",
		keyboard: true,
		show: true
	};
	$("#connection-fail").modal(modalOptions);
}
