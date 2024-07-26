using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_Assincrona
{
     public class ExemploAsync
    {
        async Task<bool> Task_TResult_Async()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }
        async Task Task_Void_Async()
        {
            await Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa Longa executada");
        }
        public async Task Task_LongaDuracao()
        {
            bool isAnoBissexto = await Task_TResult_Async();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um ano bissexto");
            await Task_Void_Async();
        }
    }
}
