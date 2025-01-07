function tablazat() {
  let sor = document.getElementById("sor").value;
  let oszlop = document.getElementById("oszlop").value;
  let table = document.createElement("table");
  table.setAttribute("id", "table");

  for (let i = 0; i < sor; i++) {
    let tr = document.createElement("tr");
    for (let j = 0; j < oszlop; j++) {
      let td = document.createElement("td");
      tr.appendChild(td);
    }
    table.appendChild(tr);
  }

  updateCounter(sor * oszlop);

  makeTableDraggable(table);
  makeTableDeletable(table);

  document.getElementById("left").appendChild(table);
}

function makeTableDraggable(table) {
  let isDragging = false;
  let offsetX, offsetY;

  table.style.position = 'absolute';

  table.addEventListener('mousedown', function (e) {
    isDragging = true;
    offsetX = e.clientX - table.offsetLeft;
    offsetY = e.clientY - table.offsetTop;
    table.style.cursor = 'move';
  });

  document.addEventListener('mousemove', function (e) {
    if (isDragging) {
      table.style.left = e.clientX - offsetX + 'px';
      table.style.top = e.clientY - offsetY + 'px';
    }
  });

  document.addEventListener('mouseup', function () {
    isDragging = false;
    table.style.cursor = 'default';
  });
}

function makeTableDeletable(table) {
  table.addEventListener('dblclick', function () {
    let tdCount = table.getElementsByTagName('td').length;
    updateCounter(-tdCount);
    table.remove();
  });
}

function updateCounter(change) {
  let counter = document.getElementById("counter");
  let currentCount = parseInt(counter.textContent, 10);
  counter.textContent = currentCount + change;
}

document.addEventListener('DOMContentLoaded', function () {
  let counterElement = document.createElement("div");
  counterElement.setAttribute("id", "counter");
  counterElement.textContent = "0";
  document.body.appendChild(counterElement);
});