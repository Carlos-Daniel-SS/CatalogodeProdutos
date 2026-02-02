# Roteiro de Confiança em Engenharia de Software (Hands-on & Mindset Driven)

Este documento descreve um caminho de desenvolvimento gradual para transformar um(a) mente iniciante em um(a) engenheiro(a) de software confiante, completo e capaz de tomar decisões técnicas com clareza. Foco em projetos incrementais, fundamentos sólidos, práticas reais de engenharia, documentação e mindset — com ênfase na compreensão do “porquê” antes do “como”.

---

## 🎯 Objetivo Central

- Construir confiança por meio de preparação e repetição
- Projetos pequenos que evoluem com o tempo
- Entender fundamentos reais (sem atalhos)
- Práticas de engenharia reais e documentadas
- Confiança cresce com reflexão, não com velocidade
- Documentação como parte da aprendizagem
- Explorar trade-offs e diferentes caminhos

---

## 🧠 Filosofia Guia

- A confiança vem da preparação e da prática deliberada
- Começar simples e evoluir o sistema
- Cada conceito conectado a prática real
- Documentação é parte do aprendizado (não tarefa extra)
- Não existe uma única “forma certa” — explorar trade-offs

---

## 📂 Organização: Notion como Diário de Aprendizagem

- Use Notion como página principal do seu projeto
- A página principal representa o sistema evolutivo único (ex.: Gerenciador de Usuários API)
- Crie uma subpágina para cada marco (milestone)
- Cada subpágina de milestone deve incluir:
  - O que foi construído
  - Como foi construído
  - Perguntas e incertezas
  - Erros e como foram resolvidos
  - Reflexões pessoais
  - O que foi aprendido
  - O que não deve ser repetido
- Use o Tabela de Conteúdos (Table of Contents) dentro de cada página de milestone
- Incentive diagramas e modelos mentais (Whimsical ou similar)

---

## 🧭 Por que essa Princípio Importa

- O projeto conta uma história ao longo do tempo
- Você vê como as decisões evoluíram
- Erros iniciais viram artefatos de aprendizado
- O Notion vira um portfólio vivo, não notas soltas
- Software cresce por meio de milestones, não apenas os marcos

---

## 🧩 Categorias de Issues

- **[TECH]** — Implementação técnica
- **[ME]** — Evolução de Mindset — Reflexão e raciocínio
- **[HO]** — Desafios práticos / Provas de Conceito (POCs)

---

## 🧭 Convenção de Branch

- Formato: `milestone-{número_do_milestone}-{descrição_curta}-usuario-funcionalidade_curta`
  - Exemplo: `milestone-1-start-up-johndoe-add-swagger`

---

## 🛣️ Sequência da Roadmap (Ordem Obrigatória)

- Milestone 0 — Git e Fundamentos do GitHub
- Milestone 0.1 — Fundamentos de Linguagens & Modelo de Execução
- Milestone 1 — Start Up
  - Milestone 1.1 — REST API Best Practices
  - Milestone 1.2 — Arquitetura da API
  - Milestone 1.3 — Validação
- Milestone 2 — Testes Automatizados
  - Milestone 2.1 — HTTP e DNS
- Milestone 3 — Integração Contínua
- Milestone 4 — Docker
  - [HO] Hands-On — Dockerflix
- Milestone 5 — Banco de Dados Local
- Milestone 6 — Migrações
- Milestone 7 — Publicação da API em URL Pública
- Milestone 8 — Entrega Contínua (CD)
- Milestone 9 — Infraestrutura como Código (IaC)

---

## 🗺️ Milestones

### Milestone 0 — Git e Fundamentos do GitHub

Objetivo: Fundar a base para colaboração, histórico e fluxos de trabalho profissionais.

- Objetivos
  - Entender o que é Git e por que ele existe
  - Caminhos de colaboração antes do Git
  - Usar o GitHub como plataforma de colaboração
- Tarefas
  - Criar um repositório no GitHub
  - Adicionar o mentor como colaborador
  - Realizar commits e push com frequência
  - Bloquear merges na branch main sem PRs; PRs precisam de revisão e aprovação
  - Usar branches para recursos e correções
- Conceitos
  - O que é Git e qual problema resolve
  - Problemas de versionamento sem VCS
  - O que é commit e por que ele importa
  - Como o software era gerenciado antes do Git
- [ME] Questões
  - Por que o controle de versão é essencial
  - Por que o histórico de commits é documentação
- [HO] Desafios
  - Desenhar um diagrama do fluxo de Git
  - Explicar conceitos de commit e branch para alguém sem background técnico

---

