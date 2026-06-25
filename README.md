🌐 [English](README.en.md) | [Español](README.es.md)

# 💰 Gerenciamento Financeiro

![.NET Framework 4.7.2](https://img.shields.io/badge/.NET%20Framework-4.7.2-purple)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-blue)
![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework-orange)
![License MIT](https://img.shields.io/badge/License-MIT-green)

> Controle financeiro pessoal com registro de entradas/saídas e histórico de transações — Windows Forms com arquitetura DDD.

## ✨ Features

- 📥 Registro de entradas (receitas)
- 📤 Registro de saídas (despesas)
- 📊 Histórico de transações com filtros
- 🔍 Consulta e acompanhamento do saldo
- 🌐 Interface disponível em Português, Inglês e Espanhol

## 🛠️ Tech Stack

| Camada | Tecnologia |
|--------|-----------|
| Linguagem | C# |
| Framework | .NET Framework 4.7.2 |
| Interface | Windows Forms |
| ORM | Entity Framework |
| Arquitetura | Domain-Driven Design (DDD) |

## 🚀 Como Rodar (Visual Studio)

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/GerenciamentoFinanceiro.git
   ```

2. Abra a solution `.sln` no **Visual Studio 2019+**

3. Restaure os pacotes NuGet:
   - Clique com botão direito na Solution → **Restore NuGet Packages**

4. Atualize o banco de dados (Package Manager Console):
   ```powershell
   Update-Database
   ```

5. Pressione **F5** para executar

## 🏗️ Arquitetura

Projeto organizado em camadas seguindo DDD:

```
GerenciamentoFinanceiro/
├── Application/    → Casos de uso e orquestração
├── Domain/         → Entidades e regras de negócio
├── Service/        → Serviços de domínio
├── Persistence/    → Acesso a dados (EF, repositórios)
└── Ioc/            → Injeção de dependências
```

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).

## 👤 Autor

Desenvolvido por **[Seu Nome]** — [LinkedIn](https://linkedin.com/in/seu-perfil)
