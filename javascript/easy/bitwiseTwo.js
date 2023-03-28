var strArr=["1110","1110"]
let result="";
for (let index = 0; index < strArr[0].length; index++) {
    
    result+=strArr[0][index] * strArr[1][index]
}
console.log(result)