### Milestone 0.1 — Fundamentos de Linguagens & Modelo de Execução

Objetivo: Entender como as linguagens são executadas, como o código se torna software executável e o papel do runtime.

- Tópicos a Explorar
  - Diferença entre linguagens interpretadas e compiladas
  - Modelos de execução híbridos
  - Como funciona o pipeline de compilação no .NET
  - O que acontece em compile-time vs runtime
  - O que é JIT (Just-In-Time) e por quê
- Conceitos a Entender
  - Código fonte vs código de máquina
  - IL (Intermediary Language) / Assemblies (.dll, .exe)
  - CLR (Common Language Runtime)
  - Trade-offs de compilação e execução
- [ME] Questões
  - Por que entender execuções ajuda na engenharia
  - Partes da execução que ainda parecem “mágicas”
  - Como esse conhecimento muda debugging e raciocínio de performance
- [HO] Desafios
  - Desenhar o fluxo de execução do .NET
  - Explicar JIT para alguém sem background de backend

---

### Milestone 1 — Start Up

- Objetivo: Criar uma API simples em .NET com uma única camada, sem testes, sem banco de dados (usando lista em memória). Foco em startup e configuração.
- Tarefas
  - Criar um projeto API .NET
  - Camada única (single layer)
  - Sem testes
  - Sem banco de dados (em memória)
  - Foco na inicialização e configuração do projeto
  - Adicionar perguntas não respondidas ao final
  - O que é um projeto Web API?
  - Tipos de projetos no .NET e por que usar (Console, Class Library, Web API)
  - Adicionar Swagger (inclui UI)
  - Por que Swagger ajuda o projeto?
- [HO] Desafio
  - Configurar uma aplicação simples com endpoints CRUD básicos usando lista em memória
  - Garantir que a UI Swagger esteja acessível

---

### Milestone 1.1 — REST API Best Practices

- Objetivo: Práticas recomendadas de REST, verbos HTTP corretos, respostas consistentes, uso de ActionResult, códigos HTTP adequados, configuração de Swagger.

- Conteúdos
  - Verbos HTTP corretos e padrões de rotas
  - Respostas consistentes da API
  - Uso de ActionResult / ActionResult<T>
  - Códigos de status HTTP corretos
  - Configuração do Swagger

- [ME] Questões
  - Por que o NS (validation) é importante no contexto da API?
  - O papel da camada de aplicação na validação?
  - Prós e contras de diferentes abordagens de validação

---

### Milestone 1.2 — Arquitetura da API

- Objetivo: Entender por que arquitetura existe e como estruturar código para manter, testar e evoluir.

- Desafio
  - Refatorar a User Manager API para introduzir fronteiras arquiteturais claras
  - Adicionar uma camada de Domínio
  - Separar responsabilidades entre camadas
  - Mover lógica de negócio para controllers -> serviços/use-cases
  - Injeção de dependência (DI) para o uso de serviços

- Conceitos a Entender
  - O que é arquitetura de software?
  - Por que ter camadas?
  - Benefícios, trade-offs e situações de overkill
  - O que é Injeção de Dependência (DI) e tipos de DI

- [ME] Questões
  - Por que “apenas funcionar” não é suficiente
  - Como arquitetura ruim atrasa equipes

- [ME] Questões Específicas
  - Quando simplicidade é melhor que abstração

---

### Milestone 1.3 — Validação

- Objetivo: Entender por que validação existe, onde deve ficar e responsabilidades da aplicação.

- Desafio
  - Refletir sobre o uso atual do FluentValidation e explorar estratégias alternativas

- Perguntas de Reflexão ([ME])
  - Por que FluentValidation é uma boa escolha aqui?
  - Por que a camada de aplicação é responsável pela validação?
  - Prós e contras de cada abordagem de validação

- Estratégias de Validação a Explorar
  - Data Annotations
  - Validação em nível de domínio
  - Restrições no banco de dados
  - Validação no frontend
  - Serviços externos de validação
  - Lançar exceções

- Insight-chave
  - Não existe uma única estratégia correta de validação. O bom engenheiro entende trade-offs, contexto e consequências.

---

### Milestone 2 — Testes Automatizados

- Objetivo: Aprender o ciclo de vida de testes desde o zero, introduzir camada de aplicação em testes, NUnit + FluentAssertions, e o padrão Arrange/Act/Assert.
- Observação: Testes devem descrever regras de negócio, não implementação.

- [ME] Questões
  - Por que testes unitários importam?
  - Pirâmide de Testes vs. Test Trophy vs. Test Honeycomb
  - Prós e contras de TDD
  - Cobertura de testes: o que ela mede e o que não mede
  - Opções em .NET além do NUnit

