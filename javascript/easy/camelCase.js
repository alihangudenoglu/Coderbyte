let str="ginger-brea d mAN";
str=str.toLowerCase().split(/[^a-zA-Z]+/);
let result=str[0];
for (let index = 1; index < str.length; index++) {
    result+=str[index][0].toUpperCase()+str[index].substring(1);    
}
console.log(result);
