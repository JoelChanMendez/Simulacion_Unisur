import random

def tirar_dado():
    
    resultado = random.randint(1, 6)
    return resultado


resultado_dado = tirar_dado()
print(f"El resultado del lanzamiento del dado es: {resultado_dado}")
