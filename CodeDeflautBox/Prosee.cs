using System;

namespace CodeDeflautBox
{
    static class Funcs
    {
        public static void Cl(string[] str)
        {
        System.Diagnostics.Process pro = new System.Diagnostics.Process();
        pro.StartInfo.FileName = @"cmd.exe";
        pro.StartInfo.UseShellExecute = false;
        pro.StartInfo.RedirectStandardInput = true;
        pro.StartInfo.RedirectStandardOutput = true;
        pro.StartInfo.RedirectStandardError = false;
        pro.StartInfo.CreateNoWindow = false;
        pro.StartInfo.ErrorDialog = true;

        pro.Start();
            for (int i = 0; i < str.Length; i++)
            {
                pro.StandardInput.WriteLine($"@echo {str[i]}");
                pro.StandardInput.AutoFlush = true;
            }
            pro.StandardInput.WriteLine($"pause");
        

        pro.Close();
        }
    }
}