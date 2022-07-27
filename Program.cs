string [] FillArray()
{
    string[] array = new string[4];
    for (int i = 0; i< array.Length; i++)
    {
        Console.WriteLine("Input array value");
        array[i] = Console.ReadLine();
    }
    return array;
}

string [] arr = FillArray();
int count = 0;
for (int i = 0; i< arr.Length; i++)
 {
        
        int len = arr[i].Length;
        if(len <= 3)
        {
            count = count+1;
        }
 }

string [] newArray = new string[count];
int i2 =0;
for (int i = 0; i<=count; i++)
{
    if(arr[i].Length <=3)
    {
        newArray[i2++] = arr[i];
    }
}

for (int i = 0; i< newArray.Length; i++)
{
    Console.Write($" {newArray[i]} ");
}
