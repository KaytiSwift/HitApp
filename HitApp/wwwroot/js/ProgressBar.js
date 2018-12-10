(function () {
    var cards = document.querySelectorAll(".cards");

    cards.forEach(c => {
        var totalBudget = c.querySelector(".projectTotalBudget").innerHTML;        
        totalBudget = totalBudget.replace('$', '');
        totalBudget = totalBudget.replace(',', '');
        console.log(totalBudget);

        var totalExpenses = c.querySelector(".projectTotalExpenses").innerHTML;
        totalExpenses = totalExpenses.replace('$', '');
        totalExpenses = totalExpenses.replace(',', '');
        console.log(totalExpenses);

        var balance = totalBudget - totalExpenses;
        balance = accounting.formatMoney(balance);
        console.log(balance);
        c.querySelector(".balance").innerHTML = balance + ' : Balance';

        var progress = Math.round(parseFloat(totalExpenses) / parseFloat(totalBudget) * 100);
        console.log(progress);

        if (progress > 70 && progress < 100) {
            c.querySelector(".progressBar").setAttribute("style", `width: ${progress}%; background-color: #dcd940;`);
        }
        else if (progress >= 100) {
            progress = 100;
            c.querySelector(".balance").setAttribute("style", 'color: #cb5252');
            c.querySelector(".progressBar").setAttribute("style", `width: ${progress}%; background-color: #cb5252;`);

        }
        else {
            c.querySelector(".progressBar").setAttribute("style", `width: ${progress}%`);
        }


        c.querySelector(".progress").innerHTML = progress;
        console.log(progress);

        console.log(progress + "px");


    });
})();