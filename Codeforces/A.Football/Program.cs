using System;

namespace FootBall{
    class Program{

        public static bool Status(string pos){
            int count = 0;
            int team = int.Parse(pos[0].ToString());

            if(pos.Length < 7){
                return false;
            }
            for(int i = 0; i<pos.Length; i++){
                if(count==7){
                    return true;
                }

                if(int.Parse(pos[i].ToString()) == team){
                    count++;
                }
                else{
                    count = 1;
                    team = int.Parse(pos[i].ToString());
                }
            }

            return false;
        }

        static void Main(){
            string positions = Console.ReadLine();
            Console.WriteLine(Status(positions) ? "Yes" : "No");
        }
    }
}