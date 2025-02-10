namespace RobotButtle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarriorRobot warriorRobot = new WarriorRobot();
            DefenderRobot defenderRobot = new DefenderRobot();

            GameManager.StartButtle(warriorRobot, defenderRobot);
            Console.ReadLine();
        }
    }
}
