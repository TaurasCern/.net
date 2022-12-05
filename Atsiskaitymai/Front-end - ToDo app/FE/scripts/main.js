window.onload = () => {
    if(JSON.parse(localStorage.getItem(`isLoggedIn`)) === false || localStorage.getItem(`isLoggedIn`) == undefined){
        window.location.assign(`index.html`)
    }
    else {      
        displayName();
        display();
    }

}        

const configureMinDate = () => {
    let date = new Date(Date.now());
    date.setHours(date.getHours() + 1);

    let hour = String(date.getHours()).padStart(2, `0`);
    let day = String(date.getDate()).padStart(2, `0`);
    let minutes = String(date.getMinutes()).padStart(2, `0`);
    let month = String(date.getMonth() + 1).padStart(2, `0`);

    return `${date.getFullYear()}-${month}-${day}T${hour}:${minutes}`;
}

const deleteNote = (id) => {
    fetchDelete(id)
    .then(note => {
            document.querySelector(`#note-${note.noteId}`).outerHTML = ``;
            if(isPutFormOpen[id]){
                closeEditNoteForm(id);
            }
    })
}
let isFormOpen = false;

const nameDisplay = document.querySelector(`#name-display`);
const navBar = document.querySelector(`#nav-bar`)

const display = () => {

    fetchGet(localStorage.getItem(`userId`))
    .then(data => {
        displayNotes(data)
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
            <button onclick="editNote(${note.noteId})" id="put-note-button-${note.noteId}">Keisti</button>
        </div>
    </div>`;
}