using System;
using System.Diagnostics;

namespace Automation
{
    public static class Frontend
    {
        static void Main(string[] args)
        {
            string command = "cd .. && cd .. && cd .. && cd .. && cd .. && cd .. && npx create-react-app client --template typescript && cd client && npm install -D tailwindcss postcss autoprefixer && npx tailwindcss init -p && npm i axios && npm i dotenv && echo. > .gitignore && cd src && mkdir components && mkdir pages && cd pages && echo. > Home.tsx && cd client && npm start";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/k {command}",
                UseShellExecute = true,
                CreateNoWindow = false,
            };
        
            Process.Start(startInfo);
        }
    }
}