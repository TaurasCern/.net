window.onload = () => {
    if(JSON.parse(localStorage.getItem(`isLoggedIn`)) === false || localStorage.getItem(`isLoggedIn`) == undefined){
        window.location.assign(`index.html`)
    }
    else {      
        displayName();
        display();
    }

}        

const userUrl = `http://localhost:5218/api/ToDoNote?userId=`;
const userOptions = {
    method: `get`,
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    },
}

const notePostUrl = `https://localhost:7218/api/ToDoNote`

let isFormOpen = false;

const nameDisplay = document.querySelector(`#name-display`);
const navBar = document.querySelector(`#nav-bar`)

const display = () => {
    fetch(userUrl + localStorage.getItem(`userId`), userOptions)
    .then(responce => {return responce.json()})
    .then(data => {
        displayNotes(data);
    })
}

const displayName = () => {
    nameDisplay.innerHTML += `Prisijungęs kaip, ${localStorage.getItem(`name`)}`;
}
const displayNotes = (data) => {
    let notesContainer = document.querySelector(`.notes-container`);
    for (const note of data.value.toDoNotes) {
        
        notesContainer.innerHTML += formatNoteContainer(note);
    }
};
const formatNoteContainer = (note) => {
    let date = new Date(note.endDate);
    return `
    <div class="note-container" id="note-container-${note.noteId}">
        <div class="note" id="note-${note.noteId}">
            <div>
                <div class="type"><p>${note.type}<p></div>
                <div class="content"><p>${note.content}</p></div>
            </div>
        <div class="row">
            <div class="endDate"><p>Kada: ${date.toLocaleDateString([], {
                year: 'numeric',
                month: '2-digit',
                day: '2-digit',
                hour: '2-digit',
                minute: '2-digit'
            })}</p></div>
            <button onclick="deleteNote(${note.noteId})">Ištrinti</button>
            <button onclick="putNote(${note.noteId})" id="put-note-button-${note.noteId}">Keisti</button>
        </div>
    </div>`;
}