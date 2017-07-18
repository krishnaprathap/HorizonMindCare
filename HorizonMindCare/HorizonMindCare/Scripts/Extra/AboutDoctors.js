var id = @ViewBag.id;
alert("ID From Route Data: " + id);


function edit() {
    if (id ==1) {

        var x = document.getElementById("kaveri");
        x.style.display = 'none';

        var y = document.getElementById("Nikhil");
        y.style.display = 'none';
    }
}



