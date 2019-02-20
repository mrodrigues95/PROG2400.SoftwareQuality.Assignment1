// User story 1
// Changes the background of text to green
function btn1_click() {
    var input = document.getElementById("classifiedText").value;

    document.getElementById('displayTextAsGreen').innerHTML = input;
    document.getElementById('displayTextAsGreen').style.backgroundColor = "green";
}

// User story 5
// Reverses any text the user submits
function btn2_click() {
    var input = document.getElementById("reversedText").value;

    document.getElementById('displayTextAsReversed').innerHTML = reverseString(input);
}

function reverseString(str) {
    var newString = "";

    for (var i = str.length - 1; i >= 0; i--) {
        newString += str[i];
    }

    return newString;
}

// User story 3
// Changes any text the user submits to bold
function btn3_click() {
    var input = document.getElementById("boldText").value;
    var result = input.bold();

    document.getElementById('displayTextAsBold').innerHTML = result;
}

// User story 4
// Changes any text the user submits to italics 
function btn4_click() {
    var input = document.getElementById("italicsText").value;
    var result = input.italics();

    document.getElementById('displayTextAsItalics').innerHTML = result;
}

