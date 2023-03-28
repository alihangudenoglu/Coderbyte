let strArr=["hellocat", "apple,bat,cat,goodbye,hello,yellow,why"];
let arr=strArr[1].split(",");
let result="not possible";
for (let i = 0; i < arr.length; i++) {
    for (let j = 0; j < arr.length; j++) {
        if (arr[i]+arr[j]==strArr[0]) {
            result=arr[i]+","+arr[j];
        }
    
    }
    
}
console.log(result)