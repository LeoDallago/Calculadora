# Calculadora C#

#### Este projeto feito totalmente na linguegem C# faz parte do conteudo pratico da *Academia do programador* 2024.

## Funcionalidades

- **Operacoes basicas**: Realiza somas, subtracoes,multiplicacoes e divisoes com facilidade.
- **Suporte a Decimais**: Trabalhe com numeros que tem duas casas decimais
- **Validacao de entrada**: A calculadora garante que apenas opcoes validas sejam aceitas. 
- **Tratamento de divisao por zero**: A calculadora inpede a divisao por zero

____

## Como usar

1. Clone o repositorio ou baixe o codigo compactado
2. Abra o pronpt de comando ate a pasta raiz da calculadora
3. Utilize o comando abaixo para restaurar as dependências do projeto.

~~~
dotnet restore
~~~

4.Em seguida, compile utilizando o comando:

~~~
dotnet build --configuration Release
~~~

5.Para executar o projeto compilando em tempo real
~~~
dotnet run --project Calculadora.ConsoleApp
~~~

6. Para executar o arquivo compilado, navegue até a pasta ./Calculadora.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:

~~~
Calculdora.ConsoleApp.exe
~~~

----

## Requisitos

- .NET SDK (recomendado .NET 5.0 ou superior) para compilação e execução do projeto.