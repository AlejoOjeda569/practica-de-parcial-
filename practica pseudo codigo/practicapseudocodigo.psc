Funcion respuesta <- valorvolumen ( radio,altura )
	definir respuesta Como Real;
	respuesta=(PI*radio^2*altura)/3;
Fin Funcion

Funcion respuesta <- valordelarea ( radio,generatriz )
	definir respuesta Como Real;
	respuesta=PI*radio*(radio+generatriz);
	
Fin Funcion

Algoritmo practicapseudocodigo
	Definir area , volumen Como Real; 
	definir generatriz , altura , radio Como Real;
	Escribir sin saltar " ingrese el valor de la generatriz: ";
	Leer generatriz;
	Si generatriz<= 0 Entonces
		Escribir " el valor de la generatris debe ser distinto de 0";
	Fin Si
	Escribir sin saltar "ingrese la altura del cono: ";
	Leer altura;
	si altura<= 0 Entonces
		Escribir " la altura debe ser mayor que 0 ";
	FinSi
	Escribir sin saltar " ingrrese el radio del cono:";
	Leer radio;
	si radio<= 0 Entonces
		Escribir " el radio debe ser distinto de 0";
	FinSi
	area=valordelarea(radio,generatriz);
	volumen=valorvolumen(radio,altura);
	Escribir " el cono tiene un area de:",area;
	Escribir  " el cono tiene un volumen de: ",volumen;
	
	
	
	
	
FinAlgoritmo
