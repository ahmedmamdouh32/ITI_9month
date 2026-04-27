let totalCartQuantity = localStorage.getItem("totalCartQuantity");
const cartItemsSpan = document.getElementById('cartItemsSpan');

if (totalCartQuantity !== null) {
    cartItemsSpan.innerText = totalCartQuantity;
}
document.querySelectorAll('.heart-icon').forEach(heart => {
    heart.addEventListener('click', function (e) {
        e.preventDefault();
        const icon = this.querySelector('i');
        if (icon.classList.contains('bi-heart')) {
            icon.classList.remove('bi-heart');
            icon.classList.add('bi-heart-fill');
            icon.style.color = '#e83e8c';
        } else {
            icon.classList.remove('bi-heart-fill');
            icon.classList.add('bi-heart');
            icon.style.color = '#4a4a4a';
        }
    });
});

const maxRange = 4;
let productsCounter = 0;
let products_data;

fetch('https://69bea7ae17c3d7d977929e89.mockapi.io/TownTeen/products')
    .then(res => res.json())
    .then(data => {
        products_data = data;
        renderProducts(data);
    });

function renderProducts(products) {
    const container = document.getElementById('products_grid');
    for (let product of products) {
        if (productsCounter === maxRange) break;
        const card = document.createElement('div');
        card.className = "col-sm-6 col-lg-4 col-xl-3";
        card.innerHTML = `
            <div class="hover-zoom card h-100 border-0 shadow-sm rounded-4 overflow-hidden">
                <div class="position-relative" style="aspect-ratio: 1/1;">
                    <a href="product_detail.html?id=${product.id}">
                        <img src=${product.image} class="card-img-top  w-100 h-100 object-fit-contain" alt="Performance Athletic">
                    </a>
                    <div class="position-absolute top-0 end-0 m-3">
                        <div class="heart-icon"><i class="bi bi-heart heart-emoji" style="color: #4a4a4a;"></i></div>
                    </div>
                </div>
                <div class="card-body p-3">
                    <span class="small text-secondary-emphasis">${product.category}</span>
                    <h3 class="h6 fw-semibold mt-1 mb-2">${product.name}</h3>
                    <div class="fw-bold fs-5" style="color: #2C5F2D;">$${product.price}</div>
                </div>
            </div>
            `;
        container.append(card);
        productsCounter++;
        const heartIconBtn = card.querySelector('.heart-icon');
        const heartIconEmoji = card.querySelector('.heart-emoji');
        if (localStorage.getItem(`wishlist-${product.id}`) !== null) {
            heartIconEmoji.classList.remove('bi-heart');
            heartIconEmoji.classList.add('bi-heart-fill');
            heartIconEmoji.style.color = '#e83e8c';
        }
        heartIconBtn.addEventListener('click', () => {
            console.log('div event');
            if (heartIconEmoji.classList.contains('bi-heart')) {
                heartIconEmoji.classList.remove('bi-heart');
                heartIconEmoji.classList.add('bi-heart-fill');
                heartIconEmoji.style.color = '#e83e8c';
                localStorage.setItem(`wishlist-${product.id}`, true);
            }
            else {
                heartIconEmoji.classList.remove('bi-heart-fill');
                heartIconEmoji.classList.add('bi-heart');
                heartIconEmoji.style.color = '#4a4a4a';
                localStorage.removeItem(`wishlist-${product.id}`);
            }
        });
    };
}