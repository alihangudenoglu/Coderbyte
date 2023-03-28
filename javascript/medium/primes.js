let num=1511;
console.log(Prime(num))

function Prime(num) {
    if (num%2==0 && num!=2) {

        return false;
    }
    else{
        for (let index = 2; index < num; index++) {
            if (num%index==0) {
                return false;
            }
            
        }
        return true;
    }
}