// YouTube: https://youtu.be/B8Lg8TbighI
// Publicação: https://caffeinealgorithm.com/blog/20220502/if-else-if-and-else-em-go/

package main

import "fmt"

/*
  (if - se) condição for verdadeira {
    o código dentro do if é executado
  }
  (else if - senão se) condição for verdadeira (só ocorre o else if caso a condição de if seja falsa) {
    o código dentro do else if é executado
  }
  (else - senão) sem condição (só ocorre caso a condição de if e de else if sejam falsas) {
    o código dentro do else é executado
  }
*/

func main() {
	x := 30

	if x == 10 {
		fmt.Println("O valor de x é igual a 10.")
	} else if x == 20 {
		fmt.Println("O valor de x é igual a 20.")
	} else {
		fmt.Println("O valor de x é diferente de 10 e de 20.")
	}
}

// O valor de x é diferente de 10 e de 20.
