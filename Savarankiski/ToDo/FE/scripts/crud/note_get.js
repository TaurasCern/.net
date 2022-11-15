let userUrl = `http://localhost:5218/api/ToDoNote?userId=`;
let userOptions = {
    method: `get`,
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    },
}

const fetchGet = (userId) => {
    return fetch(userUrl + userId, userOptions)
    .then(response => response.json())
    .then(data => {
        return data;
    })
}