using System;

namespace Classe_Estática.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.22f;

        public static float RealDolar(float valorReal) {
            return valorReal / CotacaoDolar;
        }

        public static float DolarReal(float valorDolar) {
            return CotacaoDolar * valorDolar;
        }
    }
}