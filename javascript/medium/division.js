let num1=108
let num2=24
let min=num1<num2?num1:num2
let result=1
for (let i = 1; i <=min; i++) {
    if (num1%i==0 && num2%i==0) {
        result=i
    }
}
console.log(result)