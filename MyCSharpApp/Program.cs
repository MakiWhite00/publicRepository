using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // 実行中のアセンブリを取得
        Assembly assembly = Assembly.GetExecutingAssembly();

        // アセンブリのバージョン情報を取得
        AssemblyName assemblyName = assembly.GetName();
        Version version = assemblyName.Version;

        // 情報を表示
        Console.WriteLine("アセンブリ名: " + assemblyName.Name);
        Console.WriteLine("バージョン: " + version);

        // 詳細情報 (AssemblyInformationalVersion) を表示
        var informationalVersionAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
        if (informationalVersionAttribute != null)
        {
            Console.WriteLine("情報バージョン: " + informationalVersionAttribute.InformationalVersion);
        }

        // アプリケーション終了待ち
        Console.WriteLine("\n終了するにはEnterキーを押してください...");
        Console.ReadLine();
    }
}
