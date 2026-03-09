using System; // 引入 System 命名空间。

namespace CSharpTutorialApp
{
    internal static class Lesson3_Methods
    {
        public static void Run()
        {
            Console.WriteLine("\n=== 第 3 课：方法 / 参数 / 返回值 ===\n");

            // 调用 Add 方法，并将返回值赋给 sum。
            var sum = Add(10, 20);
            Console.WriteLine($"Add(10, 20) = {sum}");

            // out 参数示例：方法可以通过 out 返回额外的数据。
            if (TryParseInt("123", out var parsed))
            {
                Console.WriteLine($"TryParseInt 解析成功: {parsed}");
            }

            // 可选参数示例：可省略第二个参数。
            Console.WriteLine(Greet("小明"));
            Console.WriteLine(Greet("小红", "下午好"));

            Console.WriteLine("\n按任意键返回菜单...");
            Console.ReadKey(true);
        }

        // Add 方法有两个参数，返回它们的和。
        private static int Add(int a, int b)
        {
            return a + b;
        }

        // TryParseInt 使用 out 参数返回转换结果。
        // out 参数在方法内部必须被赋值。
        private static bool TryParseInt(string input, out int value)
        {
            return int.TryParse(input, out value);
        }

        // 可选参数 greeting 有默认值 "你好"。
        private static string Greet(string name, string greeting = "你好")
        {
            return $"{greeting}, {name}!"; // 字符串插值。
        }
    }
}
