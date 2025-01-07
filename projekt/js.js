let s = 0;

function tablazat() {
  let sor = document.getElementById("sor").value;
  let oszlop = document.getElementById("oszlop").value;
  let table = document.createElement("table");
  table.setAttribute("id", "table");

  let a = 0;
  // Create table rows and columns
  for (let i = 0; i < sor; i++) {
    let tr = document.createElement("tr");
    for (let j = 0; j < oszlop; j++) {
      let td = document.createElement("td");
      a++;
      tr.appendChild(td);
    }
    table.appendChild(tr);
  }
  s+=a;
  document.getElementById("ossz").innerText =s
  // Make the table draggable
  makeTableDraggable(table);
  table.addEventListener("dblclick", function(){
    this.remove()
    s-=a;
    document.getElementById("ossz").innerText =s
  });
  

  // Append table to the page
  document.getElementById("left").appendChild(table);
}


function makeTableDraggable(table) {
  let isDragging = false;
  let offsetX, offsetY;

  table.style.position = 'absolute'; // Make sure the table is positioned absolutely

  // Mouse down event to start dragging
  table.addEventListener('mousedown', function (e) {
    isDragging = true;
    offsetX = e.clientX - table.offsetLeft;
    offsetY = e.clientY - table.offsetTop;
    table.style.cursor = 'move';
  });

  // Mouse move event to move the table
  document.addEventListener('mousemove', function (e) {
    if (isDragging) {
      table.style.left = e.clientX - offsetX + 'px';
      table.style.top = e.clientY - offsetY + 'px';
    }
  });

  // Mouse up event to stop dragging
  document.addEventListener('mouseup', function () {
    isDragging = false;
    table.style.cursor = 'default';
  });
}





