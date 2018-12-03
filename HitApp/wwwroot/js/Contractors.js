document.addEventListener("DOMContentLoaded", (event) => {
    //refreshContractors();
    const remove = document.querySelector('#remove-contractor');
    console.log('hey girl');
    remove.addEventListener('click', removeContractor);
});

function refreshContractors() {
    const ul = document.querySelector('#contractor-list');
    ul.innerHTML = '';
    fetch(`/Api/Contractors/${projectContractorId}`)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            data.forEach(c => addContractorToDom(c));
        });
}
function removeContractor() {
    console.log('clicked')
    //const contractorInput = document.querySelector('#new-contractor');
    //const newContractorText = document.querySelector('#new-contractor').value;
    
    const projectContractor = {
        id: `${projectContractorId}`

    };

    fetch(`/Api/Contractors?id=${projectContractorId}`, {
        method: 'POST',
        //body: JSON.stringify(projectContractor),
        //headers: {
        //    'Content-Type': 'application/json'
        //}

    }).then(() => {      
        //refreshContractors();
    });
}

function addContractorToDom(contractor) {
    
    const header = document.querySelector('#contractor-data');
    const td = document.createElement('td');
    console.log(contractor);

    td.innerHTML = contractor.



    ul.appendChild(li); 
}