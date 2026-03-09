using System; // 引入 System 命名空间。

namespace CSharpTutorialApp
{
    internal static class Lesson2_ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("\n=== 第 2 课：控制流 (if / switch / loop) ===\n");

            // ----------------- if / else -----------------
            Console.Write("请输入一个整数 (0-10): ");

            // int.TryParse 将字符串转换成整数，返回 false 表示转换失败。
            if (int.TryParse(Console.ReadLine(), out var value))
            {
                // 嵌套 if：根据 value 的范围选择不同输出。
                if (value < 0)
                    Console.WriteLine("你输入的是负数。");
                else if (value <= 5)
                    Console.WriteLine("你输入的是 0 到 5 之间的数字。");
                else
                    Console.WriteLine("你输入的是 6 到 10 之间的数字。");
            }
            else
            {
                // 如果用户输入无法转换成整数，就执行此分支。
                Console.WriteLine("输入不是有效的整数。");
            }

            // ----------------- switch -----------------
            Console.Write("请输入一个英文字符 (a/b/c): ");
            var key = Console.ReadLine();

            // switch 语句根据 key 的值跳转到对应 case。
            switch (key)
            {
                case "a":
                    Console.WriteLine("你选择了 a。");
                    break; // break 退出 switch
                case "b":
                    Console.WriteLine("你选择了 b。");
                    break;
                case "c":
                    Console.WriteLine("你选择了 c。");
                    break;
                default:
                    // 如果都不匹配，就执行 default 分支。
                    Console.WriteLine("未识别的选项。");
                    break;
            }

            // ----------------- 循环 -----------------
            Console.WriteLine("\nfor 循环示例: ");

            // for 循环：从 1 计数到 5。
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"  i = {i}");
            }

            Console.WriteLine("\n按任意键返回菜单...");
            Console.ReadKey(true); // 等待按键再返回菜单。
        }
    }
}
