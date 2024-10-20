using System;

namespace Mazes;

public static class DiagonalMazeTask
{
    public static void MoveLeft(Robot robot, int stepCount)
    {
        if (robot.Finished) return ;
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(Direction.Left);
    }
    public static void MoveRight(Robot robot, int stepCount)
    {
        if (robot.Finished) return;
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(Direction.Right);
    }
    public static void MoveUp(Robot robot, int stepCount)
    {
        if (robot.Finished) return;
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(Direction.Up);
    }
    public static void MoveDown(Robot robot, int stepCount)
    {
        if (robot.Finished) return;
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(Direction.Down);
    }
    public static int Ratio(int width, int height)
    {
        int ratio = 0;
        if (width  > height )
            ratio = width / height;
        else ratio = -height / width;
        return ratio;
    }
    public static void Move(Robot robot,Direction direction,int stepCount)
    {
        if (robot.Finished) return;
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(direction);
    }
    public static void MoveOut(Robot robot, int width, int height)
    {
        int ratio = Ratio(width-2, height-2);
        while (!robot.Finished)
        {
            if (ratio > 0)
            {
                Move(robot, Direction.Right, ratio);
                Move(robot, Direction.Down, 1);
            }
            else
            {
                MoveDown(robot, -ratio);
                MoveRight(robot, 1);
            }
        }
    }
}