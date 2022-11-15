fetch("https://localhost:7130/api/Book", {
    method: `get`,
    headers: {
        Accept: 'application/json'
    }
})
.then(response => response.json())
.then(data => console.log(data));

let bookId = 4;

fetch("https://localhost:7130/api/Book/id?id=" + bookId, {
    method: `get`,
    headers: {
        Accept: 'application/json'
    }
})
.then(response => response.json())
.then(data => console.log(data));