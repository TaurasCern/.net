window.onload = () => {
    if(JSON.parse(localStorage.getItem(`isLoggedIn`)) === true){
        window.location.assign(`main.html`)
    }
}


const registerForm = document.querySelector(`#register-form`)
const registerBtn = document.querySelector(`#register-btn`);

registerBtn.addEventListener(`click`, (e) => {
    e.preventDefault();
    register();
})

const register = () => {
    let data = new FormData(registerForm);

    if(!registerValidation(data)) { return; }

    let obj = {
        email: data.get(`email`),
        password: data.get(`password`),
        firstName: data.get(`firstName`),
        lastName: data.get(`lastName`),
    };

    
    userPost(obj)
    .then(data => {
        if(data.statusCode === 200) {
            localStorage.setItem(`isLoggedIn`, true);
            localStorage.setItem(`userId`, data.value.id);
            localStorage.setItem(`name`, data.value.name);
            window.location.assign(`main.html`);
        }
        else localStorage.setItem(`isLoggedIn`, false);
    })
    .catch(err => console.log(err));
}

const registerValidation = (data) => {
    if(!emailValidation(data.get(`email`))){
        registerErrorDisplay(`not valid email`);
        return false;
    }
    else if(!nameValidation(data.get(`firstName`), data.get(`lastName`))){
        // note
        registerErrorDisplay(`not valid name`);
        return false;
    }
    else if(!passwordValidation(data.get(`password`), data.get(`password-re`))){
        //note
        registerErrorDisplay(`not valid password`);
        return false;
    }
    else return true;
}

const emailValidation = (email) => {
    let validRegex = new  RegExp('^[a-zA-Z0-9.!#$%&\'*+/=?^_\`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$');
    if (validRegex.test(email)) return true;
}
const nameValidation = (firstName, lastName) => {
    return /^[A-Za-z\s]*$/.test(firstName) || /^[A-Za-z\s]*$/.test(lastName);
}
const passwordValidation = (pass1, pass2) => {
    return pass1 === pass2 && pass1.toString().length > 6;
}

let isRegisterErrorDisplayed = false;

const registerErrorDisplay = (msg) => { 
    if(!isRegisterErrorDisplayed){
        let article = document.querySelector(`article`);
        let form = document.querySelector(`#register-form`);
        let errMsg = document.createElement(`div`);
        errMsg.setAttribute(`id`, `error-display`);
        let h4 = document.createElement(`h4`);
        h4.innerHTML = msg;
        errMsg.appendChild(h4);

        article.insertBefore(errMsg, form);
        isRegisterErrorDisplayed = true;
    }
    else {
        let h4 = document.querySelector(`#error-display h4`);
        h4.innerHTML = msg;
    }
}