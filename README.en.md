🌐 [Português](README.md) | [Español](README.es.md)

# 💰 Financial Management

Personal financial management system in .NET Framework 4.7.2 (Windows Forms) with layered architecture.

## Tech Stack

- .NET Framework 4.7.2 / Windows Forms
- Entity Framework
- DDD (Domain, Application, Service, Persistence, IoC)

## How to Run

1. Open `GerenciamentoFinanceiro.sln` in Visual Studio
2. Run the `GerenciamentoFinanceiro` project

## Architecture

```
GerenciamentoFinanceiro/
├── GerenciamentoFinanceiro              ← WinForms (UI)
├── GerenciamentoFinanceiro.Application  ← Services and Interfaces
├── GerenciamentoFinanceiro.Domain       ← Entities, DTOs, Enums
├── GerenciamentoFinanceiro.Service      ← Business rules
├── GerenciamentoFinanceiro.Persistence  ← Repositories, Context, Mappings
└── GerenciamentoFinanceiro.Ioc          ← Dependency injection
```