(function () {
    var cards = document.querySelectorAll(".cards");

    cards.forEach(c => {
        var totalBudget = c.querySelector(".projectTotalBudget").innerHTML;
        console.log(totalBudget);

        var totalExpenses = c.querySelector(".projectTotalExpenses").innerHTML;
        console.log(totalExpenses);
        var progress = Math.round(totalExpenses / totalBudget * 100);

        if (progress > 70 && progress < 100) {
            c.querySelector(".progressBar").setAttribute("style", `width: ${progress}%; background-color: #dcd940;`);
        }
        else if (progress >= 100) {
            progress = 100;
            c.querySelector(".balance").setAttribute("style", 'color: red');
            c.querySelector(".progressBar").setAttribute("style", `width: ${progress}%; background-color: #e11f1f;`);

        }
        else {
            c.querySelector(".progressBar").setAttribute("style", `width: ${progress}%`);
        }


        c.querySelector(".progress").innerHTML = progress;
        console.log(progress);

        console.log(progress + "px");


    });
})();