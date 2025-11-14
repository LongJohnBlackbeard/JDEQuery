using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12002 - .
/// </summary>
public class F12002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDCO.
        /// </summary>
        public const string FDCO = "FDCO";

        /// <summary>
        /// FDDAOB.
        /// </summary>
        public const string FDDAOB = "FDDAOB";

        /// <summary>
        /// FDDASB.
        /// </summary>
        public const string FDDASB = "FDDASB";

        /// <summary>
        /// FDACL1.
        /// </summary>
        public const string FDACL1 = "FDACL1";

        /// <summary>
        /// FDACL2.
        /// </summary>
        public const string FDACL2 = "FDACL2";

        /// <summary>
        /// FDDMCU.
        /// </summary>
        public const string FDDMCU = "FDDMCU";

        /// <summary>
        /// FDDOBJ.
        /// </summary>
        public const string FDDOBJ = "FDDOBJ";

        /// <summary>
        /// FDDSUB.
        /// </summary>
        public const string FDDSUB = "FDDSUB";

        /// <summary>
        /// FDXMCU.
        /// </summary>
        public const string FDXMCU = "FDXMCU";

        /// <summary>
        /// FDXOBJ.
        /// </summary>
        public const string FDXOBJ = "FDXOBJ";

        /// <summary>
        /// FDXSUB.
        /// </summary>
        public const string FDXSUB = "FDXSUB";

        /// <summary>
        /// FDRMCU.
        /// </summary>
        public const string FDRMCU = "FDRMCU";

        /// <summary>
        /// FDROBJ.
        /// </summary>
        public const string FDROBJ = "FDROBJ";

        /// <summary>
        /// FDRSUB.
        /// </summary>
        public const string FDRSUB = "FDRSUB";

        /// <summary>
        /// FDLCT.
        /// </summary>
        public const string FDLCT = "FDLCT";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDUPMJ.
        /// </summary>
        public const string FDUPMJ = "FDUPMJ";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDUPMT.
        /// </summary>
        public const string FDUPMT = "FDUPMT";

        /// <summary>
        /// FDSBL.
        /// </summary>
        public const string FDSBL = "FDSBL";

        /// <summary>
        /// FDSBLT.
        /// </summary>
        public const string FDSBLT = "FDSBLT";

        /// <summary>
        /// FDSBDC.
        /// </summary>
        public const string FDSBDC = "FDSBDC";

        /// <summary>
        /// FDEFTB.
        /// </summary>
        public const string FDEFTB = "FDEFTB";

        /// <summary>
        /// FDEFTE.
        /// </summary>
        public const string FDEFTE = "FDEFTE";
    }

    /// <inheritdoc />
    public override string TableName => "F12002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDCO", "FDCO", JdeDataType.String, 10, true, true),
        new JdeField("FDDAOB", "FDDAOB", JdeDataType.String, 12, true, true),
        new JdeField("FDDASB", "FDDASB", JdeDataType.String, 16, true, true),
        new JdeField("FDACL1", "FDACL1", JdeDataType.String, 6),
        new JdeField("FDACL2", "FDACL2", JdeDataType.String, 6),
        new JdeField("FDDMCU", "FDDMCU", JdeDataType.String, 24),
        new JdeField("FDDOBJ", "FDDOBJ", JdeDataType.String, 12),
        new JdeField("FDDSUB", "FDDSUB", JdeDataType.String, 16),
        new JdeField("FDXMCU", "FDXMCU", JdeDataType.String, 24),
        new JdeField("FDXOBJ", "FDXOBJ", JdeDataType.String, 12),
        new JdeField("FDXSUB", "FDXSUB", JdeDataType.String, 16),
        new JdeField("FDRMCU", "FDRMCU", JdeDataType.String, 24),
        new JdeField("FDROBJ", "FDROBJ", JdeDataType.String, 12),
        new JdeField("FDRSUB", "FDRSUB", JdeDataType.String, 16),
        new JdeField("FDLCT", "FDLCT", JdeDataType.Numeric),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDUPMJ", "FDUPMJ", JdeDataType.Numeric),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDUPMT", "FDUPMT", JdeDataType.Numeric),
        new JdeField("FDSBL", "FDSBL", JdeDataType.String, 16),
        new JdeField("FDSBLT", "FDSBLT", JdeDataType.String, 2),
        new JdeField("FDSBDC", "FDSBDC", JdeDataType.String, 2),
        new JdeField("FDEFTB", "FDEFTB", JdeDataType.Numeric),
        new JdeField("FDEFTE", "FDEFTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12002_0", "Primary Key on FDCO, FDDAOB, FDDASB", new[] { "FDCO", "FDDAOB", "FDDASB" }, isUnique: true, isPrimaryKey: true)
    };
}
