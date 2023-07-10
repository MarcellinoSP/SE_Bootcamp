using Calculate;
namespace Program;
class Program
{
    static void Main(){
        int firstVectorSize;
        int secondVectorSize;
        int[] firstVectorContent = new int[400];
        int[] secondVectorContent = new int[400];
        //Main Program
        Console.WriteLine("Dot Product Calculator");
        //Declare first vector size
        Console.WriteLine("Insert first vector size");
        firstVectorSize = Convert.ToInt32(Console.ReadLine());

        //Declare first vector
        Console.WriteLine("Insert first vector content");
        for (int i = 0; i < firstVectorSize; i++){
            firstVectorContent[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        //Declare second vector size
        Console.WriteLine("Insert second vector size");
        secondVectorSize = Convert.ToInt32(Console.ReadLine());

        //Declare second vector
        Console.WriteLine("Insert second vector content");
        for (int i = 0; i < secondVectorSize; i++){
            secondVectorContent[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Console.WriteLine(firstVectorContent[]);
    }
}