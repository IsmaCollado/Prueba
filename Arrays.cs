#region Ejercicio 1
/*Realiza un programa que asigne datos aleatoriamente a un array de n elementos, y a
continuación muestre el contenido de dicho array utilizando la instrucción foreach.
Para generar un número aleatorio, puedes usar la función:
Random.Next(int minValue, int maxValue)*/
class Program
	{
		static void Main()
		{
			Console.Write("Introduce la cantidad de elementos que contendra el array: ");
			int longitudArray = int.Parse(Console.ReadLine());
			int[] numeros = new int [longitudArray];
			Random random = new Random();
			foreach (int caracter in numeros)
			{
				int randomNumber = random.Next(0, 101);
				numeros[caracter] = randomNumber;
				Console.WriteLine(numeros[caracter]);
			}
		}
	}
#endregion

#region Ejercicio 2
/*Rellena un array de 10 caracteres de forma aleatoria y visualízalos de cuatro en cuatro.
Para generar un número real entre 0 y 100 puedes hacer:
Random semilla = new Random();
double numeroReal = semilla.NextDouble() * 100d;*/
class Program
	{
		static void Main()
		{
			double[] numeroRandom = new double [10];
			Random random = new Random();
			for (int i = 0; i < numeroRandom.Length; i++)
			{
				double numeroReal = random.NextDouble() * 100d;
				numeroRandom[i] = numeroReal;
			}
			for (int i = 0; i < numeroRandom.Length; i++)
			{
				if (i!= 0 && i%4==0)
				{
					Console.Write("\n");
				}
				Console.WriteLine(numeroRandom[i]+" ");
			}
		}
	}
#endregion

#region Ejercicio 3
/*Programa que sume los valores de un array de 10 elementos reales.*/
class Program
	{
		static void Main()
		{
			int suma = 0;
			int[] numeros = new int [10];
			Random random = new Random();
			for (int i = 0; i < numeros.Length; i++)
			{
				int numeroReal = random.Next(0, 10);
				numeros[i] = numeroReal;
			}
			for (int i = 0; i < numeros.Length; i++)
			{
				suma += numeros[i];
			}
			Console.WriteLine("Resultado de la suma: " + suma);
		}
	}
#endregion

#region Ejercicio 4
/*Rellena un array de 10 caracteres de forma aleatoria y luego sobre el mismo array
modifícalo de forma que los elementos que estén en mayúsculas pasen a ser minúscula y
los minúscula a mayúscula. Visualízalo con la instrucción foreach.
Para saber si un carácter está en mayúcula o en minúscula puedes usar:
bool char.IsLower(char c)
bool char.IsUpper(char c)*/
class Program
	{
		static void Main()
		{
			char[] caracteres = new char[10];
			Random random = new Random();
			for (int i = 0; i < caracteres.Length; i++)
			{
				int caracter = random.Next(65, 123);
				caracteres[i] = Convert.ToChar(caracter);
			}
			for (int i = 0; i < caracteres.Length; i++)
			{
				if (char.IsUpper(caracteres[i]))
					caracteres[i] = Char.ToLower(caracteres[i]);
				else
					caracteres[i] = Char.ToUpper(caracteres[i]);
			}
			foreach (char caracter in caracteres)
			{
				Console.WriteLine(caracter);
			}
		}
	}
#endregion

#region Ejercicio 5
/*Carga un array numérico de diez elementos, visualízalo con la instrucción foreach y luego
visualiza los elementos cuyo contenido sea par, indicando su posición.*/
	class Program
	{
		static void Main()
		{
			int posicionPares = 0;
			int[] numeros = new int[10];
			for (int i = 0; i < numeros.Length; i++)
			{
				Console.Write("Valor para la posicion " + i+ " del array: ");
				int valor = int.Parse(Console.ReadLine());
				numeros[i] = valor;
				
			}
			Console.Write("Todos los numeros del array: ");
			foreach (int posicion in numeros)
			{
				Console.Write(posicion + " ");
			}
			foreach (int numero in numeros)
			{
				if (numero != 0 && numero % 2 == 0)
				{
					Console.WriteLine(numero + " En la posicion "+posicionPares);
				}
				posicionPares++;
			}			
		}
	}
#endregion

#region Ejercicio 6
/*Crea un array de 10 elementos, visualiza el elemento mayor de la serie y la posición que
ocupa. Si hay varios iguales, sólo el primero.*/
class Program
	{
		static void Main()
		{
			int posicionPorLaQueVoy = 0;
			int valorMaximo = int.MinValue;
			int[] numerosAleatorios = new int[10];
			Random random = new Random();
			for (int i = 0; i < numerosAleatorios.Length; i++)
			{
				int numeroGenerado = random.Next(0, 50);
				numerosAleatorios[i] = numeroGenerado;
			}
			int posicionMayor = 0;
			foreach (int numero in numerosAleatorios) 
			{
				if (numero > valorMaximo)
				{
					valorMaximo = numero;
					posicionPorLaQueVoy = posicionMayor;
				}
				posicionMayor++;
			}

			Console.WriteLine(valorMaximo+" en la posicion "+posicionMayor);
		}
	}
#endregion

