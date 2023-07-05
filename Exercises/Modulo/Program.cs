namespace Program;

class Program 
{
    static void Main()
    {
        int a = 3;
        int b = 5;
        string _stringA = "Foo ";
        string _stringB = "Bar ";

        for(int i = 1; i <= 15; i++){
            if(i % a == 0 && i % b == 0){
                Console.Write(_stringA + _stringB);
            }else if(i % a == 0){
                Console.Write(_stringA);
            }else if(i % b == 0){
                Console.Write(_stringB);
            }else{
                Console.Write(i + " ");
            }
        }
    }
}