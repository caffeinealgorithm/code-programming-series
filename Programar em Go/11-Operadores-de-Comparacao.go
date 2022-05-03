// YouTube: https://youtu.be/dvCuGh0SGv8
// Publicação: https://caffeinealgorithm.com/blog/20220503/operadores-de-comparacao-em-go/

package main

import "fmt"

func main() {
	x := 10
	y := 20

	if (x <= y || x == y) {
		fmt.Println("Esta condição é verdadeira.")
	} else {
		fmt.Println("Esta condição é falsa.")
	}
}

// Esta condição é verdadeira.
