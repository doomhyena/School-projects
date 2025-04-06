const form = document.querySelector('form');
const passwordInput = document.querySelector('#password');
const passwordRepeatInput = document.querySelector('#passowrdtwo');
const nameInput = document.querySelector('#name');
const emailInput = document.querySelector('#email');

form.addEventListener('submit', (e) => {
  const password = passwordInput.value.trim();
  const passwordRepeat = passwordRepeatInput.value.trim();
  const name = nameInput.value.trim();
  const email = emailInput.value.trim();

  if (password === '') {
    alert('Kérjük, töltse ki a jelszót!');
    e.preventDefault();
    return;
  }

  if (password !== passwordRepeat) {
    alert('A két jelszó nem egyezik!');
    e.preventDefault();
    return;
  }

  if (name === '') {
    alert('Kérjük, töltse ki a nevét!');
    e.preventDefault();
    return;
  }

  if (email === '') {
    alert('Kérjük, töltse ki az email címét!');
    e.preventDefault();
    return;
  }

  console.log('Regisztráció sikeres!');
});