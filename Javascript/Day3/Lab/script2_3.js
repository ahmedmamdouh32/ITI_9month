var angel;
var angelRad;
do{
    angel = prompt("Enter Angel : ");
}
while(isNaN(angel - 0) == true)
angelRad = Number(angel)
angelRad = Math.cos(angel * Math.PI   / 180).toFixed(4)

document.writeln(`Cos ${angel} is ${angelRad}`)

