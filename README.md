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