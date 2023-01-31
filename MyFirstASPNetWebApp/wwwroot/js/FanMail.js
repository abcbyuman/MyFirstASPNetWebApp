$("#btnSend").click(function () {

    var final_grade;
    console.log(document.getElementById("assignment"))
    console.log(document.getElementById("intex"))


    final_grade = Number(($("#assignments").val()) * .5) +
        Number(($("#groupProject").val()) * .1) +
        Number(($("#quizzes").val()) * .1) +
        Number(($("#midtermExam").val()) * .1) +
        Number(($("#finalExam").val()) * .1) +
        Number(($("#intex").val()) * .1);

    document.getElementById("output1").innerHTML = final_grade + "%";

});


