[>] [English](README.en.md) | [Espanol](README.es.md)

# {$} Gerenciamento Financeiro

![.NET](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4)
![WinForms](https://img.shields.io/badge/Windows%20Forms-0078D6?logo=windows)
![License](https://img.shields.io/badge/license-MIT-green)

> Controle financeiro pessoal com registro de entradas/saidas e historico -- Windows Forms com DDD.

## [+] Features

- {$} Registro de entradas e saidas
- [>] Historico de transacoes com filtros
- [*] Tipo de transacao categorizado (enum)
- {/} Arquitetura DDD com IoC

## {=} Tech Stack

- .NET Framework 4.7.2 / Windows Forms
- Entity Framework
- DDD (Domain, Application, Service, Persistence, Ioc)

## [!] Como Rodar

1. Abra `GerenciamentoFinanceiro.sln` no Visual Studio
2. Execute o projeto `GerenciamentoFinanceiro`

## {/} Arquitetura

```
GerenciamentoFinanceiro/
+-- GerenciamentoFinanceiro              <- WinForms (UI)
+-- GerenciamentoFinanceiro.Application  <- Services e Interfaces
+-- GerenciamentoFinanceiro.Domain       <- Entidades, DTOs, Enums
+-- GerenciamentoFinanceiro.Service      <- Regras de negocio
+-- GerenciamentoFinanceiro.Persistence  <- Repositories, Context, Mappings
+-- GerenciamentoFinanceiro.Ioc          <- Injecao de dependencias
```

## [$] Licenca

Este projeto esta sob a licenca [MIT](LICENSE).
