using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return Modulo3.modulos(ModuloFirst.modulo(xs));

        //return ModuloFirst.modulo(modulo3.modulos(xs));
    }
}