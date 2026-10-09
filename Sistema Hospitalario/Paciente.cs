using System;
public class Paciente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Documento { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Contacto { get; set; }
    public string Antecedentes { get; set; }
    public bool Activo { get; set; }

    public Paciente()
    {
        Nombre = "";
        Documento = "";
        Contacto = "";
        Antecedentes = "";
        Activo = true;
    }

    public Paciente(int id, string nombre, string documento,
        DateTime fechaNacimiento, string contacto,
        string antecedentes) : this()
    {
        Id = id;
        ActualizarDatos(nombre, documento, fechaNacimiento,
            contacto, antecedentes);
    }

    public void ActualizarDatos(string nombre, string documento,
        DateTime fechaNacimiento, string contacto,
        string antecedentes)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("Ingresá el nombre del paciente.");

        if (fechaNacimiento.Date > DateTime.Today)
            throw new ArgumentException(
                "La fecha de nacimiento no puede ser futura.");

        Nombre = nombre.Trim();
        Documento = (documento ?? "").Trim();
        FechaNacimiento = fechaNacimiento.Date;
        Contacto = (contacto ?? "").Trim();
        Antecedentes = (antecedentes ?? "").Trim();
    }

    public void Desactivar()
    {
        Activo = false;
    }
}