int[] array = {12, 13, 44, 1111, 55, 11, 33, 443, 1111,};

int n = array.Length;
int find = 1111;

int index = 0;

while (index < n)
{
    
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}