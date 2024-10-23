# Lidando com dados

### 1. Por que é recomendado que cada serviço tenha seu próprio banco de dados em uma arquitetura de microsserviços?
Para garantir independência e evitar acoplamento, permitindo que cada serviço seja desenvolvido, escalado e implantado separadamente. Isso também ajuda na escolha do banco de dados mais adequado para cada serviço, aumentando a eficiência.

### 2. Explique como o padrão CQRS (Command Query Responsibility Segregation) pode ajudar na gestão de dados em microsserviços.
CQRS separa operações de leitura (Queries) das operações de escrita (Commands), permitindo otimizações específicas para cada tipo de operação. Isso melhora o desempenho e facilita a escalabilidade e a manutenção dos dados.

### 3. Quais são as vantagens e desafios de utilizar diferentes tipos de bancos de dados em uma mesma aplicação de microsserviços?
- Vantagens: Cada serviço pode usar o banco de dados mais apropriado para suas necessidades específicas, melhorando performance e eficiência. 
- Desafios: Aumenta a complexidade de gestão e manutenção, além de possíveis problemas de consistência de dados entre diferentes sistemas.

### 4. Como os eventos assíncronos podem ser utilizados para garantir a comunicação entre serviços sem comprometer a performance do sistema?
Eventos assíncronos permitem que serviços se comuniquem sem esperar respostas imediatas, reduzindo a latência e melhorando a performance. Serviços publicam eventos, e outros serviços inscritos os processam conforme sua disponibilidade.

### 5. Quais são os principais cuidados ao implementar eventos assíncronos em uma arquitetura de microsserviços?
Garantir a ordem dos eventos, consistência eventual dos dados, tolerância a falhas (reprocessamento de eventos perdidos), e monitoramento robusto para detectar e corrigir problemas rapidamente.