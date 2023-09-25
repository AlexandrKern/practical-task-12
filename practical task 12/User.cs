using banking_system_prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace banking_system_prototype
{
    public class User:Client<string,string,string>
    {
        public User(ulong deposit = 0, ulong nonDeposit = 0)
        {
            depositAccount = deposit;
            nonDepositAccount = nonDeposit;
        }
        /// <summary>
        /// Открывает счет
        /// </summary>
        /// <returns></returns>
        public ulong OpenAnAccount()
        {
            var r = new Random();                   /*генерируем случайное число типа ulong*/
            var b = new byte[sizeof(ulong)]; 
            r.NextBytes(b);
            var res = BitConverter.ToUInt64(b, 0);
            return res;
        }
        /// <summary>
        /// Создает клиентов
        /// </summary>
        /// <returns></returns>
        public List<Client<string, string, string>> AddClients()
        {
            Client<string, string, string> client;
            List<Client<string, string, string>> clients = new List<Client<string, string, string>>();
            for (int i = 1; i < 11; i++)
            {
                client = new Client<string, string, string>($"Фамилия_{i}",
                    $"Имя_{i}",
                    $"Отчество_{i}");
                clients.Add(client); 
            }
            return clients;
        }
    }
}
