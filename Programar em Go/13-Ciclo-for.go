// YouTube: https://youtu.be/w7hXnuh5G2E
// Publicação: https://caffeinealgorithm.com/blog/20220505/for-loop-in-go/

package main

import "fmt"

func main() {
	// materialEscolar := [...]string { "Mochila", "Estojo", "Lápis", "Borracha", "Afia", "Tesoura" }

	/*
    fmt.Println(materialEscolar[0]);
	  fmt.Println(materialEscolar[1]);

    for indice := 0; indice < len(materialEscolar); indice++ {
		  fmt.Printf("materialEscolar[%d]: %s\n", indice, materialEscolar[indice])

	  for indice, material := range materialEscolar {
		  fmt.Printf("materialEscolar[%d]: %s\n", indice, material)
	  }
  */

	numero := 1

	for (numero <= 10) {
		fmt.Printf("Número: %d\n", numero)
		numero++
	}
}

/*
  Número: 1
  Número: 2
  Número: 3
  Número: 4
  Número: 5
  Número: 6
  Número: 7
  Número: 8
  Número: 9
  Número: 10
/*
