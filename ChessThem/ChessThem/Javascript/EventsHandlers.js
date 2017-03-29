function onHomeMenuSelectItem(event) {
	event.preventDefault();
	$(this).tab('show');
}

function onChatSend(event) {
	event.preventDefault();
	var message = $(".chat-input").val();
	$(".chat-input").val("")
	sendMessage(message);
}

function onStopDraggingChessPiece(event, ui) {
	var boardSize = {
		width: ui.helper.parent().width(),
		height: ui.helper.parent().height()
	};

	var startPosition = {
		x: ui.originalPosition.left,
		y: ui.originalPosition.top
	};
	var stopPosition = {
		x: ui.position.left,
		y: ui.position.top
	};

	var elementHalfWidth = ui.helper.width() / 2;
	var elementHalfHeight = ui.helper.height() / 2;

	var from = {
		x: startPosition.x + elementHalfWidth,
		y: startPosition.y + elementHalfHeight
	};
	var to = {
		x: stopPosition.x + elementHalfWidth,
		y: stopPosition.y + elementHalfHeight
	};

	var isMoved = tryMove(toBoardCoordinates(from, boardSize), toBoardCoordinates(to, boardSize));

	if (isMoved) {
		var fixedStopPosition = toFixedPositionOnBoard(stopPosition, boardSize);
		ui.helper.css({
			left: fixedStopPosition.x,
			top: fixedStopPosition.y
		});
	}
	else {
		ui.helper.css({
			left: startPosition.x,
			top: startPosition.y
		});
	}
}
