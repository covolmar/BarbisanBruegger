// Get the container element
var listContainer = document.getElementById("rentItems");

// Get all buttons with class="btn" inside the container
var items = listContainer.getElementsByTagName("li");

// Loop through the buttons and add the active class to the current/clicked button
for (var i = 0; i < items.length; i++) {
	items[i].addEventListener("click", function () {
		var current = document.getElementsByClassName("active");
		current[0].className = current[0].className.replace(" active", "");
		this.className += " active";
	});
}