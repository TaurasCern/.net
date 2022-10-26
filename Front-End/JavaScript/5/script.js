let arr = [];

  btn_pop.addEventListener('click', () => {
    arr.pop(document.getElementById('fld_input').value)
    document.getElementById('output').innerHTML = arr.join(',');
    console.table(arr);
  })
  btn_push.addEventListener('click', () => {
    arr.push(document.getElementById('fld_input').value);
    document.getElementById('output').innerHTML = arr.join(',');
    console.table(arr);
  })
  btn_shift.addEventListener('click', () => {
    arr.shift(document.getElementById('fld_input').value)
    document.getElementById('output').innerHTML = arr.join(',');
    console.table(arr);
  })
  btn_unshift.addEventListener('click', () => {
    arr.unshift(document.getElementById('fld_input').value);
    document.getElementById('output').innerHTML = arr.join(',');
    console.table(arr);
  })