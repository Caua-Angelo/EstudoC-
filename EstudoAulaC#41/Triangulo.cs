﻿namespace EstudoAulaC_38 {
    internal class Triangulo {

        public double A;
        public double B;
        public double C;

        public double AreaTriangulo() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}