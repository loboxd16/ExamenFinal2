using ExamenCorrecto;
using System.ComponentModel;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Gerente gerente = new Gerente
{

    
    IdEmpleado = 1,
    Nombre = "Hugo Torrico",
    Puesto = "Gerente Desarrollo"
};

Desarollador desarollador = new Desarollador
{
    IdEmpleado = 2,
    Nombre = "José Cárdenas",
    Puesto = "Desarrollador Senior",
};

GerenteRRHH recursos = new GerenteRRHH
{
    IdEmpleado = 3,
    Nombre = "pancho chicote",
    Puesto = "Recursos Inhumanos"
};
ConsultorExterno externo = new ConsultorExterno
{
    IdEmpleado= 4,
    Nombre="Walther With",
    Puesto="Consultor Externo"
};





empleados.Add(gerente);
empleados.Add(desarollador);
empleados.Add(recursos);
empleados.Add(externo);

foreach (var empleado in empleados)
{
    empleado.CalcularSueldo();
    empleado.MostrarDetalle();

    if (empleado is ISueldoBonificable empleadoBonificable)
    {
        empleadoBonificable.CalcularBonificacion();
    }
    if (empleado is IDescuentoImpuesto empleadoDescuento)
    {
        empleadoDescuento.DescontarSueldo();
    }

}

int opcion;

 void ingreso() { 
{

    Console.WriteLine("Ingrese numero de consulta");
    Console.WriteLine("numero 1. Agregar gerente");
    Console.WriteLine("numero 2. Agregar  gerente recursos humanos");
    Console.WriteLine("numero 3. Agregar  desarrollador");
    Console.WriteLine("numero 4. Agregar  consultor externo");
        Console.WriteLine("numero 5. Mostrar datos de empleados");
        Console.WriteLine("numero 6. Salir");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:

                List<EmpleadoBase> empleados3 = new List<EmpleadoBase>();

                Gerente gerente1 = new Gerente();

                Console.WriteLine($"Ingrese nombre de gerente ");
                gerente1.Nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese ID de empleado ");
                gerente1.IdEmpleado = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese  puesto de empleado");
                gerente1.Puesto = Console.ReadLine();
            Console.WriteLine("datos agregados exitosamente");

             
                    empleados3.Add(gerente1);

                    foreach (var geren in empleados3)
                    {
                        geren.CalcularSueldo();
                        geren.MostrarDetalle();

                        if (geren is ISueldoBonificable empleadoBonificable)
                        {
                            empleadoBonificable.CalcularBonificacion();
                        }
                        if (geren is IDescuentoImpuesto empleadoDescuento)
                        {
                            empleadoDescuento.DescontarSueldo();
                        }
                    }

                
               

                break;
                

            case 2:

                List<EmpleadoBase> empleados2 = new List<EmpleadoBase>();
                GerenteRRHH recursos1 = new GerenteRRHH();

        Console.WriteLine($"Ingrese nombre de gerente ");
                recursos1.Nombre = Console.ReadLine();
        Console.WriteLine($"Ingrese ID de empleado ");
                recursos1.IdEmpleado = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese  puesto de empleado");
                recursos1.Puesto = Console.ReadLine();
        Console.WriteLine("datos agregados exitosamente");

                
                    empleados2.Add(recursos1);

                    foreach (var recu in empleados2)
                    {
                        recu.CalcularSueldo();
                        recu.MostrarDetalle();

                        if (recu is ISueldoBonificable empleadoBonificable)
                        {
                            empleadoBonificable.CalcularBonificacion();
                        }
                        if (recu is IDescuentoImpuesto empleadoDescuento)
                        {
                            empleadoDescuento.DescontarSueldo();
                        }
                    }

              

                break;

    
    case 3:

                List<EmpleadoBase> empleados4 = new List<EmpleadoBase>();
                Desarollador desarrollador1 = new Desarollador();

        Console.WriteLine($"Ingrese nombre de gerente ");
                desarrollador1.Nombre = Console.ReadLine();
        Console.WriteLine($"Ingrese ID de empleado ");
                desarrollador1.IdEmpleado = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese  puesto de empleado");
                desarrollador1.Puesto = Console.ReadLine();
        Console.WriteLine("datos agregados exitosamente");

               
                    empleados4.Add(desarrollador1);

                    foreach (var desarrolla in empleados4)
                    {
                        desarrolla.CalcularSueldo();
                        desarrolla.MostrarDetalle();

                        if (desarrolla is ISueldoBonificable empleadoBonificable)
                        {
                            empleadoBonificable.CalcularBonificacion();
                        }
                        if (desarrolla is IDescuentoImpuesto empleadoDescuento)
                        {
                            empleadoDescuento.DescontarSueldo();
                        }
                    }

               

                break;

    

    case 4:

                List<EmpleadoBase> empleados8 = new List<EmpleadoBase>();

                ConsultorExterno consultor1 = new ConsultorExterno();

        Console.WriteLine($"Ingrese nombre de gerente ");
                consultor1.Nombre = Console.ReadLine();
        Console.WriteLine($"Ingrese ID de empleado ");
                consultor1.IdEmpleado = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese  puesto de empleado");
                consultor1.Puesto = Console.ReadLine();
        Console.WriteLine("datos agregados exitosamente");

               
               
                    empleados8.Add( consultor1 );

                   foreach( var consulta in empleados8)
                    {
                        consulta.CalcularSueldo();
                        consulta.MostrarDetalle();

                        if (consulta is ISueldoBonificable empleadoBonificable)
                        {
                            empleadoBonificable.CalcularBonificacion();
                        }
                        if (consulta is IDescuentoImpuesto empleadoDescuento)
                        {
                            empleadoDescuento.DescontarSueldo();
                        }
                    }
                    
               



        break;
            case 5:
                

                break;
            



        default :

            Console.WriteLine("Numero de opcion erroneo");
            return;

    }

} while (opcion != 0);

}



    string opcion1;
do {

    Console.WriteLine("Ingrese numero de consulta");
    Console.WriteLine("numero A. Agregar empleados");
    Console.WriteLine("numero B. Mostrar datos de empleados");
    Console.WriteLine("numero C. Salir");

    opcion1 = Console.ReadLine().ToUpper();

    switch (opcion1)
    {
        case "A":

            ingreso();
            

            break;


            case "B":

            ingreso();

            break;
           
         

            default:
            Console.WriteLine("Letra eqivocada");
            return;
    }
    
       




} while (opcion1!="S") ;


Console.Read();