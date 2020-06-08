# Livraria

Comentários by alessandroBettio:

Requisitos:

    O sistema deverá mostrar todos os livros cadastrados ordenados de forma ascendente pelo nome. => OK
    Ao persistir, validar se o livra já foi cadastrado.                                           => OK - apenas via API
    O sistema deverá permitir criar, editar e excluir um livro.                                   => OK
    Os livros devem ser persistidos em um banco de dados.                                         => OK
    Criar algum mecanismo de log de registro e de erro.                                           => estava em desenvolvimento

Outros Requisitos:

    Para a persistência dos dados deve ser utilizado o Dapper ou EF Core.                         => EF Core
    Configurar o Swagger na aplicação(fundamental)                                                => OK
    Usar Microsfot SqlServer 2014 ou superior.                                                    => SQL Server 2019 Express
    Utilizar migrations ou Gerar Scripts e disponibilizá-los um uma pasta.                        => Anexo

Observações:

    O sistema deverá ser desenvolvido na plataforma .NET com C#, usando o framework ASP.NET CORE 
    (preferêncialmente 3.0+, caso for usado outra versão, informar no pull-request)               => ASP.NET CORE 3.1
    
    Deve conter autenticação com dois níveis de acesso, um administrador e um público, 
    o usuário de nível público não terá autenticação, ou seja, terá acesso livre.                 => não realizado
    
    Atenção aos princípio do SOLID.

Diferencial do desafio 1:

    Implementar front-end para consumir a API em Angular como framework Javascript.               => não realizado
    obs: Teste terá como avaliação principal os requisitos solicitados para o backend, porém o frontend poderá ser critério de desempate.

Será um diferencial

    Aplicação das boas práticas do DDD, TDD, Design Patterns, SOLID e Clean Code.

Como deverá ser entregue:

1. Faça um fork deste repositório;
2. Realize o teste;
3. Adicione seu currículo na raiz do repositório;
4. Envie-nos o PULL-REQUEST para que seja avaliado;
