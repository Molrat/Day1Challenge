namespace Day1Challenge
{
    internal class MaxCaloriesComputer
    {
        internal static int ComputeMaxCalories(string list)
        {
            List<string> lines = list.Split('\n').ToList();
            int totalCalories = 0;
            int maxCalories = 0;
            foreach(string line in lines)
            {
                if (line.Length > 0) 
                { 
                    totalCalories += Convert.ToInt32(line);
                }
                else
                {
                    maxCalories = Math.Max(maxCalories, totalCalories);
                    totalCalories = 0;
                }
            }
            maxCalories = Math.Max(maxCalories, totalCalories);
            return maxCalories;
        }
    }
}
