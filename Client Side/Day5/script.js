const wrapper = document.querySelector('.testimonial-wrapper');
const slides = document.querySelectorAll('.testimonial');
const prevBtn = document.getElementById('prev');
const nextBtn = document.getElementById('next');

let currentIndex = 0;

function updateSlide(direction) {
    if (direction === 'next') {
        currentIndex = (currentIndex + 1) % slides.length;
    } else if (direction === 'prev') {
        currentIndex = (currentIndex - 1 + slides.length) % slides.length;
    }

    wrapper.style.transform = `translateX(-${currentIndex * 100}%)`;
}

nextBtn.addEventListener('click', () => updateSlide('next'));
prevBtn.addEventListener('click', () => updateSlide('prev'));
