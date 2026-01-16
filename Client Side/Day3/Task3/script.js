const offers = document.getElementsByClassName("offers")[0];
const offer1 = document.getElementById("offer1");
const offer2 = document.getElementById("offer2");
const offer3 = document.getElementById("offer3");
const observer = new IntersectionObserver((entries) => {
    console.log(entries);
    if (entries[0].isIntersecting === true) {
        console.log("intersecting");
        offer2.style.animationDelay = '0.25s';
        offer3.style.animationDelay = '0.55s';
        offer1.classList.add('animate');
        offer2.classList.add('animate');
        offer3.classList.add('animate');

        observer.unobserve(entries[0].target) //cancel the observer so animation will run only once
    }
}, {})

observer.observe(offers);

const services = document.querySelectorAll('.service');
const serviceObserver = new IntersectionObserver((entries, serviceObserver) => {
    let delay = 0;
    entries.forEach(entry => {
        console.log(entries);

        if (entry.isIntersecting) {
            // const delay = entry.target.dataset.order * 0.25; // stagger dynamically
            // console.log(entry.target);
            // console.log(delay);
            // console.log(" ====== ");

            entry.target.style.animationDelay = `${delay}s`;
            delay += 0.1;
            entry.target.classList.add('animate');

            serviceObserver.unobserve(entry.target); // one-time animation
        }
    });
}, { threshold: 0.2 });


services.forEach(service => serviceObserver.observe(service));












