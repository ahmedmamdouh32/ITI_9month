navigator.geolocation.getCurrentPosition(
    function (pos) {
        initMap(pos.coords.latitude, pos.coords.longitude);
    },
    function (e) {
        console.error(e);
    }
);

const xhr = new XMLHttpRequest();
const select = document.getElementById("country");

select.addEventListener("change", function () {
    const countryName = this.value;
    if (!countryName) return;

    const url = `https://nominatim.openstreetmap.org/search?format=json&q=${countryName}`;

    xhr.open("GET", url, true);

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            const response = JSON.parse(xhr.responseText);

            if (response.length > 0) {
                const lat = parseFloat(response[0].lat);
                const lon = parseFloat(response[0].lon);

                initMap(lat, lon);
            }
        }
    };

    xhr.send();
});

function initMap(myLat, myLon) {
    const myLatLng = { lat: myLat, lng: myLon };

    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 6,
        center: myLatLng,
    });

    new google.maps.Marker({
        position: myLatLng,
        map,
    });
}

window.initMap = initMap;
