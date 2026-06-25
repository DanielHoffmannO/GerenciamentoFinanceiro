ðŸŒ [English](README.en.md) | [EspaÃ±ol](README.es.md)

# ðŸ’° Gerenciamento Financeiro

![.NET Framework 4.7.2](https://img.shields.io/badge/.NET%20Framework-4.7.2-purple)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-blue)
![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework-orange)
![License MIT](https://img.shields.io/badge/License-MIT-green)

> Controle financeiro pessoal com registro de entradas/saÃ­das e histÃ³rico de transaÃ§Ãµes â€” Windows Forms com arquitetura DDD.

## âœ¨ Features

- ðŸ“¥ Registro de entradas (receitas)
- ðŸ“¤ Registro de saÃ­das (despesas)
- ðŸ“Š HistÃ³rico de transaÃ§Ãµes com filtros
- ðŸ” Consulta e acompanhamento do saldo
- ðŸŒ Interface disponÃ­vel em PortuguÃªs, InglÃªs e Espanhol

## ðŸ› ï¸ Tech Stack

| Camada | Tecnologia |
|--------|-----------|
| Linguagem | C# |
| Framework | .NET Framework 4.7.2 |
| Interface | Windows Forms |
| ORM | Entity Framework |
| Arquitetura | Domain-Driven Design (DDD) |

## ðŸš€ Como Rodar (Visual Studio)

1. Clone o repositÃ³rio:
   ```bash
   git clone https://github.com/seu-usuario/GerenciamentoFinanceiro.git
   ```

2. Abra a solution `.sln` no **Visual Studio 2019+**

3. Restaure os pacotes NuGet:
   - Clique com botÃ£o direito na Solution â†’ **Restore NuGet Packages**

4. Atualize o banco de dados (Package Manager Console):
   ```powershell
   Update-Database
   ```

5. Pressione **F5** para executar

## ðŸ—ï¸ Arquitetura

Projeto organizado em camadas seguindo DDD:

```
GerenciamentoFinanceiro/
â”œâ”€â”€ Application/    â†’ Casos de uso e orquestraÃ§Ã£o
â”œâ”€â”€ Domain/         â†’ Entidades e regras de negÃ³cio
â”œâ”€â”€ Service/        â†’ ServiÃ§os de domÃ­nio
â”œâ”€â”€ Persistence/    â†’ Acesso a dados (EF, repositÃ³rios)
â””â”€â”€ Ioc/            â†’ InjeÃ§Ã£o de dependÃªncias
```

## ðŸ“„ LicenÃ§a

Este projeto estÃ¡ sob a licenÃ§a [MIT](LICENSE).

## ðŸ‘¤ Autor

Desenvolvido por **[Seu Nome]** â€” [LinkedIn](https://linkedin.com/in/seu-perfil)
