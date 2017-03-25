function toBoardCoordinates(coordinaes, boardSize) {
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

function fromBoardCoordinates(boardCoordinaes, boardSize) {
	var coordinates = {
		x: 0,
		y: 0
	};

	// TODO
}

function toFixedPositionOnBoard(position, boardSize) {
	var cellWidth = boardSize.width / 8;
	var cellHeight = boardSize.height / 8;

	return {
		x: Math.round(position.x / cellWidth) * cellWidth,
		y: Math.round(position.y / cellHeight) * cellHeight
	};
}
