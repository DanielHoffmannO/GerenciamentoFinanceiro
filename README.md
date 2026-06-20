🌐 [English](README.en.md) | [Español](README.es.md)

# 💰 Gerenciamento Financeiro

Sistema de gerenciamento financeiro pessoal em .NET Framework 4.7.2 (Windows Forms) com arquitetura em camadas.

## Tech Stack

- .NET Framework 4.7.2 / Windows Forms
- Entity Framework
- DDD (Domain, Application, Service, Persistence, IoC)

## Como Rodar

1. Abra `GerenciamentoFinanceiro.sln` no Visual Studio
2. Execute o projeto `GerenciamentoFinanceiro`

## Arquitetura

```
GerenciamentoFinanceiro/
├── GerenciamentoFinanceiro              ← WinForms (UI)
├── GerenciamentoFinanceiro.Application  ← Services e Interfaces
├── GerenciamentoFinanceiro.Domain       ← Entidades, DTOs, Enums
├── GerenciamentoFinanceiro.Service      ← Regras de negócio
├── GerenciamentoFinanceiro.Persistence  ← Repositories, Context, Mappings
└── GerenciamentoFinanceiro.Ioc          ← Injeção de dependências
```

## Autor

Daniel Hoffmann
