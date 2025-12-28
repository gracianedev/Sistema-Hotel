# Sistema de Hospedagem - Hotel (Desafio DIO)

Este projeto foi desenvolvido como parte do desafio da trilha **.NET - Explorando a Linguagem C#** da [Digital Innovation One (DIO)](https://www.dio.me/).

O objetivo foi aplicar conceitos de Orientação a Objetos para construir um sistema que gerencia reservas de hóspedes em suítes de hotel.

## ⚙️ Funcionalidades

- **Cadastro de Hóspedes:** Criação de objetos do tipo `Pessoa`.
- **Cadastro de Suítes:** Definição de suítes com tipo, capacidade e valor da diária.
- **Realização de Reservas:** Lógica para associar hóspedes a uma suíte.
- **Cálculo de Diária:** Método automático que calcula o valor total.
#
## ✏️ Diagrama de classes
![Diagrama de Classes](docs/diagrama_classe_hotel.png)
#
## ⚖️ Regras de Negócio Implementadas

1. **Validação de Capacidade:** - O sistema verifica se a capacidade da suíte comporta o número de hóspedes.
   - Caso o número de hóspedes exceda a capacidade, uma exceção é lançada.
   
2. **Desconto na Diária:**
   - Reservas com **10 dias ou mais** recebem automaticamente um desconto de **10%** no valor total.

## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET**

## 🚀 Como Executar

1. Clone o repositório.
2. Navegue até a pasta do projeto pelo terminal.
3. Execute o comando:
   ```bash
   dotnet run