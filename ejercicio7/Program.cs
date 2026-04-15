using System;

Plataforma p = new Plataforma();

Curso c1 = new Curso("C#", "no sabe nada", 10, 2);
Curso c2 = new Curso("POO", "Intermedio", 8, 2);

Usuario u1 = new Usuario("venjamin", "venjamin@gmail.com");
Usuario u2 = new Usuario("maria", "maria@gmail.com");

p.Inscribir(u1, c1);
p.Inscribir(u2, c1);

p.ListarUsuarios(c1);

Console.WriteLine("Hora venjamin: " + p.HorasTotales(u1));

p.DarDeBaja(u1, c1);

p.ListarUsuarios(c1);