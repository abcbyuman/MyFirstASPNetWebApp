$("#btnSend").click(function () {
/*document.getElementById("btnSend").addEventListener("click", function() {*/

    var final_grade;


    final_grade = Number(($("#assignments").val()) * .5) +
        Number(($("#groupProject").val()) * .1) +
        Number(($("#quizzes").val()) * .1) +
        Number(($("#midtermExam").val()) * .1) +
        Number(($("#finalExam").val()) * .1) +
        Number(($("#intex").val()) * .1);

    alert(final_grade + "%");

});

//var a;
//a = Number(($("#assignments").val()));
//var b;
//b = Number(($("#groupProject").val()));
//console.log(a)
//console.log(b)

//if (a > 0 || b > 0) {
//    greeting = "Good day";
//}




