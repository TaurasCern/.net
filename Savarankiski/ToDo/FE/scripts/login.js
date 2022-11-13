window.onload = () => {
    if(JSON.parse(localStorage.getItem(`isLoggedIn`)) === true){
        window.location.assign(`main.html`)
    }
}

const url = `http://localhost:5218/login`;
const loginForm = document.querySelector(`#login-form`)
const loginBtn = document.querySelector(`#login-btn`);

loginBtn.addEventListener(`click`, (e) => {
    e.preventDefault();
    login();
})


const login = () => {
    let data = new FormData(loginForm);
    let obj = {};
    data.forEach((value, key) => obj[key] = value)


    fetch(url, {
        method: `post`,
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
    .then(response => { return response.json() })
    .then(data => {
        if(data.statusCode === 200) {
            localStorage.setItem(`isLoggedIn`, true);
            localStorage.setItem(`userId`, data.value.id)
            localStorage.setItem(`name`, data.value.name)
            window.location.assign(`main.html`)
        }
        else {
            loginErrorDisplay();
        }
    })
    .catch(err => console.log(err));  
}

let isErrorDisplayed = false;

const loginErrorDisplay = () => { 
    if(!isErrorDisplayed){
        let article = document.querySelector(`article`);
        let form = document.querySelector(`#login-form`);
        let errMsg = document.createElement(`div`);
        errMsg.setAttribute(`id`, `error-display`);
        let msg = document.createElement(`h4`);
        msg.innerHTML = `Blogai įvestas slaptažodis arba paskyra neegzistuoja`;
        errMsg.appendChild(msg);
        article.insertBefore(errMsg, form);
        isErrorDisplayed = true;
    }
}