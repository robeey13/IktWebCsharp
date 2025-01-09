const selectElements = ['processor', 'motherboard', 'ram', 'storage', 'gpu', 'psu', 'bundles'];


const componentList = document.getElementById('componentList');
const totalPriceElement = document.getElementById('totalPrice');


selectElements.forEach(id => {
    const select = document.getElementById(id);
    select.addEventListener('change', updateSummary);
});

function updateSummary() {
    let total = 0;
    componentList.innerHTML = '';

    selectElements.forEach(id => {
        const select = document.getElementById(id);
        Array.from(select.selectedOptions).forEach(option => {
            const price = option.getAttribute('data-price');
            if (price) {
                const li = document.createElement('li');
                li.textContent = option.textContent;
                componentList.appendChild(li);
                total += parseInt(price);
            }
        });
    });

    totalPriceElement.textContent = `${total} Ft`;
}
window.addEventListener('load', updateSummary);

