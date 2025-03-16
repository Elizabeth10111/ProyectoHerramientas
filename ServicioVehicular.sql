CREATE DATABASE ServicioVehicular;


USE ServicioVehicular;

-- Tabla Usuario
CREATE TABLE Usuario (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(100) UNIQUE NOT NULL,
    contraseña VARCHAR(100) NOT NULL
);

-- Tabla Administrador
CREATE TABLE Administrador (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(100) UNIQUE NOT NULL,
    contraseña VARCHAR(100) NOT NULL
);

-- Tabla Vehiculo
CREATE TABLE Vehiculo (
    id INT IDENTITY(1,1) PRIMARY KEY,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    año INT NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    usuario_id INT NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id) ON DELETE CASCADE
);

-- Tabla Servicio
CREATE TABLE Servicio (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    usuario_id INT NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id) ON DELETE CASCADE
);

-- Tabla Parquedero
CREATE TABLE Parquedero (
    id INT IDENTITY(1,1) PRIMARY KEY,
    duracion INT NOT NULL,
    servicio_id INT NOT NULL,
    FOREIGN KEY (servicio_id) REFERENCES Servicio(id) ON DELETE CASCADE
);

-- Tabla LavadoVehiculo
CREATE TABLE LavadoVehiculo (
    id INT IDENTITY(1,1) PRIMARY KEY,
    propietario VARCHAR(100) NOT NULL,
    tipoLavado VARCHAR(50) NOT NULL,
    tipoVehiculo VARCHAR(50) NOT NULL,
    documentoPropietario VARCHAR(20) NOT NULL,
    placa VARCHAR(20) NOT NULL UNIQUE,
    precio DECIMAL(10,2) NOT NULL,
	servicio_id INT NOT NULL,
   FOREIGN KEY (servicio_id) REFERENCES Servicio(id) ON DELETE CASCADE
);

-- Tabla para asignar servicios a administradores
CREATE TABLE AdministradorServicio (
    id INT IDENTITY(1,1) PRIMARY KEY,
    administrador_id INT NOT NULL,
    servicio_id INT NOT NULL,
    FOREIGN KEY (administrador_id) REFERENCES Administrador(id) ON DELETE CASCADE,
    FOREIGN KEY (servicio_id) REFERENCES Servicio(id) ON DELETE CASCADE
);


