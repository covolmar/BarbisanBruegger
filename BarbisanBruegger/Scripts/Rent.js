"use strict";


// Function Declerations











// Add Eventlistner to list Elements
var listContainer = document.getElementById("rentItems");
var items = listContainer.getElementsByTagName("li");

for (var i = 0; i < items.length; i++) {
	items[i].addEventListener("click", function () {
		var current = document.getElementsByClassName("active");

		// If there's no active class
		if (current.length > 0) {
			current[0].className = current[0].className.replace(" active", "");
		}

		this.className += " active";
	})
}




