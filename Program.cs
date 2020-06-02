using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace VSpratice
{
    class Program
    {
        public static int itemCount = 0;
        public static int unlockItemCount = 0;
        public static Object locker= new Object();
        public static void Main(string[] args)
        {

            Thread t1 = new Thread(forCount);
            Thread t2 = new Thread(forCount);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();




            Console.ReadLine();







        }
        public static void forCount(){
            for(int i =0 ;i<3;i++){
                // unlockItemCount++;
                // Console.WriteLine("unlockItemCount:" + unlockItemCount);
                lock(locker)
                {
                    itemCount++;
                    Console.WriteLine("itemCount:"+itemCount);
                }
               
            }

        }

        static int get_Greatest_Common_Factor (int a , int b ){
            if(a%b==0){
                return b;
            }else{
                return get_Greatest_Common_Factor(b ,a%b);
            }
            
            /*
            if (a>b){
                a = a%b;                 
            }else{
                b = b%a; 
            }
            if(a==0 ){
                return b;
            }else if(b==0 ){
                return a;
            }
            return get_Greatest_Common_Factor(a,b);

            */
        }
        static int get_Octal ( int a  ){
            if(a<8){
                return a ;    
            }else{
               return get_Octal(a/8) *10 +a%8;
            }

        }
        static String get_Hex ( int a ,int b ){
            System.Text.ASCIIEncoding  ascii = new System.Text.ASCIIEncoding();
            if(a<b){
                if (a>10){
                    byte[] btNumber = new byte[] {(byte) ((int)'A' +(a-9)) };
                    return ascii.GetString(btNumber); 
                }else{
                    return a.ToString(); 
                }
            }else{
                if (a>10){
                    byte[] btNumber = new byte[] {(byte) ((int)'A' +(a-9)) };
                    return get_Hex(a/b,b) + ascii.GetString(btNumber) ;
                }else{
                    return get_Hex(a/b,b) + a.ToString(); ; 
                }
               
            }
        }

    }


    public class Dog {
        public void bark(){

        }
    }

    public class DogA :Dog {


    }

    class Member1 {
        public int ID ;
        public String Name ;

        // public Member (int ID, String Name){
        //     this.ID =ID;
        //     this.Name=Name;
        // }

    } 

}
