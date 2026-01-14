document.addEventListener("DOMContentLoaded", () => {

    const Radios = document.getElementsByName("lang");


    //video
    const startVideoBtn = document.getElementById("startVideoBtn");
    const pauseVideoBtn = document.getElementById("pauseVideoBtn");
    const showCaptionVideoBtn = document.getElementById("showCaptionVideoBtn");
    const videoSource = document.getElementById("videoSource");
    const videoFullTime = document.getElementById("videoFullTime");
    const videoCurrentTime = document.getElementById("videoCurrentTime");
    const timeSlider = document.getElementById("timeSlider");

    var tracks = videoSource.textTracks; //array to select between tracks
    tracks[0] // ---> points to first caption 
    tracks[1] // ---> points to second caption

    let selectedLanguage = "notSet";

    SelectLanguage = () => {
        for (const radio of Radios) {
            if (radio.checked) {  // check which one is selected
                selectedLanguage = radio.value;
                break;             // stop loop once found
            }
        }

        if (showCaptionVideoBtn.value === "Hide Caption") {
            if (selectedLanguage === "AR") {
                tracks[0].mode = "hidden";
                if (tracks[1].mode === "showing") tracks[1].mode = "hidden"
                else tracks[1].mode = "showing";
                console.log(`Arabic Caption Mode : ${tracks[1].mode}`);
            }
            else if (selectedLanguage === "EN") {
                tracks[1].mode = "hidden";
                if (tracks[0].mode === "showing") tracks[0].mode = "hidden"
                else tracks[0].mode = "showing";
                console.log(`English Caption Mode : ${tracks[0].mode}`);
            }
        }
        console.log(selectedLanguage);
    }


    videoSource.addEventListener("loadedmetadata", () => {
        videoFullTime.innerText = formatTime(videoSource.duration);
        timeSlider.max = Math.floor(videoSource.duration);
    });

    videoSource.addEventListener("timeupdate", () => {
        videoCurrentTime.innerText = formatTime(videoSource.currentTime);
        timeSlider.value = Math.floor(videoSource.currentTime);
    })

    timeSlider.addEventListener("input", () => {
        videoSource.currentTime = timeSlider.value;
        videoCurrentTime.innerText = formatTime(videoSource.currentTime);
    });

    startVideoBtn.addEventListener('click', () => {
        videoSource.play();
    })

    pauseVideoBtn.addEventListener('click', () => {
        videoSource.pause();
    })

    showCaptionVideoBtn.addEventListener('click', () => {


        if (selectedLanguage === "notSet") {
            alert("Select Language First");
            return 0;
        }
        if (showCaptionVideoBtn.value === "Show Caption") showCaptionVideoBtn.value = "Hide Caption";
        else showCaptionVideoBtn.value = "Show Caption";
        console.log(selectedLanguage);
        if (selectedLanguage === "AR") {
            tracks[0].mode = "hidden";
            if (tracks[1].mode === "showing") tracks[1].mode = "hidden"
            else tracks[1].mode = "showing";
            console.log(`Arabic Caption Mode : ${tracks[1].mode}`);
        }
        else if (selectedLanguage === "EN") {
            tracks[1].mode = "hidden";
            if (tracks[0].mode === "showing") tracks[0].mode = "hidden"
            else tracks[0].mode = "showing";
            console.log(`English Caption Mode : ${tracks[0].mode}`);
        }
    })


    function formatTime(seconds) {
        const mins = Math.floor(seconds / 60);
        const secs = Math.floor(seconds % 60);
        return `${mins}:${secs < 10 ? "0" : ""}${secs}`;
    }
});
