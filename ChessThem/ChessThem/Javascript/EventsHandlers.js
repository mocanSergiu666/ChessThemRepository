function onHomeMenuSelectItem(event) {
	event.preventDefault();

	$(this).tab('show');
}

function onChatSend(event) {
	event.preventDefault();

	var message = $(".chat-input").val();

	if (message != "") {
		$(".chat-input").val("")
		sendMessage(message);
	}
}

function onChatToggle(event) {
	var $toggler = $(this);

	if ($toggler.hasClass("glyphicon-resize-small")) {
		$(".chat-body").hide(100, function () {
			$toggler.removeClass("glyphicon-resize-small");
			$toggler.addClass("glyphicon-resize-full");

		});
	}
	else
		if ($toggler.hasClass("glyphicon-resize-full")) {
			$(".chat-body").show(100, function () {
				$toggler.removeClass("glyphicon-resize-full");
				$toggler.addClass("glyphicon-resize-small");
			});
		}
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

function onWindowResize() {
	clearBoardState();
	getBoardState();
}
