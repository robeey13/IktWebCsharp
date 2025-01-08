let items = [
    { name: 'Első elem', img: 'path/to/image1.jpg', link: 'page1.html' },
    { name: 'Második elem', img: 'path/to/image2.jpg', link: 'page2.html' },
    { name: 'Harmadik elem', img: 'path/to/image3.jpg', link: 'page3.html' },
    { name: 'Negyedik elem', img: 'path/to/image4.jpg', link: 'page4.html' },
    { name: 'Ötödik elem', img: 'path/to/image5.jpg', link: 'page5.html' }
];

function searchFunction() {
    let input = document.getElementById('searchInput').value.toLowerCase();
    let dropdown = document.getElementById('dropdownList');
    dropdown.innerHTML = '';


    if (input.length > 0) {
        let filteredItems = items.filter(item => item.name.toLowerCase().includes(input));
        filteredItems.forEach(item => {
            let div = document.createElement('div');
            let img = document.createElement('img');
            img.src = item.img;
            div.appendChild(img);
            div.appendChild(document.createTextNode(item.name));
            div.onclick = function() {
                window.location.href = item.link;
            };
            dropdown.appendChild(div);
        });
        dropdown.style.display = 'block';
    } else {
        dropdown.style.display = 'none';
    }
    
}



document.addEventListener('click', function(event) {
    if (!event.target.matches('#searchInput')) {
        document.getElementById('dropdownList').style.display = 'none';
    }
});
