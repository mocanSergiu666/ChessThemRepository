$("#home-menu .nav a").click(onHomeMenuSelectItem);

$(".chat-send").click(onChatSend);

$(".chess-piece-container.draggable").draggable({
	addClasses: false,
	containment: "parent",
	opacity: 0.75,
	zIndex: 1,
	stop: onStopDraggingChessPiece
});
