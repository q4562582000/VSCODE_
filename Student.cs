namespace VSpratice
{
    public class Student
    {
        public string name{set;get;}
        public int id ;
        public int math;
        public int chinese;
        public int english;
        public string ToString(){
            return $"name:{name},id:{id}";
        }

    }
}   