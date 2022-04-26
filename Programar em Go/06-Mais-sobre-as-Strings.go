// YouTube: https://youtu.be/4xldTbYwVcM
// Publicação: https://caffeinealgorithm.com/blog/20220426/mais-sobre-as-strings-em-go/

package main

import (
	"fmt"
	"strings"
)

func main() {
	primeiroNome, ultimoNome := "Nelson", "Silva"
	idade := 25

	fmt.Println("Nome:", strings.ToUpper(primeiroNome), strings.ToLower(ultimoNome), "\nIdade:", idade)

	fmt.Printf("Nome: %s %s\nIdade: %d", primeiroNome, ultimoNome, idade)

  /*
    Nome: NELSON silva
    Idade: 25
    Nome: Nelson Silva
    Idade: 25
  */
}
