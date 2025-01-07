namespace MultiLevelInheritanceDemo
{
    internal class Program
    {
        // student rn name batch
        // sports sportname score
        // test marks in 5 subjects , totalmarks
        // result > gettotalscore , totalscore =  score + totalmarks
        static void Main(string[] args)
        {
          Result result = new Result();
            result.GetDetails();
            result.CalculateTotalMarks();
            result.CalculateTotalScore();
            result.DisplayDetails();
           
        }
    }
}
