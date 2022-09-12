// YouTube: https://youtu.be/PrK3pN6geso
// Publicação: https://caffeinealgorithm.com/blog/arrays-em-go/

package main

import "fmt"

func main() {
	var cores [5]string

	cores[0] = "Azul"
	cores[1] = "Verde"
	cores[2] = "Amarelo"
	cores[3] = "Vermelho"
	cores[4] = "Laranja"

	cores = [...]string { "Branco", "Verde", "Amarelo", "Vermelho", "Laranja" }

	fmt.Printf("Número de cores: %d\n", len(cores)) // Número de cores: 5
	fmt.Printf("Primeira cor: %s\n", cores[0]) // Primeira cor: Azul
	fmt.Printf("Última cor: %s", cores[len(cores) - 1]) // Última cor: Laranja
}
