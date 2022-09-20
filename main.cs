/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
    static void Main(String[] arg){
            int []arr= {2,4,6,8,10};
         Console.Write("Array Elements are :");
        for(int i =0; i<arr.Length; i++){
            Console.Write(arr[i]+" ");
            
            
        }
        int element;
        Console.WriteLine("Enter the element you want to delete from Array : ");
        element = Convert.ToInt32(Console.ReadLine());
        int pass=0;
        int []arr_new = new int [arr.Length-1];
        for(int i =0; i<arr_new.Length; i++){
           
            arr_new[i]=arr[i];
            
            if(arr[i]==element){
                arr_new[i]=arr[i+1];
                pass=i+1;
                  for(int j=pass;  j < arr_new.Length; j++){
                   arr_new[j]=arr[j+1];
                  }
                  break;    
            }
            
            
        }
        for(int i=0; i<arr_new.Length; i++){
            Console.Write(arr_new[i]+", Noice");
        }
  }
}

