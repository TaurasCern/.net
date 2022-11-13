const noteDeleteUrl = `https://localhost:7218/api/ToDoNote?noteId=`;
const noteDeleteOptions = {
    method: `delete`,
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    },
}

const deleteNote = (id) => {
    fetch(noteDeleteUrl + id, noteDeleteOptions)
    .then((response) => { return response.json()})
    .then((data) => {
        document.querySelector(`#note-${data.value.noteId}`).outerHTML = ``;
    });
}