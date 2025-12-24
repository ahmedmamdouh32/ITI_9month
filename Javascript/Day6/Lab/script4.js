/**
 * @param {Object|Array} obj
 * @return {boolean}
 */

var obj = {

}
console.log(Object.keys(obj).length);
console.log(obj.isEmpty)

var isEmpty = function(obj) {
    if(Object.keys(obj).length > 0){
        return true;
    }
    else{
        return false;
    }
};

console.log(isEmpty(obj));