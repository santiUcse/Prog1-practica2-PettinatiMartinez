Usuario u1 = new Usuario("Carlos1", "bio");
Usuario u2 = new Usuario("Carlos3", "bio");
Usuario u3 = new Usuario("Carlos2", "bio");

u1.Seguir(u2);
u1.Seguir(u3);

u2.Publicar("Hola", "2026-04-14");
u3.Publicar("Post Carlos2", "2026-04-15");

u1.VerFeed();

u1.DarLike(u2.publicaciones[0]);