

let toggle1 = document.querySelector(".dorpdowntoogle2");


let toggle2 = document.querySelectorAll(".dropdownmenu li a")

for (const item of toggle2) {
  item.addEventListener("click", function () {
    toggle1.innerText = item.innerText;
  });
}




let dropdown1 = document.querySelector(".dropdowntoggle");

let flags = document.querySelectorAll(".flags-list li")

for (const item2 of flags) {
  // item2.lastElementChild.firstElementChild

  item2.addEventListener("click", function () {
    let image = this.firstElementChild.getAttribute("src");
    let text = this.lastElementChild.innerText;

    dropdown1.firstElementChild.setAttribute("src", image);
    dropdown1.lastElementChild.innerText = text;
  });
}
