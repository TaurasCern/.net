const isPutFormOpen = [];

const editNote = (id) => {
    if(isPutFormOpen[id] === undefined){
        openEditNoteForm(id);
    }
    else {
        closeEditNoteForm(id);
    }

    document.querySelector(`#update-note-button-${id}`).addEventListener(`click`, e => {
        e.preventDefault();
        updateNote(id);
    })
}
const openEditNoteForm = (id) => {
    let minDate = configureMinDate();

    document.querySelector(`#note-container-${id}`).innerHTML += ` 
    <form class ="note-form" id="note-form-${id}">
        <label for="type">Tipas:</label>
        <input type="text" name="type" id="type" autocomplete="off">
        <label for="content">Turinys:</label>
        <input type="text" name="content" id="content" autocomplete="off">
        <label for="endDate">Laikas:</label>
        <input type="datetime-local" name="endDate" id="endDate" min="${minDate}" value="${minDate}">
        <input type="button" class="input-button" value="Atnaujinti" id="update-note-button-${id}">
    </form>`;
            
    isPutFormOpen[id] = true;
}

const closeEditNoteForm = (id) => {
    document.querySelector(`#note-form-${id}`).outerHTML = ``;
    isPutFormOpen[id] = undefined;
}

const updateNote = (id) => {
    let form = document.querySelector(`#note-form-${id}`)
    let formData = new FormData(form);
    
    let obj = {
        noteId: id,
        type: formData.get(`type`),
        content: formData.get(`content`),
        endDate: formData.get(`endDate`),
        userId: localStorage.getItem(`userId`)
    };
    fetchPut(obj)
    .then(note => {
        updateNoteDisplay(note)
    })
}


const updateNoteDisplay = (note) =>{
    document.querySelector(`#note-${note.noteId} .type p`).innerHTML = note.type;
    document.querySelector(`#note-${note.noteId} .content p`).innerHTML = note.content;
    document.querySelector(`#note-${note.noteId} .endDate p`).innerHTML = (new Date(note.endDate)).toLocaleDateString([], {
        year: 'numeric',
        month: '2-digit',
        day: '2-digit',
        hour: '2-digit',
        minute: '2-digit'
    });
}