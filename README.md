# FactoryMethod
Patrón Factory Method, patrón creacional

El objetivo es utilizar una clase para crear objetos mediante su contructor y un valor que identifica el tipo de objeto a crear.
Pasos:
1. Crear clase abstracta.
2. Heredar de la clase abstracta en 1 o más clases e implementar métodos.
3. Crear una clase que tenga un método static y retorna del tipo de la clase abstracta.
4. Llamar a la clase.MetodoCreador(tipo) y devuelve sobre el tipo del punto 1.

Encapsula su tipo dervado, porque siempre será de la clase del punto 1 y nunca se sabrá que son de alguna clase creadas en el punto 2.
