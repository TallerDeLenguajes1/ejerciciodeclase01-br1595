Problema 1:
	El error encontrado en el momento de ejecución es el problema generado al intentar tratar de leer el valor que posee una lista que se encuentra fuera de su tamaño. Excepcion: "System.IndexOutOfRangeException"

Problema 2:
	Nos cruzamos con un problema de overflow, es decir el valor es muy grande para, en este caso, un byte no signado. Excepcion: "System.OverflowException"

Problema 3:
	Problema surgido por el envio incorrecto de datos en una función y por consiguiente al crear un objeto en esa función obtenemos un objeto con valor "Null". Excepcion: "NullReferenceException"

Problema 4:
	Error generado debido a que el indice debe ser menor que la cantidad de argumentos pasados a ser mostrados. Exception: "System.FormatException"