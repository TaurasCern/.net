let movies = [`movie1`,`movie2`,`movie3`,`movie4`,`movie5`];

movies[0] = `movie10`;
movies[movies.length] = `movie6`;

console.table(movies);