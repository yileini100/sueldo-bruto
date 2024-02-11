// See https://aka.ms/new-console-template for more information
Console.WriteLine("calcular sueldo bruto");


Console.WriteLine("Ingrese el pago por hora:");
double pagoPorHora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese las horas trabajadas:");
double horasTrabajadas = Convert.ToDouble(Console.ReadLine());


double sueldoBruto = pagoPorHora * horasTrabajadas;


double afp = sueldoBruto * 0.0287;
double sfs = sueldoBruto * 0.0304;
double totalDescuentos = afp + sfs;
double sueldoNeto = sueldoBruto - totalDescuentos;


Console.WriteLine("Sueldo bruto: " + sueldoBruto);
Console.WriteLine("Descuento de AFP: " + afp);
Console.WriteLine("Descuento de SFS: " + sfs);
Console.WriteLine("Total descuentos: " + totalDescuentos);
Console.WriteLine("Sueldo neto: " + sueldoNeto);
