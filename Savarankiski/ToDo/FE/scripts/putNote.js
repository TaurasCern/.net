const notePutUrl = `https://localhost:7218/api/ToDoNote?noteId=`;
let isPutFormOpen = [];

const openPutNoteForm = (id) => {
    let date = new Date(Date.now());
    let hour;
    let day = date.getDate();
    if(date.getHours() < 10){
        hour = `0` + date.getHours();
    }
    if(hour > 23){
        hour = `00`;
        day++;
    }
    let minDate = `${date.getFullYear()}-${date.getMonth() + 1}-${day}T${hour}:${date.getMinutes()}`;

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

const closePutNoteForm = (id) => {
    document.querySelector(`#note-form-${id}`).outerHTML = ``;
    isPutFormOpen[id] = undefined;
}

const putNote = (id) => {
    if(isPutFormOpen[id] === undefined){
        openPutNoteForm(id);
    }
    else {
        closePutNoteForm(id);
    }

    document.querySelector(`#update-note-button-${id}`).addEventListener(`click`, e => {
        e.preventDefault();
        updateNote(id);
    })
}

const updateNote = (id) => {
    let form = document.querySelector(`#note-form-${id}`)
    let formData = new FormData(form);
    
    let obj = {
        noteId: id,
        type: formData.get(`type`),
        content: formData.get(`content`),
        endDate: formData.get(`endDate`),
        userId: localStorage.getItem(`userId`),
        user: null
    };
    fetch(notePutUrl + id, {
        method: `put`,
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
    .then(response => {return response.json()})
    .then(data => {
        if(data.statusCode === 200){
            updateNoteDisplay(id, data.value)
        }
    })
    .catch(err => console.log(err));
}


const updateNoteDisplay = (id, note) =>{
    document.querySelector(`#note-${id} .type p`).innerHTML = note.type;
    document.querySelector(`#note-${id} .content p`).innerHTML = note.content;
    document.querySelector(`#note-${id} .endDate p`).innerHTML = (new Date(note.endDate)).toLocaleDateString([], {
        year: 'numeric',
        month: '2-digit',
        day: '2-digit',
        hour: '2-digit',
        minute: '2-digit'
    });
}