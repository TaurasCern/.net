window.onload = () => {
    if(JSON.parse(localStorage.getItem(`isLoggedIn`)) === true){
        loadAcc();
    }
}

const loadAcc = () => {
    let navBar = document.querySelector(`#nav-bar`)
    navBar.innerHTML = `
    <a href="main.html">Užrašai</a>
    <div id="acc-container">
    <h5 id="name-display">Prisijungęs kaip, ${localStorage.getItem(`name`)}</h5>
    <a id="logoutBtn">Atsijungti</a></div>`;

    let script = document.createElement(`script`);
    script.setAttribute(`src`, `scripts/logout.js`);
    document.body.appendChild(script);
}