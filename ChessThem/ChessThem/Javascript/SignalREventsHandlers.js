function onHubError() {

}

function onHubConnectionSlow() {

}

function onHubDisconnected() {

}

function onHubStartDone() {

}

function onHubStartFail() {
	var modalOptions = {
		backdrop: "static",
		keyboard: true,
		show: true
	};
	$("#connection-fail").modal(modalOptions);
}
