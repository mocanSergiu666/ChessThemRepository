$("#home-menu .nav a").click(function (event) {
	event.preventDefault();
	$(this).tab('show');
});

$("button.connect").click(function (event) {
	event.preventDefault();
	connect($(this).closest(".tab-pane").attr("id"));
});
