// YouTube: https://youtu.be/UisnZCGsAKE
// Publicação: https://caffeinealgorithm.com/blog/20220422/operadores-de-atribuicao-em-go/

package main

import "fmt"

func main() {
	x := 2

	x += 3
	fmt.Println("x = x + 3:", x) // x = x + 3: 5

	x -= 2
	fmt.Println("x = x - 2:", x) // x = x - 2: 3

	x *= 2
	fmt.Println("x = x * 2:", x) // x = x * 2: 6

	x /= 2
	fmt.Println("x = x / 2:", x) // x = x / 2: 3

	x %= 3
	fmt.Println("x = x % 3:", x) // x = x % 3: 0
}
