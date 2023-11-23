let arr = [4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7]
//4) Yuxaridaki arrayda 5 reqeminin nece defe tekrarlandigini tapin
// var count=0;
// for (var item of arr) {
//  if(item==5){
//     count++;
//  }
// }
// console.log(count)
//5) Yuxaridaki arraydaki butun reqemlerin cemini tapin
// var sum=0;
// for (var item of arr) {
//    sum+=item; 
// }
// console.log(sum)
//6) arrayda tekrar olunan reqemleri artan sira ile duzun
// var c=0;
// for(var i=0;i<arr.length;i++){
//     for(var j=0;j<arr.length;j++){
//         if(arr[i]==arr[j]){
//             c++;
//         }
//     }
// }
// if()
//7) arraydaki en boyuk reqemi tapin ve nece defe tekrarlandigini gosterin
// var max=arr[0],c=0;
// for (var item of arr) {
//     if(max<item){
//         max=item;
//     }
// }
// for (var x of arr) {
//     if(max==x){
//         c++;
//     }
// }
// console.log(c)
//9) Adinizdaki herflerin sayini tapin ve hemin sayin arrayda olub olmamasini yoxlayin Meselen Murad adinda 5 herf var ve 5 arrayda var
// var ad='ilkin', b=false
// for (var x of arr) {
//    if(ad.length==x){
// b=true;
//    }
// }
// console.log(b)
//10) arraydaki ilk 3 e bolunende qaliqda 2 alinan reqemi ve hemin reqemin arraydaki indexini tapin
// for (var i=0;i<arr.length;i++) {
//     if(arr[i]%3==2){
//         console.log(i)
//         break
//     }
// }
//12) 4 reqeminin arrayin hansi indexlerinde oldugunu gosterin
// for (var i=0;i<arr.length;i++) {
//     if(arr[i]==4){
//         console.log(i)
//     }

// }
//14) "arr" - arrayindan reqemleri 2 den boyuk olan yeni array yaradin ve alinmish arrayla "arr" arrayinin uzunluqlari ferqini hesablayin
// var arr2=[]
// for (var x of arr) {
//     if(x>2){
//         arr2.push(x)
//     }
// }
// console.log(arr2)
//15) 7 reqeminin indexleri cemini tapin.
// var sum=0;
// for (var i=0;i<arr.length;i++) {
// if(arr[i]==7){
// sum+=i;
// }
// }
// console.log(sum)
let arr2 = [
    {
        name: 'test',
        key: 1
    },
    {
        name: 'task',
        key: 2
    },
    {
        name: 'tanqo',
        key: 3
    },
    {
        name: 'like',
        key: 4
    },
    {
        name: 'task',
        key: 5
    },
    {
        name: 'trust',
        key: 6
    },
    {
        name: 'test',
        key: 7
    },
    {
        name: 'last',
        key: 8
    },
    {
        name: 'tanqo',
        key: 9
    },
    {
        name: 'elephant',
        key: 10
    },
    {
        name: 'love',
        key: 11
    },
    {
        name: 'small',
        key: 12
    },
    {
        name: 'little',
        key: 13
    },
]
// 16 arr2 de "name"-i "t" herfi ile bashlayan obyektleri yeni arraya yigin
// var ar=[]
//   for(var i=0;i<arr2.length;i++){
//     if(arr2[i].name.charAt(0)=='t'){
//         ar.push(arr2[i])
// }

// }
// console.log(ar)
// 17 arr2 de "name"-i "t" herfi ile bashlayib "t" herfi ile biten obyektlerin sayini tapin
// var c=0;
// for(var i=0;i<arr2.length;i++){
//     if(arr2[i].name.charAt(0)=='t' && arr2[i].name.charAt(arr2[i].name.length-1)=='t'){
//         c++;
// }}
// console.log(c)
// 18 arr2 de "name"-i "t" herfi ile bashlayib "t" herfi ile biten obyektlerin "key"- lerinin cemini tapin
// var sum=0;
// for(var i=0;i<arr2.length;i++){
//     if(arr2[i].name.charAt(0)=='t' && arr2[i].name.charAt(arr2[i].name.length-1)=='t'){
//         sum+=arr2[i].key;
// }}
// console.log(sum)
// 19 arr2 de "name"-i "e" herfi ile biten obyeklerdeki name-in deyerini "SuperDev" sozu ile evezleyin.
// for(var i=0;i<arr2.length;i++){
//     if(arr2[i].name.charAt(0)=='t' && arr2[i].name.charAt(arr2[i].name.length-1)=='t'){
//         arr2[i].name='SuperDev'
// }}
// 20 arr2 de "name"-i en uzun olan obyektin key-i ni tapin
// var k, len = arr2[0].name.length;
// for (var i = 0; i < arr2.length; i++) {
//     if (arr2[i].name.length > len) {
//         len = arr2[i].name.length
//         k = arr2[i].key
//     }
// }
// console.log(k)
// 21 arr2 de "name"-i en uzun olan obyektin indexin kvadratini hesablayin
// var kv,len=arr2[0].name.length;;
// for(var i=0;i<arr2.length;i++){
//     if(arr2[i].name.length>len){
//         len=arr2[i].name.length
//         kv=i*i;
// }}
// console.log(kv)
// 22 arr2 de "name"-inin uzunlugu 4 olan obyektlerden ibaret yeni array yaradin.
// var array=[]
// for(var i=0;i<arr2.length;i++){
//     if(arr2[i].name.length==4){
//         array.push(arr2[i])
// }}
// console.log(array)

// 23 arr2 de en boyuk "key" - i olan obyektin "name"-i ni tapin
// var max = arr2[0].key, index
// for (var i = 0; i < arr2.length; i++) {
//     if (arr2[i].key > max) {
//         max = arr2[i].key;
//         index = i;
//     }
// }
// console.log(arr2[index].name)
// 24 arr2 de terkibinde 2 'L' herfi olan obyekt(ler)in index(ler)ini tapin.
// var c = 0;
// for (var i = 0; i < arr2.length; i++) {
//     for (var j = 0; j < arr2[i].name.length; j++) {
//         if (arr[i].name[0] == 'l') {
//             c++;
//         }
//     }

//     if (c == 2) {
//         console.log(i)
//     }
//     c = 0;
// }
let a = [1,23,3, 3, 2,4, 7, 2, 1],b=[]
var c=0,s="";
for (var i = 0; i < a.length; i++) {
    if(b.includes(a[i])){
        continue;
    }
    for (var j =0; j < a.length; j++) {
        if(a[i]==a[j]){
            c++;
        }
    }
    b.push(a[i])
    if(c>1){
       s+=a[i];
    }
    console.log(a[i]+':'+c)
    c=0;
}
console.log(s)

