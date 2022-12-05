const logoutBtn = document.querySelector(`#logoutBtn`);

logoutBtn.addEventListener(`click`, () => {
    localStorage.setItem(`isLoggedIn`, false);
    localStorage.setItem(`userId`, null);
    localStorage.setItem(`name`, null);
    window.location.assign(`index.html`);
})