#region Ejercicio 7
/*Crea un array aleatorio de enteros con 10 elementos y llámalo V.
• Con los elementos pares crea un array P y tras ordenalo en sentido creciente y lo
visualizas.
• Con los elementos impares crea un array I y tras ordenalo en sentido decreciente y
lo visualizas.*/
	class Program
	{
		static string MuestraArraySinCeros(int[] array)
		{
			string mensaje = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != 0)
				{
					mensaje += array[i]+" "; 
				}
			}
			return mensaje;
		}
		static void Main()
		{
			int[] v = new int[10];
			int[] p = new int[10];
			int[] i = new int[10];
			Random random = new Random();

			for (int j = 0; j < v.Length; j++)
			{
				int numeroAleatorios = random.Next(1, 52);
				v[j] = numeroAleatorios;
			}

			// v = [2, 3, 5, 4];
			// p = []
			// i = []

			int iP = 0, iI = 0;
			for (int j = 0; j < p.Length; j++)
			{
				if (v[j] % 2 == 0)
					p[iP++] = v[j];
				else
					i[iI++] = v[j];
			}

			Array.Sort(p);
			Array.Sort(i);
			Array.Reverse(i);
			Console.WriteLine("Numeros pares: "+MuestraArraySinCeros(p));
			Console.WriteLine("Numeros impares: "+MuestraArraySinCeros(i));
		}
	}
#endregion

#region Ejercicio 8
/*Implementa un programa en C# que dada un número entero sin signo introducido por
teclado me diga si es capicúa. Un ejemplo de ejecución sería...*/
class Program
	{
		static void Main()
		{
			Console.Write("Introduce un numero: ");
			char[] numero = Console.ReadLine().ToCharArray();

			char[] numeroAlReves = new char[numero.Length];
			numero.CopyTo(numeroAlReves, 0);
			Array.Reverse(numeroAlReves);


			string numeroBueno = new string(numero);
			string numeroContrario = new string(numeroAlReves);

			if (numeroBueno == numeroContrario)
				Console.WriteLine("Es capicua");
			else
				Console.WriteLine("No es capicua");
		}
	}
#endregion

#region Ejercicio 9 
/*Crea un menú con tres opciones:
1. Introducir contraseña.
2. Pedir contraseña.
3. Salir del programa.
Si seleccionamos la primera opción aparecerá una ventana que te pida una contraseña
que tendrás que repetir para darla cómo válida.
Mientras que estás escribiendo la contraseña solamente se verán los caracteres *****
---------------------------------------
Entrada:
Contraseña: ****
Comprobar Contraseña: *****
---------------------------------------
Tras validarla, la contraseña se guardará en un array.
En la opción de Pedir contraseña, introducirás una cadena por teclado y se comprobará si
la cadena introducida es igual a la contraseña guardada en el array.*/
	class Program
	{
		static void EligeOpcion(int opcion, char[] contraseñaSinConfirmar, char[] contraseñaConfirmada, char[] contraseñaEscritaPorUsuario)
		{

			if (opcion == 1)
				IntroducirContraseña(contraseñaSinConfirmar, contraseñaConfirmada);
			else if (opcion == 2)
				PideContraseña(contraseñaConfirmada, contraseñaEscritaPorUsuario);
			else
				Console.WriteLine("\nSaliendo del programa...");
		}
		static void IntroducirContraseña(char[] ContraseñaSinConfirmar, char[] contraseñaConfirmada)
		{
			string mensajeError = "Las contraseñas no coinciden, vuelve a introducirlas";
			Console.WriteLine("---------------------------------");
			Console.WriteLine("Entrada");
			Console.WriteLine("---------------------------------");
			Console.Write("Introduce una contraseña: ");
			for (int i = 0; i < 10; i++)
			{
				char letra = Console.ReadKey(true).KeyChar;
				Console.Write('*');
				ContraseñaSinConfirmar[i] = letra;
			}
			Console.Write("\nVuelve a introducir la misma contraseña: ");
			for (int i = 0; i < ContraseñaSinConfirmar.Length; i++)
			{
				char letra = Console.ReadKey(true).KeyChar;
				Console.Write('*');
				contraseñaConfirmada[i] = letra;
			}
			string cotraseñaSinContrastar = new string(ContraseñaSinConfirmar);
			string contraseñaContrastada = new string(contraseñaConfirmada);

			if (cotraseñaSinContrastar != contraseñaContrastada)
			{
				Console.WriteLine("\n"+mensajeError);
				Console.ReadKey();
				Console.Clear();
				IntroducirContraseña(ContraseñaSinConfirmar, contraseñaConfirmada);
			}
		}
		static void PideContraseña(char[] ContraseñaConfirmada, char[] ContraseñaEscritaPorUsuario)
		{
			Console.WriteLine("---------------------------------");
			Console.WriteLine("Salida");
			Console.WriteLine("---------------------------------");
			Console.Write("Introduce la contraseña: ");
			for (int i = 0; i < ContraseñaConfirmada.Length; i++)
			{
				char contraseñaUsuario = Console.ReadKey(true).KeyChar;
				Console.Write('*');
				ContraseñaEscritaPorUsuario[i] = contraseñaUsuario;
			}
			string contraseñaBuena = new string(ContraseñaConfirmada);
			string contraseñaAContrastar = new string(ContraseñaEscritaPorUsuario);

			if (contraseñaBuena == contraseñaAContrastar)
				Console.WriteLine("\nLa contraseña es correcta");
			else
				Console.WriteLine("\nLa contraseña no es correcta");
		}
		static void Main()
		{
			char[] contraseñaSinConfirmar = new char[10];
			char[] contraseñaConfirmada = new char[contraseñaSinConfirmar.Length];
			char[] contraseñaEscritaPorUsuario = new char[10];
			for (int i = 0; i < 3; i++)
			{
				Console.Write("\n");
				Console.WriteLine("1. Introducir una contraseña");
				Console.WriteLine("2. Pedir contraseña");
				Console.WriteLine("3. Salir del programa");
				Console.WriteLine("\nQue opcion eliges?: ");
				int opcion = int.Parse(Console.ReadLine());
				EligeOpcion(opcion, contraseñaSinConfirmar, contraseñaConfirmada, contraseñaEscritaPorUsuario);
			}
		}
	}
#endregion