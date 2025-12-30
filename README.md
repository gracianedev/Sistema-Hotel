# Sistema de Hospedagem - Hotel (Desafio DIO)

Este projeto foi desenvolvido como parte do desafio da trilha **.NET - Explorando a Linguagem C#** da [Digital Innovation One (DIO)](https://www.dio.me/).

O objetivo inicial foi aplicar conceitos de Orientação a Objetos. O projeto foi expandido para incluir um **Menu Interativo via Console**, validação de dados robusta e armazenamento em memória utilizando Coleções.

## ⚙️ Funcionalidades do Sistema

O sistema conta com um menu interativo que permite:

- **1. Cadastrar Suíte:** - Permite definir Tipo, Capacidade e Valor da Diária.
  - Validação para impedir suítes com nomes duplicados.
- **2. Criar Nova Reserva:** - Cadastro dinâmico de hóspedes (Lista de Pessoas).
  - Vinculação de suítes cadastradas.
  - Cálculo automático de valores.
- **3. Consultar Reserva:** - Busca rápida de reserva pelo nome do hóspede.
  - Exibe detalhes completos (hóspedes, dias, valores).
- **4. Sair:** Encerra a aplicação.

## 🛡️ Destaques Técnicos

Além da Orientação a Objetos, foram implementados:

- **Input Validation:** Uso de `TryParse` e loops `do-while` para garantir que o usuário não insira letras em campos numéricos ou deixe campos obrigatórios vazios.
- **Collections:** Uso de `Dictionary<string, Suite>` e `Dictionary<string, Reserva>` para armazenamento e busca rápida de dados (chave-valor).
- **Tratamento de Exceções:** Prevenção de quebras abruptas do sistema (Try-Catch).
- **Interpolação de Strings:** Formatação clara de saídas no console.

## ✏️ Diagrama de classes
![Diagrama de Classes](docs/diagrama_classe_hotel.png)

## ⚖️ Regras de Negócio Implementadas

1. **Validação de Capacidade:** - O sistema verifica se a capacidade da suíte comporta o número de hóspedes inseridos.
   - Caso o número de hóspedes exceda a capacidade, o sistema alerta e impede a conclusão da reserva incorreta.
   
2. **Desconto na Diária:**
   - Reservas com **10 dias ou mais** recebem automaticamente um desconto de **10%** no valor total calculado pelo método `CalcularValorDiaria()`.

## 🛠️ Tecnologias Utilizadas

- **C#** (Lógica e POO)
- **.NET** (Plataforma)
- **Git/GitHub** (Versionamento)

## 🚀 Como Executar

1. Clone o repositório.
2. Navegue até a pasta do projeto pelo terminal.
3. Execute o comando:
   ```bash
   dotnet run
4. Interaja com o menu no terminal:
```bash
   >>> Escolha a opção desejada: <<<

   1 - Cadastrar Suíte 
   2 - Criar Nova Reserva 
   3 - Consultar Reserva 
   4 - Sair
```

## 👩‍💻 Desenvolvido por 

[**Graciane**](mailto:graciane.dev@gmail.com)


