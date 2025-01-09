const toastTrigger = document.getElementById('liveToastBtn')
const toastLiveExample = document.getElementById('liveToast')

if (toastTrigger) {
  const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
  toastTrigger.addEventListener('click', () => {
    toastBootstrap.show()
  })
}

(() => {
  'use strict'


  const forms = document.querySelectorAll('.needs-validation')


  Array.from(forms).forEach(form => {
    form.addEventListener('submit', event => {
      if (!form.checkValidity()) {
        event.preventDefault()
        event.stopPropagation()
      }

      form.classList.add('was-validated')
    }, false)
  })
})()

const megye = document.getElementById('validationDefault04').value

document.getElementById('orderForm').addEventListener('submit', function(event) {

    event.preventDefault();


    var form = event.target;
    var valid = form.checkValidity();
    if (valid) {
        alert("Sikeresen megrendelve!\n Köszönjük szépen!");
        window.location.href = 'index.html';
    }
});