---

### Milestone 2.1 — HTTP e DNS

- Objetivo: Entender profundamente HTTP, fluxo de resolução de DNS, Statelessness, implicações de performance e o que acontece quando uma API é chamada.

- [ME] Questões
  - Conversa sobre códigos de status HTTP, confiabilidade de DNS e diferenças entre rede vs aplicação

---

### Milestone 3 — Integração Contínua (CI)

- Conteúdos: conceitos de CI, cultura de equipe, GitHub Actions, pipeline de build e testes, bloqueio de merge em falha.

- [ME] Questões
  - CI como cultura, não apenas ferramenta
  - Responsabilidade quando pipelines falham
  - CI vs CD

---

### Milestone 4 — Docker

- Conteúdos: containers vs máquinas virtuais, fundamentos de Docker, Dockerfiles, Docker Compose.

- [ME] Questões
  - Papel do Docker no ecossistema de containers
  - O que Docker resolve (ou não)
  - Alternativas ao Docker

- [HO] Desafio Hands-On — Dockerflix
  - Aplicação full-stack (front-end Angular, back-end Node)
  - Dockerfile para frontend e backend
  - Docker Compose para executar ambos
  - Frontend consome API backend
  - Push de imagens para o Docker Hub
  - Validação de tudo rodando via Docker

---

### Milestone 5 — Banco de Dados Local

- Introduzir banco de dados real
- Rodar DB local via Docker Compose
- Configurar conexão da aplicação
- Persistir e recuperar dados
- Reproduzir o sistema completo com um único comando

---

### Milestone 6 — Migrações

- Entender evolução de esquemas
- Introduzir migrações de banco de dados
- Aplicar migrações localmente
- Versionar mudanças de banco
- Compreender estratégias de rollback e riscos

---

### Milestone 7 — Publicação da API em URL Pública

- Publicar a API externamente
- Gerenciar configurações por ambiente
- Tratar segredos com segurança
- Validar acessos externos
- Entender serviços públicos vs privados

---

### Milestone 8 — Entrega Contínua (CD)

- Extender CI para CD
- Automatizar deploys
- Garantir que deployments ocorram somente após validação
- Estratégias de release e riscos
- Manter o sistema sempre implantável

---

### Milestone 9 — Infraestrutura como Código (IaC)

- Gerenciar infraestrutura com código
- Entender drift de infraestrutura
- Ferramentas declarativas (ex.: Terraform)
- Versionar e revisar mudanças de infraestrutura
- Integrar IaC com pipelines de CI/CD

---

## ✅ Saída Esperada

- Gerar milestones com descrições claras
- Issues por milestone
- Questões [ME] de reflexão
- Desafios [HO] práticos
- Metas de aprendizado bem definidas para cada etapa
- Tom motivacional, no estilo mentor

---

## ❤️ Nota Final

Este roteiro é uma jornada guiada, não apenas uma checklist. O objetivo não é velocidade, mas confiança, clareza e julgamento de engenharia.

---

## Exemplo de Issues

Abaixo estão modelos de issues que você pode reutilizar para cada milestone (em PT-BR). Copie e adapte conforme necessário.

<details>
<summary>Exemplo de ISSUE [TECH]</summary>

O objetivo desta etapa é se familiarizar com conceitos de início de projeto. Não subestime este passo — ele requer tempo, tentativa e erro para chegar onde queremos.

## Meta

Ao criarmos o primeiro projeto, o objetivo é tornar o funcionamento da aplicação previsível, com base clara de configuração, build e deploy simples.

## Desafio

Crie uma API para gerir usuários (CRUD básico). O projeto deve começar simples e evoluir nos próximos marcos, sem preocupação com complexidade neste momento.
</details>

<details>
<summary>Exemplo de ISSUE [TECH] — CI</summary>

Neste desafio, você vai introduzir Integração Contínua para o seu projeto criando um pipeline de CI com GitHub Actions.

### Requisitos

- Use GitHub Actions para criar um pipeline de CI para o projeto
- O pipeline deve ser acionado para cada pull request com destino a main
- O pipeline deve realizar:
  1) Build do projeto
  2) Execução de testes automatizados
- O passo de teste deve depender do build
- Todos os passos devem passar antes da mesclagem

### Comportamento Esperado

- Se o build falhar, os testes não devem rodar
- Se algum teste falhar, a pull request deve ser bloqueada de merge
- Um pipeline bem-sucedido garante que o projeto compila e passa nos testes

### Princípios-Chave

- CI como uma barreira de qualidade
- Falhas rápidas e visíveis
- Pipelines simples, claros e fáceis de entender
</details>

