# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide

#### ✍ Parte 1
**Criticar el código dado en base a patrónes y principios**
La clase AppointmentService tenía demasiadas responsabilidades relacionadas con el doctor, el paciente y el lugar de cita. Por lo que decidí separarlas a clases diferentes y utilizar una clase que las unifique a todas en una. Esto es gracias a lo que establece el principio SRP.

#### 🧐 Parte 2
**Realizar las CRC correspondientes.**
Nombre de la tarjeta: DatosDelDoctor
Responsabilidad: Conocer datos del doctor, validar datos ingresados
Colaboraciones: Ninguna

Nombres de la tarjeta: DatosPersona
Responsabilidad: Conocer datos de la persona, validar datos ingresados
Colaboraciones: Ninguna

Nombres de la tarjeta: AppointmentService
Responsabilidad: Conocer datos del lugar, validar datos ingresados
Colaboraciones: Ninguna

Nombre de la tarjeta: Consultas
Responsabilidades: Generar una consulta
Colaboraciones: DatosDelDoctor, DatosPersona, AppointmentService

#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**

