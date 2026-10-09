using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Sistema_Hospitalario
{
    public class RepositorioJson
    {
        private readonly string carpeta = Path.Combine(
            AppContext.BaseDirectory, "Datos");

        private readonly string rutaArchivo = Path.Combine(
            AppContext.BaseDirectory, "Datos", "hospital.json");

        public DatosHospital Cargar()
        {
            if (!File.Exists(rutaArchivo))
                return new DatosHospital();

            string json = File.ReadAllText(rutaArchivo);

            if (string.IsNullOrWhiteSpace(json))
                throw new InvalidDataException(
                    "El archivo hospital.json está vacío.");

            DatosHospital datos =
                JsonSerializer.Deserialize<DatosHospital>(json)
                ?? throw new InvalidDataException(
                    "El archivo no contiene datos válidos.");

            if (datos.Pacientes == null)
                throw new InvalidDataException(
                    "Falta la lista de pacientes en el archivo.");

            return datos;
        }

        public void Guardar(DatosHospital datos)
        {
            Directory.CreateDirectory(carpeta);

            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(datos, opciones);

            string rutaTemporal = rutaArchivo + ".tmp";
            string rutaRespaldo = rutaArchivo + ".bak";

            File.WriteAllText(rutaTemporal, json);

            if (File.Exists(rutaArchivo))
            {
                File.Replace(
                    rutaTemporal, rutaArchivo, rutaRespaldo);
            }
            else
            {
                File.Move(rutaTemporal, rutaArchivo);
            }
        }
    }
}
