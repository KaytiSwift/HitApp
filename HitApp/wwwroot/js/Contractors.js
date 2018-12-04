document.addEventListener("DOMContentLoaded", (event) => {
    //refreshContractors();
    console.log('hey girl');

    const removeButtons = document.querySelectorAll('.remove-contractor');    

    removeButtons.forEach(c => {
        const projectContractorId = c.dataset.projectContractorId;
        c.addEventListener('click', removeContractor.bind(null, projectContractorId));
     });
});



function removeContractor(projectContractorId) {
    console.log(projectContractorId)
    console.log('clicked')   

    fetch(`/Api/Contractors?id=${projectContractorId}`, {
        method: 'POST' 
    }).then(() => {
        console.log("about to remove" + projectContractorId);
       
        removeRow(projectContractorId);
    });
}

function removeRow(projectContractorId) {
    const tr = document.querySelector(`[data-project-contractor-id="${projectContractorId}"]`);
    tr.parentNode.removeChild(tr);
}