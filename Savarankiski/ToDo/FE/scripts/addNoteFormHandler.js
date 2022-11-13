const showNoteForm = () => {
    let container = document.querySelector(`#add-note-form-container`);
    let button  = document.querySelector(`#open-add-note-button`)
    
    if(isFormOpen) 
    { 
        let form = document.querySelector(`#add-note-form`);
        form.outerHTML = ``;
        isFormOpen = false;
        button.innerHTML = `Prideti užrašą`
        return;
    }

    isFormOpen = true;

    let date = new Date(Date.now());
    let hour = date.getHours() + 1;
    let day = date.getDate();
    if(hour > 23){
        hour = `00`;
        day++;
    }
    hour = String(hour).padStart(2, `0`);
    day = String(day).padStart(2, `0`);
    let minutes = String(date.getMinutes()).padStart(2, `0`);
    let month = String(date.getMonth() + 1).padStart(2, `0`);

    let minDate = `${date.getFullYear()}-${month}-${day}T${hour}:${minutes}`;

    container.innerHTML = `
    <form id="add-note-form">
        <label for="type">Tipas:</label>
        <input type="text" name="type" id="type" autocomplete="off">
        <label for="content">Turinys:</label>
        <input type="text" name="content" id="content" autocomplete="off">
        <label for="endDate">Laikas:</label>
        <input type="datetime-local" name="endDate" id="endDate" min="${minDate}" value="${minDate}">
        <input type="button" class="input-button" value="Prideti" id="add-note-button">
    </form>` + container.innerHTML;

    button.innerHTML = `Uždaryti`;

    addNoteBtnListener();
}

const addNoteBtnListener = () => {
    let addNoteBtn = document.querySelector(`#add-note-button`);
    addNoteBtn.addEventListener(`click`, (e) => {
        e.preventDefault();
        addNote();
    })
}

const addNote = () => {
    let noteForm = document.querySelector(`#add-note-form`);
    let data = new FormData(noteForm)
    
    let obj = {
        noteId: 0,
        type: data.get(`type`),
        content: data.get(`content`),
        endDate: data.get(`endDate`),
        userId: localStorage.getItem(`userId`),
        user: null
    }

    fetch(notePostUrl, {
        method: `post`,
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
    .then(response => { return response.json()})
    .then(data => {
        if(data.statusCode === 200){
            addToNoteContainer(data.value);
            addNoteBtnListener();
        }
    })
    .catch(err => console.log(err));
}

const addToNoteContainer = (note) => {
    document.querySelector(`.notes-container`).innerHTML += formatNoteContainer(note);
}