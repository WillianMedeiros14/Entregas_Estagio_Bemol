# Conhecendo a arquitetura

### 1. Como a Web funciona no contexto de microsserviços?
A Web no contexto de microsserviços funciona por meio de pequenas aplicações independentes que se comunicam entre si através de APIs, utilizando protocolos como HTTP/HTTPS. Cada microsserviço executa uma função específica de maneira autônoma, permitindo que as partes da aplicação sejam desenvolvidas, implantadas e escaladas de forma independente.

### 2. Quais são as desvantagens de arquiteturas monolíticas que podem motivar a adoção de microsserviços?
Arquiteturas monolíticas, apesar de simples, têm desafios como:
- Manutenção difícil: mudando uma parte, precisa-se recompilar tudo.
- Escalabilidade limitada: só se escala a aplicação inteira.
- Desenvolvimento dependente: equipes não conseguem trabalhar de forma independente.
- Resiliência reduzida: falha em uma parte pode derrubar tudo.
- Adaptação tecnológica: difícil usar novas tecnologias.

### 3. O que são microsserviços?
Microsserviços são uma arquitetura que divide uma aplicação em pequenos serviços independentes, cada um com uma função específica. Eles se comunicam via APIs e podem ser desenvolvidos, implantados e escalados separadamente. Isso facilita a manutenção, melhora a flexibilidade e a resiliência das aplicações. A abordagem permite que diferentes equipes trabalhem em partes distintas da aplicação sem interferir umas nas outras.

### 4. Quais são as principais vantagens e desvantagens dos microsserviços?
Vantagens:
- Escalabilidade: cada serviço pode ser escalado de forma independente.
- Manutenção Simplificada: atualizações e correções afetam apenas um serviço.
- Desenvolvimento Ágil: equipes podem trabalhar em paralelo em diferentes serviços.
- Flexibilidade Tecnológica: cada serviço pode usar a tecnologia mais adequada.
- Resiliência: falhas são isoladas, evitando que derrubem o sistema inteiro.

Desvantagens:
- Complexidade Operacional: gerenciar múltiplos serviços pode ser complicado.
- Comunicação Interserviços: alta dependência de comunicação entre serviços pode introduzir latência e falhas.
- Consistência de Dados: garantir a consistência dos dados entre serviços é desafiador.
- Sobrecarga de Testes: testes devem garantir a integração de vários serviços.
- Implantação e Monitoramento: requer ferramentas e práticas robustas.

### 5. Quais os diferentes tipos de serviços em uma arquitetura de microsserviços?
Os tipos de serviços podem variar bastante, dependendo das necessidades da aplicação. Alguns exemplos comuns:
- Serviços de Autenticação e Autorização: gerenciam logins de usuários e controle de acesso.
- Serviços de Catálogo de Produtos: mantêm informações sobre os produtos disponíveis em uma loja online.
- Serviços de Carrinho de Compras: lidam com as operações de adicionar, remover e atualizar itens no carrinho.
- Serviços de Pagamento: processam transações financeiras e interagem com gateways de pagamento.
- Serviços de Notificação: enviam emails, SMS ou outras notificações aos usuários.
- Serviços de Logística e Entrega: gerenciam a expedição e rastreamento de pedidos.
- Serviços de Análise de Dados: coletam e analisam dados para insights de negócios.