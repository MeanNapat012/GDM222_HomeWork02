using System;

class Program {
    static void Main(string[] args) {
        int maxCoordinates = 100;
        double[] x = new double[maxCoordinates];
        double[] y = new double[maxCoordinates];

        int i;
        for (i = 0; i < maxCoordinates; i++) {
            double codex = double.Parse(Console.ReadLine());
            double codey = double.Parse(Console.ReadLine());


            if (codex != 0 || codey != 0) {
                x[i] = codex;
                y[i] = codey;
            } else {
                break; 
            }
        }

        double Kx = double.Parse(Console.ReadLine());
        double Ky = double.Parse(Console.ReadLine());

      
        int j = i - 1; 
        bool inside = true;
        for (i = 0; i < j; i++) {
            if (((y[i] > Ky) != (y[j] > Ky)) && (Kx < (x[j] - x[i]) * (Ky - y[i]) / (y[j] - y[i]) + x[i]) || Kx == 0 && Ky == 0) {
                inside = false;
            }
            j = i;
        }

        if (inside) {
            Console.WriteLine("inside");
        } else {
            Console.WriteLine("outside");
        }

    }
}
