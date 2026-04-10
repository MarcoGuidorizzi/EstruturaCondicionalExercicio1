# Exercício 01 — Calculadora de Nota Final (Condicional e Repetição)

Este programa calcula a nota final de um aluno com base nos resultados de dois semestres e determina o status de aprovação. O projeto foi expandido para oferecer uma experiência de uso contínua e suporte a padrões internacionais.

## O Desafio Original
O enunciado solicitava um programa básico para:
* Ler duas notas do aluno.
* Mostrar a nota final formatada com uma casa decimal.
* Exibir a mensagem **"REPROVADO"** caso a nota final fosse inferior a **60.0**.

## Diferenciais Implementados (Plus)
Para demonstrar domínio técnico além do básico, foram adicionadas as seguintes funcionalidades:
* **Estrutura de Repetição (`while`):** O programa utiliza um laço infinito que permite validar vários alunos em sequência sem precisar reiniciar a aplicação.
* **Feedback de Sucesso:** Implementação da lógica para exibir explicitamente **"APROVADO!"** quando a meta de 60.0 é atingida ou superada.
* **Globalização (`InvariantCulture`):** Configuração para garantir que o programa aceite o ponto (`.`) como separador decimal, evitando erros em diferentes sistemas operacionais.

## Conceitos Aplicados
* **Estrutura Condicional:** `if-else` para validação de regras de negócio.
* **Estrutura de Repetição:** Controle de fluxo contínuo.
* **Tipagem e Conversão:** Manipulação de tipos `double` e `Parse`.
* **Formatação de Dados:** Uso de `ToString("F1")` para padronização de casas decimais.

## Entrada e Saída

### Entrada
| Variável | Tipo | Descrição |
| :--- | :--- | :--- |
| `nota1` | `double` | Nota do primeiro semestre |
| `nota2` | `double` | Nota do segundo semestre |

### Saída
| Variável | Descrição | Regra |
| :--- | :--- | :--- |
| `soma` | Nota Final | Soma de `nota1` + `nota2` |
| **Status** | Resultado | "APROVADO!" (>= 60.0) ou "REPROVADO!" (< 60.0) |

## Tecnologias
* **Linguagem:** C#
* **Plataforma:** .NET 10
* **Versionamento:** Git

## Como Executar
```bash
# Clone o repositório
git clone [https://github.com/MarcoGuidorizzi/Est.CondicionalEx1.git](https://github.com/MarcoGuidorizzi/Est.CondicionalEx1.git)

# Acesse a pasta do exercício
cd Est.CondicionalEx1

# Execute o projeto
dotnet run