<details>
<summary>Exemplo de ISSUE [ME] — Qualidade de Testes</summary>

Nesta atividade de reflexão, explore o propósito e o valor de testes unitários — indo além de como escrever testes para entender por que testamos e quais estratégias são úteis.

## Perguntas a Responder

1) Por que devemos fazer testes unitários?
2) O que é a Pirâmide de Testes? Por que foi criada? Benefícios e limitações?
3) O que é TDD? Vantagens, desvantagens e situações úteis?
4) Cobertura de testes >80% é importante? O que cobre e o que não cobre?
5) Modelos alternativos: Test Trophy e Test Honeycomb — o que são e como se comparam?

## O que Produzir

Responda com textos estruturados, incluindo definições, diagramas, listas de prós/contras, e sua posição pessoal.

</details>

<details>
<summary>Exemplo de ISSUE [HO] — Hands-On: Dockerflix</summary>

Desafio prático para consolidar conhecimentos de Docker e arquitetura de microserviços.

### Repositório
- Estrutura:
  /docker
    /dockerflix
      /frontend
      /backend

### Requisitos Frontend (Angular)
- Localização: /docker/dockerflix/frontend
- Páginas:
  1) Home ("/") com título
     - Renderizar: <h1>Welcome to the DockerFlix</h1>
  2) Series ("/series")
     - Consumir API backend com fetch e exibir 5 séries favoritas
- Rodar na porta 3000
- Sem estilos — foco em funcionalidade

### Requisitos Backend (Node)
- Localização: /docker/dockerflix/backend
- API Endpoints:
  - GET /status → texto simples "Everything is fine"
  - GET /series → JSON com 5 séries favoritas
- Rodar na porta 4050

### Docker
- Dockerfile para frontend
- Dockerfile para backend
- docker-compose.yml para rodar os dois serviços
- Compose deve permitir que o frontend se comunique com o backend pelo nome do serviço
- Expor o frontend para acesso via navegador

### Validação
- Rodar: docker compose up
- Acessar frontend e verificar a lista de séries via /series

### Learning Goals
- Entender aplicações multi-container
- Ver como serviços se comunicam na rede do Docker
- Praticar Dockerfile e Docker Compose
- Ganhar confiança com deploy local
</details>

---

## Exemplo de Hands-On Issue (Estrutura do Repositório)

<details>
<summary>Exemplo de Hands-On Issue — Estrutura de Repositório</summary>

- Criar um repositório no GitHub chamado: Hands-On-POCs
- Estrutura de pastas:
  /docker
    /dockerflix
      /frontend
      /backend

### Frontend (Angular)
- Local: /docker/dockerflix/frontend
- Aplicação simples com as páginas descritas no desafio
- Executar em port 3000

### Backend (Node)
- Local: /docker/dockerflix/backend
- API com endpoints descritos
- Executar em port 4050

### Docker & Compose
- Dockerfiles para frontend/backend
- docker-compose.yml para rodar tudo
- O frontend consome backend pelo nome do serviço

### Validação
- Acessar http://localhost:3000/series
- Verificar a lista de séries

### Docker Hub
- Criar conta no Docker Hub
- Push das imagens com nomes/tags consistentes
</details>

---

## Exemplo de API: Catálogo de Produtos

Web API para um Catálogo simples de Produtos

- CRUD: Produtos
- Campos: nome, preço, categoria, isActive
- Extra: paginação e ordenação

 Endpoints sugeridos:
- GET /produtos
  - Retorna lista de produtos (suporta paginação com page, perPage e ordenação com sortBy, sortDir)
- GET /produtos/{id}
  - Retorna produto único
- POST /produtos
  - Cria novo produto
- PUT /produtos/{id}
  - Atualiza produto existente
- DELETE /produtos/{id}
  - Exclui produto

Estrutura de dados de exemplo:
[
  { "id": 1, "nome": "Camiseta", "preco": 39.90, "categoria": "Vestuário", "isActive": true },
  { "id": 2, "nome": "Notebook 14''", "preco": 2999.00, "categoria": "Eletrônicos", "isActive": true }
]

Notas:
- Este é apenas um exemplo mínimo para ilustrar a base da API de catálogos. Use a linguagem e o framework de sua preferência, mantendo a consistência com os objetivos do roadmap.

---

Se quiser, eu posso adaptar este Readme para um projeto específico seu (nome do projeto, tecnologias escolhidas, ou metas de cada milestone), ou criar templates prontos de Notion (com páginas e subpáginas) para facilitar a criação do diário de aprendizado conforme as regras apresentadas.