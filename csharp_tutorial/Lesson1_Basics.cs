using System; // 引入 System 命名空间，包含 Console、字符串等基础类型。

namespace CSharpTutorialApp
{
    internal static class Lesson1_Basics
    {
        // Run 方法用来执行本课代码。
        public static void Run()
        {
            // 输出课程标题。
            Console.WriteLine("\n=== 第 1 课：基本语法 (变量、类型、输出) ===\n");

            // 变量和类型：C# 是强类型语言，每个变量都有固定类型。
            int number = 42; // 整数类型
            double price = 19.99; // 双精度浮点数
            string name = "世界"; // 字符串
            bool isActive = true; // 布尔值

            // 输出变量值到控制台。
            Console.WriteLine($"整数 (int): {number}");
            Console.WriteLine($"浮点数 (double): {price}");
            Console.WriteLine($"字符串 (string): {name}");
            Console.WriteLine($"布尔值 (bool): {isActive}");

            // 常量：值在定义后不可更改。
            const double Pi = 3.14159;
            Console.WriteLine($"常量 (const): Pi = {Pi}");

            // 读取用户输入：先输出提示，然后调用 Console.ReadLine()。
            Console.Write("请输入你的名字: ");
            var input = Console.ReadLine();

            // 使用字符串插值 ($"...") 输出包含变量的文本。
            Console.WriteLine($"你好，{input}！\n");

            // 等待用户按键再返回菜单。
            Console.WriteLine("按任意键返回菜单...");
            Console.ReadKey(true); // true：按键不显示在控制台上。
        }
    }
}
