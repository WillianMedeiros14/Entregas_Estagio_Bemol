# Separando serviços

### 1. O que são serviços de domínio e como eles se relacionam com o DDD (Domain-Driven Design)?
Serviços de domínio são componentes que encapsulam lógica de negócio específica do domínio da aplicação, seguindo os princípios do DDD (Domain-Driven Design). Eles refletem conceitos do mundo real e são independentes, facilitando a compreensão e evolução da aplicação.

### 2. Qual é o propósito de dividir uma aplicação monolítica em serviços de negócio?
Dividir uma aplicação monolítica em serviços de negócio busca melhorar a escalabilidade, a manutenção e a flexibilidade. Cada serviço pode ser desenvolvido, implantado e escalado independentemente, permitindo atualizações e manutençõos sem afetar o sistema todo.

### 3. Como o padrão Strangler pode ajudar na transição de um sistema monolítico para microsserviços?
O padrão Strangler consiste em adicionar novos microsserviços em paralelo ao sistema monolítico existente, substituindo gradualmente partes do monolito com novos serviços até que a aplicação inteira seja transformada. Isso minimiza riscos e facilita a migração.

### 4. Explique o padrão Sidecar e sua aplicação em arquiteturas de microsserviços.
O padrão Sidecar envolve a implantação de um serviço auxiliar, ou "sidecar," junto ao serviço principal, proporcionando funcionalidades adicionais, como logging, monitoramento ou proxy. Isso permite a separação de preocupações e melhora a modularidade e manutenção dos serviços.

### 5. Quais são os principais desafios ao quebrar um monolito em microsserviços e como superá-los?
Desafios incluem a complexidade de gerenciar muitos serviços, garantir a consistência dos dados, e lidar com a comunicação entre os serviços. Superá-los envolve adotar boas práticas de DevOps, usar ferramentas de monitoramento e logging, e implementar padrões de comunicação robustos, como event-driven architecture.
