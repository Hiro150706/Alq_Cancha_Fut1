var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();


// =====================================================
// INICIO DE LA API
// =====================================================

app.MapGet("/", () =>
{
    return "API Cancha de Fútbol funcionando";
});


// =====================================================
// CANCHAS
// =====================================================

app.MapGet("/api/Cancha", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            id = 1,
            codigo = "C001",
            nombre = "Cancha Principal",
            tipoCancha = "Fútbol 7",
            capacidad = 14,
            precioHora = 80.00,
            estado = "Disponible",
            descripcion = "Cancha de fútbol 7 con césped sintético e iluminación.",
            imagen = "https://images.unsplash.com/photo-1553778263-73a83bab9b0c"
        },

        new
        {
            id = 2,
            codigo = "C002",
            nombre = "Cancha Premium",
            tipoCancha = "Fútbol 7",
            capacidad = 14,
            precioHora = 100.00,
            estado = "Disponible",
            descripcion = "Cancha de fútbol 7 con césped sintético, iluminación y vestuarios.",
            imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55"
        },

        new
        {
            id = 3,
            codigo = "C003",
            nombre = "Cancha Familiar",
            tipoCancha = "Fútbol 5",
            capacidad = 10,
            precioHora = 60.00,
            estado = "Disponible",
            descripcion = "Cancha de fútbol 5 ideal para partidos entre amigos y familias.",
            imagen = "https://images.unsplash.com/photo-1526232761682-d26e03ac148e"
        }
    });
});


// =====================================================
// HORARIOS Y DISPONIBILIDAD
// =====================================================

app.MapGet("/api/Horarios", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            id = 1,
            codigo = "H001",
            fecha = "2026-10-02",
            hora = "08:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 7",
            precio = 80.00,
            duracion = 60
        },

        new
        {
            id = 2,
            codigo = "H002",
            fecha = "2026-10-02",
            hora = "10:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 7",
            precio = 80.00,
            duracion = 60
        },

        new
        {
            id = 3,
            codigo = "H003",
            fecha = "2026-10-02",
            hora = "12:00",
            estado = "Reservado",
            disponibilidad = false,
            tipoCancha = "Fútbol 7",
            precio = 80.00,
            duracion = 60
        },

        new
        {
            id = 4,
            codigo = "H004",
            fecha = "2026-10-02",
            hora = "14:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 5",
            precio = 60.00,
            duracion = 60
        },

        new
        {
            id = 5,
            codigo = "H005",
            fecha = "2026-10-02",
            hora = "16:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 7",
            precio = 80.00,
            duracion = 60
        },

        new
        {
            id = 6,
            codigo = "H006",
            fecha = "2026-10-02",
            hora = "18:00",
            estado = "Reservado",
            disponibilidad = false,
            tipoCancha = "Fútbol 7",
            precio = 100.00,
            duracion = 60
        },

        new
        {
            id = 7,
            codigo = "H007",
            fecha = "2026-10-02",
            hora = "20:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 7",
            precio = 100.00,
            duracion = 60
        },

        new
        {
            id = 8,
            codigo = "H008",
            fecha = "2026-10-03",
            hora = "08:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 5",
            precio = 60.00,
            duracion = 60
        },

        new
        {
            id = 9,
            codigo = "H009",
            fecha = "2026-10-03",
            hora = "10:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 7",
            precio = 80.00,
            duracion = 60
        },

        new
        {
            id = 10,
            codigo = "H010",
            fecha = "2026-10-03",
            hora = "16:00",
            estado = "Reservado",
            disponibilidad = false,
            tipoCancha = "Fútbol 7",
            precio = 80.00,
            duracion = 60
        },

        new
        {
            id = 11,
            codigo = "H011",
            fecha = "2026-10-03",
            hora = "18:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 7",
            precio = 100.00,
            duracion = 60
        },

        new
        {
            id = 12,
            codigo = "H012",
            fecha = "2026-10-03",
            hora = "20:00",
            estado = "Disponible",
            disponibilidad = true,
            tipoCancha = "Fútbol 5",
            precio = 60.00,
            duracion = 60
        }
    });
});


// =====================================================
// SERVICIOS
// =====================================================

app.MapGet("/api/Servicios", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            id = 1,
            codigo = "S001",
            nombre = "Alquiler de cancha",
            categoria = "Principal",
            precio = 80.00,
            estado = "Disponible",
            descripcion = "Alquiler de cancha de fútbol por una hora.",
            imagen = "https://images.unsplash.com/photo-1553778263-73a83bab9b0c"
        },

        new
        {
            id = 2,
            codigo = "S002",
            nombre = "Iluminación",
            categoria = "Adicional",
            precio = 20.00,
            estado = "Disponible",
            descripcion = "Servicio de iluminación para partidos nocturnos.",
            imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55"
        },

        new
        {
            id = 3,
            codigo = "S003",
            nombre = "Vestuarios",
            categoria = "Adicional",
            precio = 10.00,
            estado = "Disponible",
            descripcion = "Uso de vestuarios para los jugadores.",
            imagen = "https://images.unsplash.com/photo-1518609878373-06d740f60d8b"
        },

        new
        {
            id = 4,
            codigo = "S004",
            nombre = "Estacionamiento",
            categoria = "Adicional",
            precio = 5.00,
            estado = "Disponible",
            descripcion = "Espacio de estacionamiento para los clientes.",
            imagen = "https://images.unsplash.com/photo-1506521781263-d8422e82f27a"
        },

        new
        {
            id = 5,
            codigo = "S005",
            nombre = "Campeonatos",
            categoria = "Eventos",
            precio = 150.00,
            estado = "Disponible",
            descripcion = "Organización de campeonatos y torneos de fútbol.",
            imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55"
        },

        new
        {
            id = 6,
            codigo = "S006",
            nombre = "Entrenamientos",
            categoria = "Eventos",
            precio = 70.00,
            estado = "Disponible",
            descripcion = "Espacios para entrenamientos deportivos.",
            imagen = "https://images.unsplash.com/photo-1431324155629-1a6deb1dec8d"
        }
    });
});


// =====================================================
// RESERVAS
// =====================================================

app.MapGet("/api/Reservas", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            id = 1,
            codigo = "R001",
            cliente = "Carlos Mendoza",
            fecha = "2026-10-02",
            hora = "12:00",
            cancha = "Cancha Principal",
            tipoCancha = "Fútbol 7",
            estado = "Confirmada",
            precio = 80.00,
            duracion = 60
        },

        new
        {
            id = 2,
            codigo = "R002",
            cliente = "Luis Torres",
            fecha = "2026-10-02",
            hora = "18:00",
            cancha = "Cancha Premium",
            tipoCancha = "Fútbol 7",
            estado = "Confirmada",
            precio = 100.00,
            duracion = 60
        },

        new
        {
            id = 3,
            codigo = "R003",
            cliente = "Miguel Flores",
            fecha = "2026-10-03",
            hora = "16:00",
            cancha = "Cancha Principal",
            tipoCancha = "Fútbol 7",
            estado = "Confirmada",
            precio = 80.00,
            duracion = 60
        }
    });
});


// =====================================================
// PUERTO PARA RENDER
// =====================================================

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");