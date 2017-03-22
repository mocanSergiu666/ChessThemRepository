$("#home-menu .nav a").click(function (event) {
	event.preventDefault();
	$(this).tab('show');
});

$("button.connect").click(function (event) {
	event.preventDefault();
	connect($(this).closest(".tab-pane").attr("id"));
});

$(".chess-piece-container.draggable").draggable({
	addClasses: false,
	containment: "parent",
	opacity: 0.75,
	revert: revertDraggedChessPiece,
	revertDuration: 0,
	zIndex: 1
});

function revertDraggedChessPiece() {
	return !isMoveValid();
}

function isMoveValid() {
	return false;
}
