[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

# ¿String es una tipo por valor o un tipo por referencia?

String es un tipo por referencia, que pese a ello, tambien incluye operadores de igualdad para comparar sus valores, más no sus referencias.

# ¿Qué secuencias de escape tiene el tipo string?

| Codigo de Escape |      Caracter Representado       |
| :--------------: | :------------------------------: |
|       `\'`       |          Comilla Simple          |
|       `\"`       |         Comillas Dobles          |
|       `\\`       |         Barra invertida          |
|       `\0`       |          Caracter Nulo           |
|       `\b`       |            Retroceso             |
|       `\n`       |          Salto de Linea          |
|       `\r`       |         Retorno de carro         |
|       `\t`       |      Inserta una tabulacion      |
|      `\xHH`      |       Caracter Hexadecimal       |
|     `\uHHHH`     |         Caracter Unicode         |
|   `\UHHHHHHHH`   | Caracter Unicode (suplementario) |

# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Al de utilizar `@` actua como un identificador textual, indicando asi que un literal de cadena se debe interpretar literalmente. Por otro lado `$` indentifica un literal de cadena como una cadena interpolada, estos son literales de cadenas que pueden contener expresiones de interpolacion, cuando una cadena interpolada se resuelve en una cade de resultado, el compilador reemplaza los elementos con expresiones de interpolación por las representaciones de cadena de los resultados de la expresión.


