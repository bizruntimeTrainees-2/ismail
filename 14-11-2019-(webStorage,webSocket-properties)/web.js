

const textValue = document.querySelector('#text-field');
const submit = document.querySelector('#submit');
const clear = document.querySelector('#clear');

function saveText() {
  localStorage.setItem('text',textValue.value);
}

function clearText() 
{
  textValue.value = '';
  localStorage.clear();
}

if (window.localStorage)
{
  try {
    textValue.addEventListener('keyup',saveText);
  }
  catch (e)
  {
    if (e == QUOTA_EXCEEDED_ERR) {
      alert('Storage limit exceeded');
    }
  }
  if (localStorage.getItem('Text')) {
    textValue.value = localStorage.getItem('Text');
  }
} else {
  console.log('No session storage support');
}
clear.addEventListener('click', clearText);
submit.addEventListener('click', clearText);

