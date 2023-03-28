let str = "1as1aw6 12s4"
let wordLength = str.split(" ").length
let count = 0
let nmbrStr = ""
for (let i = 0; i < str.length; i++) {
    if (Number(str[i])) {
        count++
        nmbrStr += str[i]
    }
    else{
        count = 0
    }
        
    if (count > 2){
        console.log(false)
    }
        
}
if (nmbrStr.length % 3 == 0) {
    for (let i = 0; i < wordLength; i++)
    {
        if (nmbrStr[i * 3] != nmbrStr[i * 3 + 1] && nmbrStr[i * 3] != nmbrStr[i * 3 + 2] && nmbrStr[i * 3 + 1] != nmbrStr[i * 3 + 2]) {

        }
        else {
            console.log(false)
        }
    }
}
else {
    console.log(false)
}
console.log(true)
console.log(nmbrStr)
