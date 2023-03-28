let arr=[2,3,4,1,6,10]
let count=arr.length
let result=""
for (let i = arr[0]; i < count; i++) {
    result+=arr[i]
    if (i==arr.length-1) {
        i=-1
        count=arr[0]
    }
}
console.log(result)