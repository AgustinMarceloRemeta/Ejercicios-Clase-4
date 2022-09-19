# Ejercicios-Clase-4
 Ejercicios: 
 
 1) Spawnear arma en la escena:
Hay 5 prefabs de armas en la carpeta Resources/Armas (espada, lanza, arco, hacha, daga)
Se sabe que nuevas armas serán agregadas a la carpeta a futuro
El usuario escribe el arma que quiere spawnear en un Input en la escena
Al clickear un Button en la escena se buscará ese arma
De encontrarse dentro de la carpeta Resources deberá spawnearse (en su defecto spawnear la espada)
2) Recargar revolver: 
Tenemos un revólver con 6 tiros en total
El tambor del revólver está completamente cargado al inicio de la escena
Hacer click izquierdo dispara una de las balas (simplemente mostrar por consola algo que indique que el disparo fue efectuado)
Al disparar la última bala el revólver deberá comenzar a recargarse
La recarga ocurre bala a bala con un período de espera de 1 segundo antes de la recarga de cada bala (mostrar por consola cada vez que se recargue una bala)
El jugador puede presionar el botón R para recargar el revólver en cualquier momento (el método de recarga no se debería llamar si las 6 balas están en el tambor)
Extra: El jugador puede disparar mientras el proceso de recarga se está llevando a cabo, pero interrumpirá el mismo (si es que el revólver tiene al menos una bala en el tambor)
3) Añadir bonificador:
Construir un método que lance un dado de 20 caras y muestre el resultado por consola
Tener un Toggle para aumentar el resultado obtenido del dado en 5 si está activado
Al activarlo también se deben modificar dos objetos Text distintos:
Uno debe mostrar el nombre del modificador activado (por ejemplo: “Flanking mod”)
El otro debe mostrar el total del bono obtenido por el modificador
Extra: Utilizar eventos para comunicar la lógica y lograr un mejor desacoplamiento de la lógica
Extra: Tener 2 Toggles más que funcionen de la misma manera y que los textos cambien:
Uno debe mostrar todos los nombres de los modificadores activados
El otro debe mostrar el total de todos los modificadores activados
