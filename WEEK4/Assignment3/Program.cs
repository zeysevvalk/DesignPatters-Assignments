using System;

namespace Assignment3;

class Program
{
    static void Main(string[] args)
    {
        Start();
    }
    // Example method
    static void Start()
    {
        Tank tank = new Tank();
        tank.AssignDriver("Frank");

        // create a robot
        Robot robot = new Robot();
        RobotAdapter robotAdapter = new RobotAdapter(robot);
        robotAdapter.AssignDriver("Mark");

        // create attackers list, and add tank and robot
        List<IAttacker> attackers = new List<IAttacker>();
        attackers.Add(tank);
        attackers.Add(robotAdapter);

        // process all attackers
        foreach (IAttacker attacker in attackers)
        {
            Console.WriteLine($"Driver of attacker: {attacker.Driver}");
            attacker.DriveForward();
            attacker.UseWeapon();
        }
    }

}