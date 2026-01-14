document.addEventListener("DOMContentLoaded", () => {
    const musicSource = document.getElementById("musicSource");
    const currentTime = document.getElementById("currentTime");
    const musicTime = document.getElementById("musicTime");
    const timeRange = document.getElementById("timeRange");
    const volumeRange = document.getElementById("volumeRange");

    const musicLinks = [
        "resources/Aetheric - Snap Crackle.mp3",
        "resources/Pufino - Enlivening.mp3",
        "resources/Zambolino - Way Back.mp3"
    ];

    const musicTitles = [
        "Aetheric - Snap Crackle",
        "Pufino - Enlivening",
        "Zambolino - Way Back"
    ];

    let currentAudiIndex = 0;

    musicSource.addEventListener("loadedmetadata", () => {
        musicTime.innerText = formatTime(musicSource.duration);
        timeRange.max = Math.floor(musicSource.duration);
        document.getElementById("musicTitle").innerText = musicTitles[currentAudiIndex];
    });

    //time control
    musicSource.addEventListener("timeupdate", () => {
        currentTime.innerText = formatTime(musicSource.currentTime);
        timeRange.value = Math.floor(musicSource.currentTime);
    });

    timeRange.addEventListener("input", () => {
        musicSource.currentTime = timeRange.value;
        currentTime.innerText = formatTime(musicSource.currentTime);
    });

    // volume control
    volumeRange.addEventListener("input", () => {
        musicSource.volume = volumeRange.value;
    });

    playAud = () => musicSource.play();
    pauseAud = () => musicSource.pause();

    nextAud = () => {
        currentAudiIndex = (currentAudiIndex + 1) % musicLinks.length;
        musicSource.src = musicLinks[currentAudiIndex];
        musicSource.load();
        musicSource.play();
    };
    backAud = () => {
        currentAudiIndex = currentAudiIndex - 1;
        if (currentAudiIndex < 0) currentAudiIndex = musicLinks.length - 1;
        musicSource.src = musicLinks[currentAudiIndex];
        musicSource.load();
        musicSource.play();
    };
});

function formatTime(seconds) {
    const mins = Math.floor(seconds / 60);
    const secs = Math.floor(seconds % 60);
    return `${mins}:${secs < 10 ? "0" : ""}${secs}`;
}
