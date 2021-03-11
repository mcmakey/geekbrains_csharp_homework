﻿using System;
using System.Diagnostics;

namespace Exercise_6_1
{
    class TaskManager
    {
        public TaskManager()
        {

        }

        public void ShowProcesses()
        {
            Process[] tasks = Process.GetProcesses();
            Console.WriteLine();
            Console.WriteLine("Список процессов:");
            Console.WriteLine();
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"{i + 1}   process id: {tasks[i].Id}   process name: {tasks[i].ProcessName}");
            }
            Console.WriteLine();
        }

        public void EndProcessById(int id)
        {   
            try
            {
                Process process = Process.GetProcessById(id);
                process.Kill();
                Console.WriteLine($"Процесс с id {id} ({process.ProcessName}) завершен");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}