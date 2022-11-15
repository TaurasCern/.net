let userPostUrl = `http://localhost:5218/api/User`;

const userPost = (user) => {
    return fetch(userPostUrl, {
        method: `post`,
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    })
    .then(response => { return response.json() })
    .then(data => {
        return data;
    })
    .catch(err => console.log(err));  
}

