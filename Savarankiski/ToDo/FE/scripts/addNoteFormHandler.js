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

    let minDate = configureMinDate();

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

const addNote = () => {
    let noteForm = document.querySelector(`#add-note-form`);
    let data = new FormData(noteForm)
    
    let obj = {
        type: data.get(`type`),
        content: data.get(`content`),
        endDate: data.get(`endDate`),
        userId: localStorage.getItem(`userId`),
    }

    fetchPost(obj)
    .then(note => {
        addToNoteContainer(note); 
        addNoteBtnListener();       
    })

}

const addToNoteContainer = (note) => {
    document.querySelector(`.notes-container`).innerHTML += formatNoteContainer(note);
}
const addNoteBtnListener = () => {
    let addNoteBtn = document.querySelector(`#add-note-button`);
    addNoteBtn.addEventListener(`click`, (e) => {
        e.preventDefault();
        addNote();
    })
}