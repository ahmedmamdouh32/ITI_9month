async function myPromise() {
    return answer = new Promise(function (accept, reject) {
        setTimeout(() => {
            accept("return from Promise");
        }, 2000);
    })
}

async function caller() {
    let result = await myPromise();
    console.log(result);
}



caller();
console.log("after caller");



