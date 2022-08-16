namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EDaysOfWeek today = EDaysOfWeek.Tuesday;
            int today2 = DayOfWeek.Tuesday;
            int today3 = DaysOfWeekCustomEnum.Tuesday.ID;
        }
    }
}