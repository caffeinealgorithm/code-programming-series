// YouTube: https://youtu.be/DrlftMQf8jw
// Publicação: https://caffeinealgorithm.com/blog/20220421/variaveis-em-go/

package main

import "fmt"

func main() {
	var inteiro int = 10
	var _string string = "Eu sou uma string."
	var semTipo = "Eu continuo a ser uma string."

	decimal := 10.5
	booleano := true

	fmt.Println("inteiro:", inteiro) // inteiro: 10
	fmt.Println("string:", _string) // string: Eu sou uma string.
	fmt.Println("sem tipo:", semTipo) // sem tipo: Eu continuo a ser uma string.
	fmt.Println("decimal:", decimal) // decimal: 10.5
	fmt.Println("booleano:", booleano) // booleano: true
}
