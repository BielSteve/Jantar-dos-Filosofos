using System;
using System.Collections.Generic;

namespace BielFilosofos.jantar
{
    public class Relatorio
    {
        public Dictionary<string, long> relatorios = new Dictionary<string, long>();
        public Dictionary<string, string> status = new Dictionary<string, string>();
        Action method;

        public Relatorio(Action method)
        {
            this.method = method;
        }

        public void adicionaRelatorio(string key, int value)
        {
            this.relatorios.Add(key, value);
        }

        public void adicionaStatus(string key, string value)
        {
            this.status.Add(key, value);
        }

        public long pegaValorDoRelatorio(string key)
        {
            long value;
            if (this.relatorios.TryGetValue(key, out value))
            {
                return value;
            }
            return 0;
        }

        public string pegaValorDoStatus(string key)
        {
            string value;
            if (this.status.TryGetValue(key, out value))
            {
                return value;
            }
            return "";
        }

        public void incrementaRelatorio(string Name)
        {
            long value = this.pegaValorDoRelatorio(Name);
            value += 1;
            this.relatorios[Name] = value;
            this.method();
        }


        public void atualizaRelatorio(string Name, long valor)
        {
            this.relatorios[Name] = valor;
            this.method();
        }

        public void atualizaStatus(string Name, string valor)
        {
            this.status[Name] = valor;
            this.method();
        }

    }
}