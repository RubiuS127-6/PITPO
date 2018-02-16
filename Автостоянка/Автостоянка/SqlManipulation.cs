using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Автостоянка
{
    class SqlManipulation
    {
        public static void Fill(DataSet ds, object da, DataTable dt)
        {
            var mFill = da.GetType().GetMethods()
                .FirstOrDefault(q => q.Name == "Fill" && q.GetParameters().Any(p => p.ParameterType.IsSubclassOf(typeof(DataTable))));
            if (mFill == null) return;

            mFill.Invoke(da, new[] { dt });
        }
        public static void Update(DataSet ds, object da, DataTable dt)
        {
            if (!ds.HasChanges()) return;
            var mUpdate = da.GetType().GetMethods()
                .FirstOrDefault(q => q.Name == "Update" && q.GetParameters().Any(p => p.ParameterType.IsSubclassOf(typeof(DataTable))));
            if (mUpdate == null) return;

            mUpdate.Invoke(da, new[] { dt });
            Fill(ds, da, dt);
        }
    }
}
