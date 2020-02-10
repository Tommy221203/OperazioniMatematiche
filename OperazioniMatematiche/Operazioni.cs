using System;

namespace OperazioniMatematiche
{
    public class Operazioni
    {
        public static double Somma(double a, double b)
        {
            double somma = a + b;
            return somma;
        }
        public static double Sottrazione(double a, double b)
        {
            double sottrazione = a - b;
            return sottrazione;
        }
        public static double Divisione(double a, double b)
        {
            double divisione = a / b;
            return divisione;
        }
        public static double Moltiplicazione(double a, double b)
        {
            double moltiplicazione = a * b;
            return moltiplicazione;
        }
        public static double Potenza(double a)
        {
            double potenza = a *a;
            return potenza;
        }
        public static double Minimo(double a, double b)
        {
            double minimo = Math.Min(a, b);
            return minimo;
        }
        public static double Massimo(double a, double b)
        {
            double massimo = Math.Min(a, b);
            return massimo;
        }
    }
}
