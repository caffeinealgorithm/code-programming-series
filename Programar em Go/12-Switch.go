// YouTube: https://youtu.be/-MckZGlZX1A
// Publicação: https://caffeinealgorithm.com/blog/20220504/switch-em-go/

package main

import "fmt"

func main() {
	caso := "D"

	switch (caso) {
		case "A":
			fmt.Println("O caso A existe.")
		case "B":
			fmt.Println("O caso B existe.")
		case "C":
			fmt.Println("O caso C existe.")
		default:
			fmt.Printf("O caso %s não existe.", caso)
	}
}

// O caso D não existe.
