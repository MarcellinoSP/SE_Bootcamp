namespace Program;

class Program 
{
    static void Main()
    {
        int a = 3;
        int b = 5;
        int n = 15;
        string _stringA = "Foo ";
        string _stringB = "Bar ";

        for(int i = 0; i <= n; i++){
            if(i == 0){
                Console.Write(i + " ");
            }else if(i % a == 0 && i % b == 0){
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