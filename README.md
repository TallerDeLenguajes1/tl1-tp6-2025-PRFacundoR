[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
¿string es un tipo por valor o por referencia?
string es un tipo por referencia, ya que deriva de la clase System.String.
Sin embargo, se comporta como inmutable: cada vez que se modifica, se crea un nuevo objeto en memoria.

Secuencias de escape comunes en string
Secuencia	Significado
\n	Nueva línea
\r	Retorno de carro
\t	Tabulación
\\	Barra invertida (\)
\"	Comilla doble
\'	Comilla simple
\0	Null (\0)
\a	Alerta sonora (beep)

Uso de @ y $ en cadenas

@ - Verbatim string literal
Permite:

Escribir texto en varias líneas.

Evitar escapes de caracteres (excepto "" para comillas dobles).

$ - Interpolated string
Permite insertar variables dentro de la cadena con {}.


¿Qué son y cómo funcionan las expresiones regulares?
Las expresiones regulares (también llamadas regex, por regular expressions) son patrones utilizados para buscar, validar, extraer o reemplazar texto dentro de cadenas. Funcionan describiendo con símbolos especiales una "forma" o estructura de texto, como por ejemplo un correo electrónico, una fecha, o una matrícula.

El motor de expresiones regulares interpreta el patrón y analiza una cadena carácter por carácter para determinar si se cumple o no la forma definida.

¿Funcionan únicamente en C#?
No, las expresiones regulares son una herramienta universal, no exclusiva de C#. Se utilizan en muchísimos lenguajes y entornos, incluyendo:

Python (re)

Java (java.util.regex)

JavaScript (RegExp)

PHP (preg_match)

Bash/Shell (grep, sed, awk)

y editores de texto como VS Code, Notepad++, etc.

El sintaxis base es similar en todos, aunque puede haber pequeñas diferencias entre motores.

EJEMPLOS

Validar datos: asegurarse de que un texto cumple un formato, por ejemplo:

Correos electrónicos (^[^@\s]+@[^@\s]+\.[^@\s]+$)

Contraseñas con al menos 1 número, 1 mayúscula y 8 caracteres

Números de teléfono


Extraer información de un texto:

Encontrar todas las fechas en un documento

Extraer URLs de una página HTML

Obtener los números de un texto mezclado


Buscar y reemplazar patrones complejos:

Cambiar todos los formatos de fecha de dd-mm-yyyy a yyyy/mm/dd

Reemplazar múltiples espacios por uno solo

Eliminar etiquetas HTML