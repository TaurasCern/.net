let notePutUrl = `https://localhost:7218/api/ToDoNote?noteId=`;

const fetchPut = (note) => {
    return fetch(notePutUrl + note.id, {
        method: `put`,
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(note)
    })
    .then(response => {return response.json()})
    .then(data => {
        if(data.statusCode === 200){
            return data.value;
        }
    })
    .catch(err => console.log(err));
}