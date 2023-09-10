import random

def tirar_dado():
    # Genera un número aleatorio entre 1 y 6 (como un dado de seis caras)
    resultado = random.randint(1, 6)
    return resultado

# Lanza el dado y muestra el resultado
resultado_dado = tirar_dado()
print(f"El resultado del lanzamiento del dado es: {resultado_dado}")
