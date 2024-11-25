CREATE TABLE Pacientes (
    PacienteID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    CPF CHAR(11) UNIQUE NOT NULL,
    DataNascimento DATE NOT NULL,
    Telefone NVARCHAR(20),
    Email NVARCHAR(100),
    Endereco NVARCHAR(200),
    DataCadastro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Medicos (
    MedicoID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    CRM NVARCHAR(20) UNIQUE NOT NULL,
    Especialidade NVARCHAR(100) NOT NULL,
    Telefone NVARCHAR(20),
    Email NVARCHAR(100),
    DataCadastro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Consultas (
    ConsultaID INT PRIMARY KEY IDENTITY(1,1),
    PacienteID INT NOT NULL,
    MedicoID INT NOT NULL,
    DataHoraConsulta DATETIME NOT NULL,
    Status NVARCHAR(20) DEFAULT 'Agendada', -- Status pode ser: Agendada, Concluída, Cancelada
    Observacoes NVARCHAR(500),
    FOREIGN KEY (PacienteID) REFERENCES Pacientes(PacienteID),
    FOREIGN KEY (MedicoID) REFERENCES Medicos(MedicoID)
);

CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Login NVARCHAR(50) UNIQUE NOT NULL,
    SenhaHash NVARCHAR(256) NOT NULL, -- Armazena o hash da senha
    Tipo NVARCHAR(20) NOT NULL, -- Tipos: Administrador, Recepcionista, Médico
    Ativo BIT DEFAULT 1,
    DataCadastro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Especialidades (
    EspecialidadeID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL
);

-- Relacionar Médico com Especialidade
CREATE TABLE MedicoEspecialidade (
    MedicoID INT NOT NULL,
    EspecialidadeID INT NOT NULL,
    PRIMARY KEY (MedicoID, EspecialidadeID),
    FOREIGN KEY (MedicoID) REFERENCES Medicos(MedicoID),
    FOREIGN KEY (EspecialidadeID) REFERENCES Especialidades(EspecialidadeID)
);

CREATE TABLE Notificacoes (
    NotificacaoID INT PRIMARY KEY IDENTITY(1,1),
    ConsultaID INT NOT NULL,
    Meio NVARCHAR(20) NOT NULL, -- Exemplo: SMS, Email
    DataEnvio DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) DEFAULT 'Pendente', -- Status: Pendente, Enviado, Falhou
    FOREIGN KEY (ConsultaID) REFERENCES Consultas(ConsultaID)
);



