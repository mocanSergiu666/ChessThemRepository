function toBoardCoordinates(coordinates, boardSize) {
	var boardCoordinates = {
		x: 0,
		y: 0
	};

	var cellWidth = boardSize.width / 8;
	var cellHeight = boardSize.height / 8;

	if (playerColor == "White") {
		boardCoordinates.x = Math.floor(coordinates.x / cellWidth);
		boardCoordinates.y = 7 - Math.floor(coordinates.y / cellHeight);
	}

	if (playerColor == "Black") {
		boardCoordinates.x = 7 - Math.floor(coordinates.x / cellWidth);
		boardCoordinates.y = Math.floor(coordinates.y / cellHeight);
	}

	return boardCoordinates;
}

function fromBoardCoordinates(boardCoordinates, boardSize) {
	var coordinates = {
		x: 0,
		y: 0
	};

	var cellWidth = boardSize.width / 8;
	var cellHeight = boardSize.height / 8;

	if (playerColor == "White") {
		coordinates.x = boardCoordinates.x * cellWidth;
		coordinates.y = boardSize.height - cellHeight - boardCoordinates.y * cellHeight;
	}

	if (playerColor == "Black") {
		coordinates.x = boardSize.width - cellWidth - boardCoordinates.x * cellWidth;
		coordinates.y = boardCoordinates.y * cellHeight;
	}

	return coordinates;
}

function toFixedPositionOnBoard(position, boardSize) {
	var cellWidth = boardSize.width / 8;
	var cellHeight = boardSize.height / 8;

	return {
		x: Math.round(position.x / cellWidth) * cellWidth,
		y: Math.round(position.y / cellHeight) * cellHeight
	};
}

function setBoardState(state) {
	var $board = $(".chess-board-container").first();

	var boardSize = {
		width: $board.width(),
		height: $board.height()
	};

	for (var index in state) {
		var boardCoordinates = state[index].position;
		var pieceColor = state[index].pieceColor;
		var pieceType = state[index].pieceType;
		
		var coordinates = fromBoardCoordinates(boardCoordinates, boardSize);

		var $piece = $("<div />");

		$piece.addClass("chess-piece-container");
		if (pieceColor === playerColor) {
			$piece.addClass("draggable");
		}
		$piece.css({ left: coordinates.x, top: coordinates.y });

		var $pieceImage = $("<img />");

		$pieceImage.addClass("chess-piece img-responsive");
		$pieceImage.attr("src", [window.location.origin, "/Images/ChessImages/Pieces/", pieceColor, pieceType, ".png"].join(""));
		$pieceImage.appendTo($piece);

		$piece.appendTo($board);
	}

	setPiecesDraggable();
}

function clearBoardState() {
	$(".chess-piece-container").remove();
}

function setPiecesDraggable() {
	$(".chess-piece-container.draggable").draggable({
		addClasses: false,
		containment: "parent",
		opacity: 0.75,
		zIndex: 1,
		stop: onStopDraggingChessPiece
	});
}
