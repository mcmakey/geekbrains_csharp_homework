// ASP.NET Core Web API ������������
// ���� 1

// �������� ���� ���������� � ������ � ���, ������� �� ������������� ��������� ����������������
// 1. ����������� ��������� ����������� � ��������� �����
// 2. ����������� ��������������� ���������� ����������� � ��������� �����
// 3. ����������� ������� ���������� ����������� � ��������� ���������� �������
// 4. ����������� ��������� ������ ����������� ����������� �� ��������� ���������� �������

// �������� ������ ��� ����������� - ������ ���� "�����"
// �������� ������ ��� ������� - ������ ���� "��:��:��"


using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Exercise_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
