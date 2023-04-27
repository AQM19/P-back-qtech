﻿using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Estadistica
{
    public long Id { get; set; }

    public long Idusuario { get; set; }

    public int NumeroTerrarios { get; set; }

    public long NumeroIniciosSesion { get; set; }

    public float PuntuacionMediaTerrarios { get; set; }

    public int NumeroEspecies { get; set; }

    public int NumeroAnimales { get; set; }

    public int NumeroPlantas { get; set; }

    public int NumeroHongos { get; set; }

    public int NumeroAmigos { get; set; }

    public int NumeroLogros { get; set; }

    public virtual Usuario IdusuarioNavigation { get; set; } = null!;
}