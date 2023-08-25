let data = [
    { id: 1, joke: "If you see Chuck Norris picking his nose, its best not to say anything." },
    { id: 2, joke: "Chuck Norris is James Bond's wingman." },
    { id: 3, joke: "Chuck Norris threw a grenade that killed 100 people it then exploded" },
    { id: 4, joke: "If you ever do the stupid 'look out!! Chuck Norris is behind you!' joke, he will snap your fucking neck like a chicken bone." }
]
let app = '';
let jokelist = '';
let counter = 1;

window.onload = function () {
    app = document.getElementById('app');
    jokelist = document.createElement('ul');
    app.appendChild(jokelist);

    setInterval(function () {
        renderData();
    }, 2000);

    setInterval(async function () {
        console.log(data)
        const jokeToUpdate = getRandomInt(1, 5);
        const theNewJoke = await fetchNewJoke();
        
        data = data.map( thejoke => 
            thejoke.id == jokeToUpdate ? {id: thejoke.id, joke: theNewJoke } : thejoke
        );
    }, 5000);
}

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min) + min); // The maximum is exclusive and the minimum is inclusive
  }
  

async function fetchNewJoke() {
    const response = await fetch("https://api.chucknorris.io/jokes/random");
    const joke = await response.json();
    return joke.value;
}

function renderData() {
    jokelist.innerHTML = '';
    data.forEach(element => {
        const jokeItem = document.createElement('li')

        const id = document.createElement('p');
        id.textContent = element.id;

        const joke = document.createElement('p');
        joke.textContent = element.joke;

        jokelist.appendChild(id)
        jokelist.appendChild(joke)

        jokelist.appendChild(jokeItem)
    });
}
