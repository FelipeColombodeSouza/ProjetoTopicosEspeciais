# ProjetoTopicosEspeciais
Projeto de Tópicos Especiais - Cadastro de atendimentos entre pacientes e profissionais.

## Entidades

1. Paciente
   - Id - Id do registro do Paciente;
   - Nome - Nome do paciente;
   - Cpf - Cpf do paciente;
   - DataNascimento - Data de nascimento do paciente;
   - Email - Email do paciente; 
   - Telefone - Telefone do paciente;
   - Endereco - Endereço do paciente, rua;
2. Profissional
   - Id - Id do registro do Profissional;
   - Nome - Nome do profissional;
   - Endereco - Endereço do profissional;
   - Crm - Código de identificação médica do profissional;
3. Atendimento
   - Id - Id do registro do atendimento;
   - Descricao - Descrição do atendimento;
   - DataConsulta - Data e hora do atendimento;
   - Status - Status do atendimento;
   - CodigoPaciente - Codigo relacionado do paciente;
   - CodigoProfissional - Codigo relacionado do profissional;

## Operações

1. Paciente
- [X] Cadastrar
- [X] Editar
- [X] Excluir
- [X] Listar
- [X] Buscar por ID
2. Profissional
- [X] Cadastrar
- [X] Editar
- [X] Excluir
- [X] Listar
- [X] Buscar por ID
3. Atendimento
- [X] Cadastrar
- [X] Editar
- [X] Excluir
- [X] Listar
- [X] Buscar Histórico do Paciente
- [X] Buscar Histórico do Profissional
- [X] Inicar Atendimento
- [X] Finalizar Atendimento
- [X] Cancelar Atendimento
