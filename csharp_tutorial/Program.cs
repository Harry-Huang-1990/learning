using System; // 引入 System 命名空间，包含 Console 等常用类型。

namespace CSharpTutorialApp
{
    // internal：程序集内部可见；static：不允许实例化。
    internal static class Program
    {
        // 程序入口点：程序从 Main 方法开始运行。
        private static void Main(string[] args)
        {
            // 无限循环，除非用户选择退出。
            while (true)
            {
                Console.Clear(); // 清空控制台屏幕。
                Console.WriteLine("C# 入门练习 (循序渐进)"); // 输出标题。
                Console.WriteLine("========================");
                Console.WriteLine("1. 基本语法 (变量、类型、输入输出)");
                Console.WriteLine("2. 控制流 (if / switch / 循环)");
                Console.WriteLine("3. 方法与参数");
                Console.WriteLine("0. 退出");
                Console.Write("请选择编号: "); // 不换行输出提示。

                // 读取用户输入的字符串。
                var choice = Console.ReadLine();

                // 根据用户输入执行不同课程模块。
                switch (choice)
                {
                    case "1":
                        Lesson1_Basics.Run(); // 调用第 1 课。
                        break;
                    case "2":
                        Lesson2_ControlFlow.Run(); // 调用第 2 课。
                        break;
                    case "3":
                        Lesson3_Methods.Run(); // 调用第 3 课。
                        break;
                    case "0":
                        return; // 退出 Main，结束程序。
                    default:
                        // 任何未匹配的输入都会到这里。
                        Console.WriteLine("无效的选择，按任意键重试...");
                        Console.ReadKey(true); // 等待一个键，true 表示不在屏幕上显示按键。
                        break;
                }
            }
        }
    }
}
