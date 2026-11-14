# Simplr View

Sistema desktop de gestão e vendas desenvolvido em **VB.NET (Windows Forms)** com banco de dados **MySQL**, em 2019. É a evolução do [Final Stop](https://github.com/gabrielfins/final-stop) e traz o módulo de vendas que estava na lista de "Projetos Futuros" daquela versão.

## Funcionalidades

- Login de funcionários
- **Cadastros:** clientes, fornecedores, funcionários e produtos (com validação de CPF/CNPJ)
- **Vendas** e **histórico de vendas**
- **Relatórios:** clientes, fornecedores, funcionários, produtos, vendas e cupom fiscal (Microsoft Report Viewer — `.rdlc`)
- Tela de opções e tela "Sobre"

## Tecnologias

- VB.NET / Windows Forms (.NET Framework)
- MySQL (Connector/NET — `MySql.Data`)
- Microsoft Report Viewer

## Como executar

Pré-requisitos: Windows, Visual Studio (com .NET Framework / Windows Forms) e um servidor MySQL.

1. Crie o banco importando o script `db_finalstop.sql`:
   ```bash
   mysql -u root -p < db_finalstop.sql
   ```
2. Abra `SimplrView.sln` no Visual Studio.
3. Ajuste a string de conexão em `SimplrView/App.config` (servidor, usuário, senha e banco `db_finalstop`).
4. Restaure os pacotes NuGet, compile e execute (`F5`).
