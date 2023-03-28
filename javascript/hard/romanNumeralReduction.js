let str="LXXXVVVIIIII";
console.log(Reduction(str))

function Reduction(str) {
    let romanArr=[["I",1],["V",5],["X",10],["L",50],["C",100],["D",500],["M",1000]]
    let total=0
    let result=""

    for (let i = 0; i < str.length; i++) {
        for (let j = 0; j < romanArr.length; j++) {
            if (str[i]==romanArr[j][0]) {
                total+=romanArr[j][1]
            }
            
        }
    }
    for (let index = romanArr.length-1; index>=0;) {
        if (total>=romanArr[index][1]) {
            total-=romanArr[index][1]
            result+=romanArr[index][0]
        }
        else{
            if (total==0) {
                break
            }
            index--
        }
        
    }
    return result
}