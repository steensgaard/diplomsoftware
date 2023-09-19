let data = [
    { id: 1, joke: "If you see Chuck Norris picking his nose, its best not to say anything." },
    { id: 2, joke: "Chuck Norris is James Bond's wingman." },
    { id: 3, joke: "Chuck Norris threw a grenade that killed 100 people it then exploded" },
    { id: 4, joke: "If you ever do the stupid 'look out!! Chuck Norris is behind you!' joke, he will snap your fucking neck like a chicken bone." }
]
let jokelist = '';
let counter = 1;

window.onload = function () {
    console.log("running");
    app = document.getElementById('app');

    renderData(app);


    setInterval(function () {
        console.log("rendering data");
        renderData(app);
    }, 1000);

    setInterval(async function () {
        const jokeToUpdate = getRandomInt(1, 5);
        const theNewJoke = await fetchNewJoke();
        
        data = data.map( thejoke => 
            thejoke.id == jokeToUpdate ? {id: thejoke.id, joke: theNewJoke } : thejoke
        );
    }, 10000);
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

function renderData(app) {
    app.innerHTML = '';
    data.forEach(element => {
        const container = document.createElement('div');

        const idcontainer = document.createElement('div');
        const id = document.createElement('p');
        id.textContent = element.id;
        idcontainer.appendChild(id)

        const jokecontainer = document.createElement('div');
        const joke = document.createElement('p');
        joke.textContent = element.joke;
        jokecontainer.appendChild(joke)


        container.appendChild(idcontainer)
        container.appendChild(jokecontainer)

        app.appendChild(container)
    });
}
