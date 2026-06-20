🌐 [Português](README.md) | [English](README.en.md)

# 💰 Gestión Financiera

Sistema de gestión financiera personal en .NET Framework 4.7.2 (Windows Forms) con arquitectura en capas.

## Tech Stack

- .NET Framework 4.7.2 / Windows Forms
- Entity Framework
- DDD (Domain, Application, Service, Persistence, IoC)

## Cómo Ejecutar

1. Abra `GerenciamentoFinanceiro.sln` en Visual Studio
2. Ejecute el proyecto `GerenciamentoFinanceiro`

## Arquitectura

```
GerenciamentoFinanceiro/
├── GerenciamentoFinanceiro              ← WinForms (UI)
├── GerenciamentoFinanceiro.Application  ← Services e Interfaces
├── GerenciamentoFinanceiro.Domain       ← Entidades, DTOs, Enums
├── GerenciamentoFinanceiro.Service      ← Reglas de negocio
├── GerenciamentoFinanceiro.Persistence  ← Repositories, Context, Mappings
└── GerenciamentoFinanceiro.Ioc          ← Inyección de dependencias
```

## Autor

Daniel Hoffmann
