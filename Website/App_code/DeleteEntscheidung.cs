using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für DeleteEntscheidung
/// </summary>
public class DeleteEntscheidung
{
    static bool delete;

    public void cEntscheidung(bool _delete)
    {
        delete = _delete;
    }

    public bool Delete
    {
        get
        {
            return delete;
        }
    }
}