# TesteTarget

A resolução dos testes de código está na pasta TesteTarget, códigos foram solucionados em C# e Java, mas escolhi para este repositório que fosse em C#.

> A solução para os outros exercícios será colocada abaixo:

3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA)

Fiz o código para este exercício também, o valor total da soma é: 77.

4) Descubra a lógica e complete o próximo elemento:
a) 1, 3, 5, 7, ___
b) 2, 4, 8, 16, 32, 64, ____
c) 0, 1, 4, 9, 16, 25, 36, ____
d) 4, 16, 36, 64, ____
e) 1, 1, 2, 3, 5, 8, ____
f) 2,10, 12, 16, 17, 18, 19, ____


Respostas:
A) 9   ||
   B) 128   ||
   C) 49   ||
   D) 100   ||
   E) 13   ||
   F) 20 

5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

Eu iria nomear os interruptores e as lâmpadas, por exemplo interruptor 1, 2 e 3.
Ligaria um dos interruptores e deixaria um tempo ligado para a lâmpada poder aquecer, depois desligaria e deixaria um outro interruptor aceso sem desligar e iria visitar as salas.
A lâmpada que estivesse quente e apagada seria do interruptor que deixei ligado por um tempo, a lâmpada acesa seria do interruptor que deixei ligado e a lâmpada apagada e fria seria do interruptor que não liguei.
Desta forma eu poderia descobrir qual controla cada lâmpada facilmente.
