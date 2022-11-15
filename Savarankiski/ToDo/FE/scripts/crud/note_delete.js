let noteDeleteUrl = `https://localhost:7218/api/ToDoNote?noteId=`;
let noteDeleteOptions = {
    method: `delete`,
    headers: {
        'Accept': 'application/json'
    },
}

const fetchDelete = (id) => {
    return fetch(noteDeleteUrl + id, noteDeleteOptions)
    .then((response) => { return response.json()})
    .then((data) => data.value);
}