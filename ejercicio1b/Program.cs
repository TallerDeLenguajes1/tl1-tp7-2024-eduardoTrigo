using EspacioCalculadora; //importo el namespace para accedor a la clase Calculadora

int operacion;
double termino=0;
bool b;
Calculadora nuevaCalculadora = new Calculadora();//crea la instancia de clase Calculadora

do
{
    Console.WriteLine("Ingrese una Opcion: "); //Muestra el menu de opciones al usuario
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("6- Salir");

    b = int.TryParse(Console.ReadLine(),out operacion); // lee y valida la opcion ingresada por el usuario al mismo tiempo que lo parsea a entero.
    if (b && operacion > 0 && operacion < 7)
    {
        if (operacion < 5) // si la opcion esta entre 1 y 4 solicita un numero al usuario
        {
            do
            {
                Console.WriteLine("ingrese un numero");
                b = double.TryParse(Console.ReadLine(), out termino);// lee y valida la opcion ingresada por el usuario al mismo tiempo que lo parsea a entero.
                if (!b)
                {
                    Console.WriteLine("numero invalido");
                }
            } while (!b); // si el numero ingresado no es valido vuelve a solicitarlo hasta que ingrese un numero
        }

        //lee y realiza la operacion solicitada
        switch (operacion)
        {
            case 1: 
                nuevaCalculadora.Sumar(termino);
                Console.WriteLine(nuevaCalculadora.Resultado);

            break;

            case 2: 
                nuevaCalculadora.Restar(termino);
                Console.WriteLine(nuevaCalculadora.Resultado);

            break;

            case 3: 
                nuevaCalculadora.Multiplicar(termino);
                Console.WriteLine(nuevaCalculadora.Resultado);

            break;
            
            case 4: 
                if (termino != 0)
                {
                    nuevaCalculadora.Dividir(termino);
                    Console.WriteLine(nuevaCalculadora.Resultado);
                }else
                {
                    Console.WriteLine("operacion invalida");
                }

            break;

            case 5: 
                nuevaCalculadora.Limpiar();
                Console.WriteLine("Calculadora Reiniciada");

            break;

            default:
            break;
        }
    }else
    {
        Console.WriteLine("operacion Invalida");
    }
    
} while (operacion != 6);// repite hasta que el usuario ingrese salir
