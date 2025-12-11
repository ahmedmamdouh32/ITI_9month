var radius;
var area;
do{
    radius = prompt("Enter Circle Radius : ");
}
while(isNaN(radius - 0) == true)

area = Math.PI * Math.pow(radius,2)
alert(`Area = ${area}`)

