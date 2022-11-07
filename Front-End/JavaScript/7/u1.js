let container1 = document.getElementById(`u1-container`);
let container2 = document.getElementById(`u2-container`);

const setText1 = () => {
  new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve((container1.innerHTML += `1`));
    }, 3000);
  });
};

setText1();
setTimeout(() => {
  container1.innerHTML += `2<br>`;
}, 2000);

let intervalCount = 0;
let id = setInterval(() => {
  container1.innerHTML += `3<br>`;
  intervalCount++;
  if (intervalCount > 0) {
    clearInterval(id);
  }
}, 1000);

// 2

const setText2 = () => {
  new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve((container2.innerHTML += `2`));
    }, 3000);
  });
};

setText2();
container2.innerHTML += `1<br>`;
