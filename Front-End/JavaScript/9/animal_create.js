const animalForm = document.querySelector(`#animal-form`);
const animalFormSbmBtn = document.querySelector(`#animal-form-submit`);

const sendData = () => {
    let data = new FormData(animalForm);
    let obj = {};
    data.forEach((value, key) => obj[key] = value)
    fetch(`https://testapi.io/api/Taurenxoo/resource/Animals`, {
        method: `post`,
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
    .then(response => console.log(response.json()))
    .catch(err => console.log(err));
}

animalFormSbmBtn.addEventListener(`click`, (e) => {
    e.preventDefault(); // prevents refresh
    sendData();
});