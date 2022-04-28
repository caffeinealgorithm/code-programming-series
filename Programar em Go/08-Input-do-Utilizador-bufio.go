// YouTube: https://youtu.be/3HDVH40ZR2w
// Publicação: https://caffeinealgorithm.com/blog/20220428/input-do-utilizador-bufio-em-go/

package main

import (
	"fmt"
	"bufio"
	"os"
	"strings"
)

func main() {
	inputDoUtilizador := bufio.NewReader(os.Stdin)

	fmt.Print("Insere o teu primeiro nome: ")
	primeiroNome, _ := inputDoUtilizador.ReadString('\n')

	fmt.Print("Insere o teu último nome: ")
	ultimoNome, _ := inputDoUtilizador.ReadString('\n')

	fmt.Print("Insere a tua idade: ")
	idade, _ := inputDoUtilizador.ReadString('\n')

	/*
		CR+LF -> \r\n
		CR -> \r
		LF -> \n
	*/

	fmt.Printf("Nome: %s %s\nIdade: %s",
						 strings.ReplaceAll(primeiroNome, "\r\n", ""),
						 strings.ReplaceAll(ultimoNome, "\r\n", ""),
						 strings.ReplaceAll(idade, "\r\n", ""))
}
