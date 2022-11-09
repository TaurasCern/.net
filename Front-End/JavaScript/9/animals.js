const url = `https://testapi.io/api/Taurenxoo/resource/Animals`;
const options = {
    method: `get`,
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    },
}

const animalsContainer = document.querySelector(`#animals-container`)


const printAnimals = () => {
    fetch(url, options)
    .then(response => {return response.json()})
    .then((data) => {
        for (const obj of data.data) {
            for (const i in obj) {
                animalsContainer.innerHTML += `${i}: ${obj[i]}<br>`;
            }
            animalsContainer.innerHTML += '<br><br>';
        }
    });
}

printAnimals();