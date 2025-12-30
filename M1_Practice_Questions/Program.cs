// //Flip Key Logical Problem 
// using System;
// class MainClass{
//     public static void Main(string[] args){
//         Console.WriteLine("Enter the word");
//         string word=Console.ReadLine();
//         if(word.Length<=6){
//             Console.WriteLine("Empty String");
//             return;
//         }
//         word=word.ToLower();
//         // word=word.Replace(" ","");
//         for(int i=0;i<word.Length;i++){
//             if(!char.IsLetter(word[i])){
//                 // word=word.Remove(i,1);
//                 // i--;
//                 Console.WriteLine("Invalid Input");
//                 return;
//             }
//         }
//         for(int i=0;i<word.Length;i++){
//             if((int)word[i]%2==0){
//                 word=word.Remove(i,1);
//                 i--;
//             }
//         }
//         word=new string(word.Reverse().ToArray());
//         string key="";
//         for(int i=0;i<word.Length;i++){
//             if(i%2==0){
//                 char c=char.ToUpper(word[i]);
//                 key+=c;
//             }else{
//                 key+=word[i];
//             }
//         }
//         Console.WriteLine("The generated key is -"+key);

//     }
// }