const url = `https://swapi.dev/api/people/1`;

const fetchPromise = () => {
  fetch(url)
    .then((response) => {
      if (response.ok) {
        return response.json();
      } else {
        console.log(`err: ${response.status}`);
      }
    })
    .then((data) => fillPersonContainer(data));
};

const fetchAsync = async () => fillPersonContainer(await(await fetch(url)).json()); // may need try catch

const fillPersonContainer = (data) => {
  let container = document.getElementById(`person-container`);
  console.log(data);
  container.innerHTML += `Veikėjo vardas: ${data[`name`]}<br>`;
  container.innerHTML += `Ūgis: ${data[`height`]} cm<br>`;
  container.innerHTML += `Svoris: ${data[`mass`]} kg<br><br>`;
};

fetchPromise();
fetchAsync();