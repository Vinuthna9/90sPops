
:root{
  --accent:#2e3192;
  --lime:#cfe31b;
  --purple:#7b2ea6;
  --muted:#f6f6f6;
  --card: rgba(255,255,255,0.95);
  font-family: 'Segoe UI', Roboto, system-ui, -apple-system, 'Helvetica Neue', Arial;
}
*{box-sizing:border-box}
html,body{height:100%;margin:0}
body{background:linear-gradient(180deg,var(--muted),#fff);color:#222;line-height:1.4}

/* Top hero */
.hero{
  background: linear-gradient(180deg,#2e3192 0%, #2e3192 8%, rgba(46,49,146,0.0) 35%), var(--lime);
  color:white; padding:48px 8%; display:flex; gap:32px; align-items:center; justify-content:space-between; flex-wrap:wrap;
}
.hero .brand{
  max-width:680px;
}
.logo{
  display:flex; align-items:flex-start; gap:16px;
}
.logo img{width:96px; height:auto; border-radius:8px; box-shadow:0 6px 18px rgba(0,0,0,0.18); object-fit:cover;}
h1{font-size:48px; margin:8px 0; letter-spacing:1px; text-transform:uppercase; font-weight:800; color:#fff}
p.lead{font-size:18px; margin:6px 0 18px; color:#fff}
.cta{display:inline-flex; gap:12px; align-items:center}
.btn{background:var(--accent); color:white; padding:12px 18px; border-radius:12px; text-decoration:none; font-weight:700}
.phone{background:#fff3; padding:10px 14px; border-radius:10px; color:white; font-weight:700}

.hero-visual{flex:0 0 420px; text-align:center}
.hero-visual img{width:100%; max-width:420px; border-radius:10px; box-shadow:0 12px 40px rgba(0,0,0,0.25); object-fit:cover; height:auto;}

/* Content container */
.container{max-width:1200px; margin:32px auto; padding:0 20px}

/* Signature flavors */
.section{padding:24px 0}
.section h2{font-size:36px; margin:6px 0 18px; color:var(--accent)}
.flavors{display:grid; grid-template-columns:repeat(auto-fit, minmax(240px,1fr)); gap:18px}
.flavor-card{background:var(--card); padding:18px; border-radius:14px; box-shadow:0 6px 20px rgba(0,0,0,0.08); display:flex; gap:12px; align-items:center}
.flavor-card img{width:96px; height:96px; object-fit:cover; border-radius:8px}
.flavor-card h3{margin:4px 0 6px}
.flavor-card p{margin:0; color:#444}

/* Gallery */
.gallery{display:grid; grid-template-columns:2fr 1fr; gap:12px}
.gallery img{width:100%; height:100%; object-fit:cover; border-radius:12px;}

/* About */
.about{display:flex; gap:20px; align-items:center; flex-wrap:wrap}
.about .text{flex:1; min-width:250px}
.about img{width:100%; max-width:320px; height:auto; border-radius:12px; object-fit:cover; box-shadow:0 10px 30px rgba(0,0,0,0.12)}

/* WhatsApp floating button */
.whatsapp-btn{position:fixed;bottom:20px;right:20px;width:60px;height:60px;background:#25D366;border-radius:50%;display:flex;align-items:center;justify-content:center;box-shadow:0 6px 18px rgba(0,0,0,0.2);z-index:100;transition:transform 0.2s;}
.whatsapp-btn img{width:28px;height:28px;}
.whatsapp-btn:hover{transform:scale(1.1);}

/* Contact / Footer */
footer{background:var(--accent); color:white; padding:28px 20px; border-top-left-radius:28px; border-top-right-radius:28px}
.contact-grid{display:grid; grid-template-columns:1fr 1fr; gap:14px; align-items:center}
.contact-grid .card{background:rgba(255,255,255,0.08); padding:14px; border-radius:12px}
a.contact-btn{display:inline-block; margin-top:8px; background:white; color:var(--accent); padding:10px 14px; border-radius:10px; text-decoration:none; font-weight:700}

/* small screens */
@media (max-width:820px){
  h1{font-size:34px}
  .hero{padding:28px 6%}
  .hero-visual{flex-basis:320px}
  .gallery{grid-template-columns:1fr}
  .contact-grid{grid-template-columns:1fr}
}
/* Gallery */
.gallery {
  display: flex;
  gap:12px;
  flex-wrap: wrap;
}

.gallery-large, .gallery-small {
  display: flex;
  flex-direction: column;
  gap:12px;
}

.gallery-large img {
  width:100%;
  max-width:640px;
  height:360px;
  object-fit:cover;
  border-radius:14px;
  border:4px solid #fff;
  box-shadow:0 8px 24px rgba(0,0,0,0.12);
}

.gallery-small img {
  width:100%;
  max-width:300px;
  height:180px;
  object-fit:cover;
  border-radius:14px;
  border:3px solid #fff;
  box-shadow:0 6px 20px rgba(0,0,0,0.1);
}

/* Responsive */
@media (max-width:820px) {
  .gallery {
    flex-direction: column;
  }
  .gallery-large img, .gallery-small img {
    max-width:100%;
    height:auto;
  }
  .gallery-small {
    flex-direction: row;
    gap:12px;
  }
}
