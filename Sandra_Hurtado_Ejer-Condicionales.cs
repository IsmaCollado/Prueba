using System;


namespace Ejer_Condicionales
{
    class Program
    {
        static void Main()
        {
            ///PARTE1////

            #region EJERCICIO1 
            //Pide dos números enteros y di cual es el mayor.
            //Realiza el ejercicio de dos formas diferentes:
            //1.Utilizando un if
           //2.Utilizando el operador ternario ?:


            //CON IF
            Console.Write("Introduce un número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            int b = int.Parse(Console.ReadLine());

            string mensaje = "El mayor es ";

            if (a > b)
            {
                mensaje += ($"{a}");
            }
            else
            {
                mensaje += ($"{b}");
            } 
            Console.WriteLine($"{mensaje}");
            

            //UTILIZANDO EL TERNARIO ?:
            Console.Write("Introduce un número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            int b = int.Parse(Console.ReadLine());

            int mayor;
            mayor = (a > b ? a : b);
            Console.WriteLine($"El mayor es {mayor}");
           #endregion

            #region EJERCICIO2

            //Pide dos letras y di si son iguales o distintas

            Console.Write("Introduce una letra: ");
            char a = char.Parse(Console.ReadLine());
            Console.Write("Introduce otra letra: ");
            char b = char.Parse(Console.ReadLine());


            if (a == b)
            {
                Console.WriteLine("Son letras iguales");
            }
            else
            {
                Console.WriteLine("Son letras distintas");
            }
            #endregion

            #region EJERCICIO3
            //Se piden dos números, si el primero es mayor que el segundo se calcula su resta, sino 
            //se calcula su suma

            Console.Write("Introduce un número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            int resta = num1 - num2;

            if (num1 > num2)
            {
                Console.WriteLine($"El mayor es {num1} y la suma es:\n{suma}");
            }
            else
            {
                Console.WriteLine($"El mayor es {num2} y la resta es:\n{resta}");
            }
            #endregion

            #region EJERCICIO4
            //Se piden tres números, di cual es el mayor,
            //cual el mediano, y cual el menor

            Console.Write("Introduce un número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor;
            int mediano;
            int menor;

            if (num1 > num2 && num1 > num3)
            {
                mayor = num1;

                if (num2 > num3)
                {
                    mediano = num2;
                    menor = num3;
                }
                else
                {
                    mediano = num3;
                    menor = num2;
                }
            }
            if (num3 > num1)
            {
                mayor = num3;

                if (num1 > num2)
                {
                    mediano = num1;
                    menor = num2;
                }
                else
                {
                    mediano = num2;
                    menor = num1;

                    Console.WriteLine($"El mayor es: {mayor} ");
                    Console.WriteLine($"El mediano es: {mediano} ");
                    Console.WriteLine($"El menor es: {menor} ");
                }
            }
            #endregion

            #region EJERCICIO5

            //Se pide una cantidad y su precio. Hay que hallar el total aplicando
            //un tanto por ciento de descuento según la cantidad comprada

            Console.Write("Introduzca la cantidad de productos a comprar: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el precio de la compra: ");
            int precio = int.Parse(Console.ReadLine());


            int precioTotal = (precio * cantidad);
            double descuento1 = 0;
            double descuento2 = 0.5;
            double descuento3 = 0.10;
            double descuento4 = 0.15;
            string mensaje1 = "Se le hace un descuento del ";
            string mensaje2 = "El precio total es:";

            if (cantidad >= 0 && cantidad <= 10)
            {
                mensaje1 += "0%";
                Console.WriteLine($"{mensaje2}\n {precioTotal -  (descuento1 * precioTotal)}");
            }
            else if (cantidad >= 11 && cantidad <= 30)
            {
                mensaje1 += "5%";
                Console.WriteLine($"{mensaje2}\n {precioTotal -  (descuento2 * precioTotal)}");
            }
            else if (cantidad >= 31 && cantidad <= 50)
            {
                mensaje1 += "10%";
                Console.WriteLine($"{mensaje2}\n {precioTotal - (descuento3 * precioTotal)} ");
            }
            else
            {
                mensaje1 += "15%";
                Console.WriteLine($"{mensaje2}\n {precioTotal - (descuento4 * precioTotal)} ");
            }
            Console.WriteLine($"{mensaje1}");
            #endregion

            #region EJERCICIO6

            //Una compañía de videojuegos te ha contratado para escribir el programa de un
            //videojuego nuevo.Deberás crear la parte del programa que calcula el número total de
            //puntos que un jugador gana en el juego Galaxy.
            //Los jugadores acumulan puntos mediante la recolección de objetos.
            //Los objetos tienen asignados los siguientes puntos:
            //• Estrella = 10 puntos.
            //• Planeta = 20 puntos.
            //• Asteroide = 50 puntos.
            //• Cometa = 100 puntos.
            //Si un jugador acumula más de 5.000 puntos, en una misma jugada, ganará un bono de
            //500 puntos.
            //Implementa pues una jugada, donde le pidamos al usuario el nombre de un objeto y el
            //número de estos que ha recogido.Mostrando el total de puntos teniendo en cuenta los
            //bonos.
            //Nota: Usar un Switch para decidir los puntos del objeto.
            Console.Write("Introduce el nombre el objeto que has recogido: ");
            string objeto = Console.ReadLine();
            Console.Write("Introduce el número de objetos que has recogido: ");
            int cantidadObjeto = int.Parse(Console.ReadLine());

            int puntuacion = 0;
            switch (objeto)
            {
                case "estrella":
                    puntuacion += 10;
                    break;
                case "planeta":
                    puntuacion += 20;
                        break;
                case "asteroide":
                    puntuacion += 50;
                    break;
                case "cometa":
                    puntuacion += 100;
                    break;
            }
            puntuacion *= cantidadObjeto;

            if (puntuacion > 5000)
            {
                Console.Write($"Has obtenido una puntuación extra de 500 puntos, por lo que tu puntuación es: \n{puntuacion+500}\n");
            }
            else
            Console.WriteLine($"Tu puntuacion es: {puntuacion}");
            #endregion

            #region EJERCICIO7
            /*Una empresa solicita a su departamento de informática un programa para la confección
            de facturas.
            La mayoría de los artículos que vende dicha compañía soportan un IVA de consumo del
            12 %, y sólo unos pocos están cargados con un IVA del 6 %.
            El programa leerá el nombre, dirección y CIF del comprador y el total a pagar.
            Además preguntará si el articulo es de consumo o no. Imprimiendo la factura con el
            cálculo la base imponible y el IVA soportado.*/

            Console.Write("Introduce el nombre de la empresa: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce el nombre del comprador: ");
            string nombreComprador = Console.ReadLine();
            Console.Write("Introduce la dirección de la empresa: ");
            string direccion = Console.ReadLine();
            Console.Write("Introduce el total a pagar: ");
            int totalPagar = int.Parse(Console.ReadLine());
            

            Console.Write("¿El artículo es de consumo? Conteste con S o N: ");
            string consumo = Console.ReadLine();
            double IVAConsumo = 0.12;
            double IVANoConsumo = 0.06;

            
            double iva;
            
            if (consumo == "S") 
            {
                iva = IVAConsumo;
            }
            else
            {
                iva = IVANoConsumo;
            }
            string factura = $"{nombre}\n{nombreComprador}\n{direccion}\n{totalPagar - (totalPagar * iva)}";
            Console.WriteLine($"Se te aplica un IVA del {iva*100:F0}%");
            Console.WriteLine($"El total a pagar  es: {totalPagar - (totalPagar * iva)}");
            Console.WriteLine($"Tu factura es: \n{factura}");
            #endregion

            //PARTE2////

            #region EJERCICIO1

            /*
             Se pide una cantidad y un precio por teclado, si la cantidad es mayor o igual a 1000
            unidades se le aplica un 12% de IVA, si la cantidad es menor de 1000 se le aplica un 15%
            de IVA.
             */

            Console.Write("Introduce la cantidad a comprar: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Introduce la cantidad a comprar: ");
            int precio = int.Parse(Console.ReadLine());

            int precioTotal = cantidad * precio;
            double IVA1 = 0.12;
            double IVA2 = 0.15;
            string mensaje1 = "Se te aplica un ";
            string mensaje2 = "El resultado es ";

            if (cantidad >= 1000)
            {
                mensaje1 += "12%";
                Console.WriteLine($"{mensaje2}\n{precioTotal - (precioTotal * IVA1)}");
            }
            else
            {
                mensaje1 += "15%";
                Console.WriteLine($"{mensaje2}\n{precioTotal - (precioTotal * IVA2)}");
            }

            Console.WriteLine($"{mensaje1}");
            #endregion

            #region EJERCICIO2
            /*
             Se pide una nota. Si la nota es menor que 5 se visualizará el texto SUSPENSO, si la nota
            está entre 5 y 6 (sin incluirlo) se visualizará el texto APROBADO, si la nota está entre 6 y
            7 (sin incluirlo) se visualizará el texto BIEN, si la nota está entre 7 y 9 (sin incluirlo) se
            visualizará el texto NOTABLE, en otro caso visualizará el texto SOBRESALIENTE.
            */
            Console.Write("Introduce tu nota: ");
            float nota = float.Parse(Console.ReadLine());

            string mensaje = "Tu nota es un ";
            string suspenso = "SUSPENSO";
            string aprobado = "APROBADO";
            string bien = "BIEN";
            string notable = "NOTABLE";
            string sobresaliente = "SOBRESALIENTE";

            if (nota < 5)
            {
                mensaje += suspenso;
            }
            else if (nota >=5 && nota <= 5.99 )
            {
                mensaje += aprobado;
            }
            else if (nota >= 6 && nota <= 6.99)
            {
                mensaje += bien;
            }
            else if (nota >= 7 && nota <= 8.99)
            {
                mensaje += notable;
            }
            else
            {
                mensaje += sobresaliente;
            }
            Console.WriteLine($"{mensaje}");
            #endregion

            #region EJERCICIO3

            /*
             Una persona debe P euros. Propone devolver esa cantidad en n
            pagos anuales. Si la tasa de interés en t.p.u. que se le aplica es i,
            el pago anual se calcula mediante la formula de la derecha.
            Se desea un programa que lea P, n e i, y calcule la cantidad A
            que debe pagar cada año y los intereses totales que ha pagado.
             */
            Console.Write("Introduce la cantidad que debes devolver: ");
             int p = int.Parse(Console.ReadLine());
             Console.Write("Introduce la cantidad de años en los que vas a devolver el dinero: ");
             int n= int.Parse(Console.ReadLine());
             Console.Write("Introduce los intereses: ");
             int i = int.Parse(Console.ReadLine());

             double a = p * i * Math.Pow(1+i,n)/(Math.Pow(1+i,n)) - 1;

             double interesTotal = a * i;

             Console.WriteLine($"Debes pagar cada año: {a}");
             Console.WriteLine($"Los intereses totales son: {interesTotal}");
            #endregion

            #region EJERCICIO4
            /*
            Se pide una letra, si la letra es d o D, se escribirá en la pantalla DESCUENTO, si la letra
            es I o i, se escribirá IVA en la pantalla, si la letra es P o p, se escribirá PORCENTAJE , en
            otro caso se escribirá DATO ERRONEO. Realiza el ejercicio con switch.
            */
            Console.Write("Introduce una letra: ");
            char letra = char.Parse(Console.ReadLine());
            string mensaje = "";

            switch(letra)
            {
                case 'd':
                case 'D':
                    mensaje += "DESCUENTO";
                    break;

                case 'i':
                case 'I':
                    mensaje += "IVA";
                    break;

                case 'p':
                case 'P':
                    mensaje += "PORCENTAJE";
                    break;

                default:
                    Console.Write("DATO ERRÓNEO");
                    break;
            }

            Console.WriteLine($"{mensaje}");
            #endregion

            #region EJERCICIO5
            /*
            Se piden cuatro números. Calcula el máximo.
            */
            Console.Write("Introduce el primer número: ");
             int a = int.Parse(Console.ReadLine());
             Console.Write("Introduce el segundo número: ");
             int b = int.Parse(Console.ReadLine());
             Console.Write("Introduce el tercer número: ");
             int c = int.Parse(Console.ReadLine());
             Console.Write("Introduce el cuarto número: ");
             int d = int.Parse(Console.ReadLine());

             string maximo = "El máximo numero es ";

             if (a > b &&  a > c && a > d)
             {
                 maximo += a;

             }
             else if (b > a && b > c && b > d)
             {
                 maximo += b;
             }
             else if (c > a && c > b && c > d)
             {
                 maximo += c;
             }
             else if (d > a && d > b && d > c)
             {
                 maximo += d;
             }

             Console.WriteLine($"{maximo}");
            #endregion

            #region EJERCICIO6
            /*
            Gestionamos un hotel. Se pide el número de noches y si quieren habitación individual (I) o
            habitación doble (D). Si el número de noches es mayor de 2 y la habitación es individual
            cobraremos 25€ pero si la habitación es doble cobraremos 40€. Si el número de noches
            es menor o igual a 2 y la habitación individual cobraremos 27€, pero si la habitación es
            doble cobraremos 44€.
            */

            Console.Write("Introduce el número de noches que desea hospedarse: ");
            int noches = int.Parse(Console.ReadLine());
            Console.Write("¿Desea habitación individual o doble? (I o D) ");
            string habitacion = Console.ReadLine();

            if (noches > 2 && habitacion == "I")
            {
                Console.WriteLine("El precio es 25");
            }
            else if (noches > 2 && habitacion == "D")
            {
                Console.WriteLine("El precio es 40");
            }    
            else if ( noches <=2 && habitacion =="I")
            {
                Console.WriteLine("El precio es 27");
            }
            else if (noches <= 2 && habitacion == "D")
            {
                Console.WriteLine("El precio es 44");
            }
            #endregion




        }
    }
}

