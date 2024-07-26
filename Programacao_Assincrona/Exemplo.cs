using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_Assincrona
{
     class Exemplo
    {
        //metodo com retorno
        bool Task_TResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        //metodo com retorno void
        void Task_Void()
        {
            Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa Longa Executada");

        }

        public void Task_LongaDuracao()
        {
            bool isAnoBissexto = Task_TResult();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto?" é ":"Não é")} um ano bissexto");
            Task_Void();
        }
    }
}
