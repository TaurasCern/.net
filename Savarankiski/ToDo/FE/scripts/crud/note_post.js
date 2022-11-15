let notePostUrl = `https://localhost:7218/api/ToDoNote`

const fetchPost = (obj) => {
    return fetch(notePostUrl, {
        method: `post`,
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
    .then(response => { return response.json()})
    .then(data => {
        if(data.statusCode === 200){
            return data.value;
        }
    })
    .catch(err => console.log(err));
}