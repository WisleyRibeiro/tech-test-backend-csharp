# Prova Técnica - Desenvolvedor de Software Backend C#

## LOGIN

Ao iniciar o software, os usuários se deparam com uma tela de login que oferece duas opções: logar como Administrador ou como Usuário Comum.

### LOGANDO COMO ADMINISTRADOR

Para entrar como Administrador, é necessário inserir as seguintes credenciais:

- Usuário: admin
- Senha: admin
- Tipo de Usuário: Administrador

Após o login, o Administrador terá acesso a privilégios elevados, incluindo funcionalidades de gerenciamento direto do banco de dados SQL (detalhado posteriormente). Estas funcionalidades incluem:

- Gerenciamento de Usuários: Permite cadastrar novos usuários, definir suas permissões (Administrador ou Comum), atualizar dados de usuários existentes e excluí-los. Além disso, há uma funcionalidade de busca que permite encontrar usuários com base em palavras-chave.

- Gerenciamento de Categorias: Oferece a capacidade de criar categorias para classificar produtos, com opções para cadastro, atualização, exclusão e busca.

- Gerenciamento de Produtos: Permite adicionar, atualizar, excluir e visualizar informações detalhadas sobre produtos. Também é possível associar produtos às categorias previamente criadas e realizar buscas por palavras-chave.

- Os painéis "Inventário" e "Transações" representam conceitos, possibilitando a criação de funcionalidades adicionais com base na estrutura existente no software. O banco de dados já possui tabelas correspondentes a esses painéis.

### LOGANDO COMO USUÁRIO COMUM

Para entrar como Usuário Comum, é necessário inserir as seguintes credenciais:

- Usuário: comum
- Senha: comum
- Tipo de Usuário: Comum

Os Usuários Comuns têm acesso a funcionalidades com privilégios reduzidos, incluindo:

- Gerenciamento de Vendas: Permite adicionar produtos e suas quantidades a uma venda. Também oferece uma funcionalidade de busca que possibilita encontrar produtos com base em palavras-chave.

- Cálculos: Na lateral direita da tela, são exibidos valores como Subtotal, Total Geral e Troco. Os usuários podem adicionar descontos ou taxas, o que atualizará imediatamente o valor do Total Geral. Além disso, ao inserir um valor no campo Total Pago, o sistema calculará automaticamente o troco devido ao cliente.

- Lista de Produtos: Os produtos adicionados à venda são listados, permitindo que os usuários visualizem informações detalhadas, incluindo a possibilidade de adicionar imagens e outros detalhes, se necessário.

- Observação: Embora os títulos das janelas sejam "Comprar" e "Vendas", as funcionalidades são essencialmente as mesmas, com o objetivo de permitir compras e vendas de produtos usando a mesma lógica.

## BANCO DE DADOS ESCOLHIDO

O banco de dados selecionado para este projeto é o SQL (SQL Server Management Studio - SSMS). Inicialmente, foi configurado um banco de dados local com acesso remoto via IP. No entanto, para maior comodidade dos avaliadores, o servidor foi migrado para a nuvem.

### AWS (Amazon Web Services)

A Amazon Web Services (AWS) foi escolhida como provedor para hospedar o servidor de banco de dados. Essa escolha garante que o banco de dados esteja disponível 24/7, evitando a necessidade de configurações de firewall e garantindo maior segurança dos dados.

Desde o início do projeto, o objetivo foi criar um software que se assemelhasse a um produto final ou a um Mínimo Produto Viável (MPV). Portanto, houve dedicação para atender aos requisitos solicitados, criar uma interface amigável, garantir a segurança dos dados e garantir que todas as funcionalidades estejam plenamente funcionais.

### SISTEMA DE ALERTAS

O sistema de alertas foi personalizado para utilizar a interface nativa da aplicação em vez do tradicional `MessageBox.Show("Alerta!")`. Isso foi feito para economizar armazenamento e simplificar a experiência do usuário. Os alertas em cada tela alteram uma label, eliminando a necessidade de criar telas de alerta separadas para cada situação (detalhes disponíveis no código).

### CONDICIONAMENTOS

A aplicação implementa diversos condicionamentos, incluindo:

- Validação de inserção de valores inválidos.
- Verificação de campos obrigatórios não preenchidos.
- Aplicação de regras para a inserção de dados (por exemplo, a entrada de caracteres não numéricos em campos destinados a valores numéricos é impedida).

Esses condicionamentos evitam problemas de tratamento de dados e erros lógicos por parte dos usuários.

### OBSERVAÇÕES

Espero ter atendido às expectativas. Dediquei-me muito a este projeto com o objetivo de fornecer o meu melhor. Estou à disposição para fornecer mais detalhes, se necessário. Agradeço a vocês por esta valiosa oportunidade.

### DEDICATÓRIA

Dedico este trabalho ao meu Senhor, Todo-Poderoso!
