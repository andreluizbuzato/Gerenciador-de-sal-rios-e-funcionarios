# 💼 Sistema de Cadastro de Funcionários em C#

## 📘 Descrição
Este projeto foi desenvolvido em **C#** e tem como objetivo demonstrar o uso dos **principais conceitos de Programação Orientada a Objetos (POO)**, como **herança, abstração e polimorfismo**, aplicados em um sistema simples de **cadastro e cálculo de salários** de funcionários de diferentes categorias.

O programa permite cadastrar múltiplos funcionários (Administrativo, Técnico e Estagiário), calcular automaticamente seus salários finais conforme regras específicas e gerar um relatório completo no console.

---

## ⚙️ Funcionalidades
- Cadastro de funcionários de diferentes tipos:
  - **Administrativo** → salário base + 10% de bônus.  
  - **Técnico** → salário base + 20% de adicional técnico.  
  - **Estagiário** → metade do salário base.
- Armazenamento de todos os funcionários em uma lista genérica (`List<Funcionario>`).
- Exibição de relatório final com:
  - Nome  
  - Tipo de funcionário  
  - Salário base  
  - Salário final calculado automaticamente.
- Execução totalmente interativa pelo console.

---

## 🧩 Estrutura do Código

### Classe Abstrata `Funcionario`
- **Propriedades:** `Nome`, `SalarioBase`
- **Métodos:**
  - `CalcularSalario()` → método abstrato (implementado nas classes filhas).
  - `ExibirDados()` → exibe as informações básicas e o salário final no console.

### Classes Derivadas
- `Administrativo` → herda de `Funcionario` e adiciona 10% de bônus.  
- `Tecnico` → herda de `Funcionario` e adiciona 20% de adicional técnico.  
- `Estagiario` → herda de `Funcionario` e calcula metade do salário base.

### Classe Principal `Program`
- Responsável por:
  - Interagir com o usuário via console.
  - Cadastrar funcionários dinamicamente.
  - Gerar e exibir o relatório final com todos os dados cadastrados.

---

## 🧠 Conceitos Aplicados
- **Classe e Objeto**
- **Herança**
- **Abstração**
- **Polimorfismo**
- **Listas e Coleções Genéricas**
- **Entrada e Saída de Dados no Console**

---

## 💻 Como Executar o Projeto

1. Abra o **Visual Studio 2022**.
2. Crie um novo projeto do tipo **"Aplicativo de Console (.NET)"**.
3. Substitua o conteúdo do arquivo `Program.cs` pelo código fornecido.
4. Compile e execute pressionando `Ctrl + F5`.
5. Siga as instruções exibidas no console:
   - Escolha o tipo de funcionário (1, 2 ou 3);
   - Informe o nome e o salário base;
   - Repita o processo conforme desejar.
6. Após finalizar os cadastros, será exibido o relatório completo no console.

---

## 📋 Exemplo de Saída

