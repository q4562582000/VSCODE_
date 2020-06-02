using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VSpratice
{
    public class Person
    {
        public string name{set;get;}
        //"??????????"
        private String newId;
        private int newHeight;
        private int newWeight;
        private int newAge;
        public String id {
            get{return newId; }
            set{ 
           
                //身分證字號驗證
                String [] eng = {"A","J","S","B","K","T","C","L","U","D","M","V","E","N","W","F","O","X","G","P","Y","H","Q","Z","I","R"};
                List<String>  listEng= new List<String>{"A","J","S","B","K","T","C","L","U","D","M","V","E","N","W","F","O","X","G","P","Y","H","Q","Z","I","R"}; 
                
                int [] n ={10  ,18 ,26  ,11  ,19  ,27  ,12 ,20  ,28 ,13  ,21  ,29  ,14  ,22  ,32  ,15 ,35  ,30 ,16  ,23  ,31  ,17  ,24  ,33  ,34 ,25 };
                List<int>  listInt= new List<int>{10  ,18 ,26  ,11  ,19  ,27  ,12 ,20  ,28 ,13  ,21  ,29  ,14  ,22  ,32  ,15 ,35  ,30 ,16  ,23  ,31  ,17  ,24  ,33  ,34 ,25 };

                String idNum = value;

                if( Regex.IsMatch(idNum,@"^[\w]{1}[1-2]{1}[0-9]{8}$") ){
                    // Console.WriteLine(idNum.Substring(0,1));
                    int sum = 0 ;
                    int en = listEng.IndexOf(idNum.Substring(0,1));
                    
                    sum += n[en]/10; 
                    sum += n[en]%10*9;
                    
                    int plus = 8 ;
                    for(int x = 1;x<10;x++){
                        sum += int.Parse(idNum.Substring(x,1))*plus;
                        if (plus>1){
                            plus--;
                        }
                    }
                    // Console.WriteLine("sum = "+sum);
                    if(sum%10==0){
                        Console.WriteLine("身分證字號格式正確!!!");
                        newId =value;

                    }else{
                        Console.WriteLine("身分證字號格式錯誤!!!");
                        Console.Write("請重新輸入身分證字號:");
                        id = Console.ReadLine();
                    }


                }else{
                    Console.WriteLine("身分證字號格式錯誤!!!");
                    Console.Write("請重新輸入身分證字號:");
                    id = Console.ReadLine();
                }
            }
        } 
        public int height{
            get{return newHeight;}
            set{
                if(value>200 || value<30){
                    Console.WriteLine("身高必須在30~200之間!!!");
                    newHeight  = reEntryInt("height");
                }else{
                    newHeight = value;
                }
            }
        }
        public int weight{
            get{return newWeight;}
            set{
                if(value>150 || value<30){
                    Console.WriteLine("體重必須在30~150之間!!!");
                    newWeight  = reEntryInt("weight");
                }else{
                    newWeight = value;
                }
            }
        }
        public int age{
            get{return newAge;}
            set{
                if(value>120  || value<0){
                    Console.WriteLine("年齡必須在0~120之間!!!");
                     newHeight  = reEntryInt("age");
                }else{
                    newAge = value;
                }
            }
        }

        public string ToString(){
            return $"name:{name},id:{id}";
        }
        private int reEntryInt(String type){
            if (type == "age"){
                Console.Write("請重新輸入年齡:");
                age = int.Parse( Console.ReadLine());
            }else if (type == "height"){
                Console.Write("請重新輸入身高:");
                height = int.Parse(Console.ReadLine());
            }else if (type == "weight"){
                Console.Write("請重新輸入體重:");
                weight = int.Parse(Console.ReadLine());

            }
            
            
            
            return 0 ;


        }

    }
}   