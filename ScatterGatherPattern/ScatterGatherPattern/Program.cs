class Program
{
    static void Main(string[] args)
    {
        int[] inputData = Enumerable.Range(1, 100).ToArray(); // Генерируем входные данные (массив чисел от 1 до 100)

        // Делим входные данные на несколько частей
        List<int[]> inputChunks = SplitInputData(inputData, 10);

        // Создаем список задач для обработки каждой части в параллельных потоках
        List<Task<int[]>> tasks = new List<Task<int[]>>();
        foreach (int[] chunk in inputChunks)
        {
            tasks.Add(Task.Run(() => ProcessChunk(chunk))); // Обрабатываем каждую часть в отдельном потоке
        }

        // Собираем результаты обработки
        int[] outputData = GatherOutputData(tasks);

        Console.WriteLine("Input Data:");
        PrintArray(inputData);

        Console.WriteLine("Output Data:");
        PrintArray(outputData);

        Console.ReadLine();
    }

    static List<int[]> SplitInputData(int[] inputData, int chunkSize)
    {
        List<int[]> inputChunks = new List<int[]>();
        for (int i = 0; i < inputData.Length; i += chunkSize)
        {
            int[] chunk = new int[Math.Min(chunkSize, inputData.Length - i)];
            Array.Copy(inputData, i, chunk, 0, chunk.Length);
            inputChunks.Add(chunk);
        }
        return inputChunks;
    }

    static int[] ProcessChunk(int[] chunk)
    {
        // Обрабатываем каждый элемент в части (в данном случае просто умножаем на 2)
        return chunk.Select(x => x * 2).ToArray();
    }

    static int[] GatherOutputData(List<Task<int[]>> tasks)
    {
        int[] outputData = new int[tasks.Sum(t => t.Result.Length)];
        int outputIndex = 0;
        foreach (Task<int[]> task in tasks)
        {
            int[] chunk = task.Result;
            Array.Copy(chunk, 0, outputData, outputIndex, chunk.Length);
            outputIndex += chunk.Length;
        }
        return outputData;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}