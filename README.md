# Challenge-Codility
Challenge Codility

CONSIGNA:

EJERCICIO 2

"Se te proporciona un registro de los precios históricos de un activo de inversión de los últimos N días. 
Analiza el registro para calcular cuál habría sido tu ganancia máxima. Asume que comenzaste con una unidad de este activo y solo podías tener una a la vez. Podías elegir vender el activo en cualquier momento, y si no tenías un activo en ese momento, siempre podías comprar uno (asume que tenías dinero infinito disponible).

¿Cuál es la ganancia máxima que podrías haber obtenido?
Escribe una función que, dado un arreglo A de longitud N que representa un registro de precios durante los últimos N días, retorne la ganancia máxima que podrías obtener. Como el resultado puede ser muy grande, retorna solo los últimos 
nueve dígitos sin ceros a la izquierda (retorna el resultado módulo 1,000,000,000).

Ejemplos:
Dado A = [4, 1, 2, 3], la función debería retornar 6. Podrías vender el producto en el primer día (por 4) y comprarlo en el segundo (por 1) y venderlo nuevamente en el último día (por 3). La ganancia sería igual a 4 + 3 - 1 = 6.
Dado A = [1, 2, 3, 3, 2, 1, 5], la función debería retornar 7. Podrías vender el producto cuando su valor era 3, comprarlo cuando cambió a 1, y venderlo nuevamente cuando valía 5.
Dado A = [1000000000, 1, 2, 2, 100000000, 1, 1000000000], la función debería retornar 999999998. La ganancia máxima posible es 2999999998, cuyos últimos 9 dígitos son 999999998.

Escribe un algoritmo eficiente considerando las siguientes suposiciones:
    N es un entero entre 1 y 2,000,000.
    Cada elemento del arreglo A es un entero entre 1 y 1,000,000."
