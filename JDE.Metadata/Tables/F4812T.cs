using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4812T - .
/// </summary>
public class F4812T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WDDOCO.
        /// </summary>
        public const string WDDOCO = "WDDOCO";

        /// <summary>
        /// WDDCTO.
        /// </summary>
        public const string WDDCTO = "WDDCTO";

        /// <summary>
        /// WDKCOO.
        /// </summary>
        public const string WDKCOO = "WDKCOO";

        /// <summary>
        /// WDCOCH.
        /// </summary>
        public const string WDCOCH = "WDCOCH";

        /// <summary>
        /// WDOPIM.
        /// </summary>
        public const string WDOPIM = "WDOPIM";

        /// <summary>
        /// WDICU.
        /// </summary>
        public const string WDICU = "WDICU";

        /// <summary>
        /// WDSBL.
        /// </summary>
        public const string WDSBL = "WDSBL";

        /// <summary>
        /// WDSBLT.
        /// </summary>
        public const string WDSBLT = "WDSBLT";

        /// <summary>
        /// WDLNID.
        /// </summary>
        public const string WDLNID = "WDLNID";

        /// <summary>
        /// WDAPPL.
        /// </summary>
        public const string WDAPPL = "WDAPPL";

        /// <summary>
        /// WDSTML.
        /// </summary>
        public const string WDSTML = "WDSTML";

        /// <summary>
        /// WDPSMA.
        /// </summary>
        public const string WDPSMA = "WDPSMA";

        /// <summary>
        /// WDFSMA.
        /// </summary>
        public const string WDFSMA = "WDFSMA";

        /// <summary>
        /// WDRTN1.
        /// </summary>
        public const string WDRTN1 = "WDRTN1";

        /// <summary>
        /// WDFTML.
        /// </summary>
        public const string WDFTML = "WDFTML";

        /// <summary>
        /// WDSMRT.
        /// </summary>
        public const string WDSMRT = "WDSMRT";

        /// <summary>
        /// WDSMRF.
        /// </summary>
        public const string WDSMRF = "WDSMRF";

        /// <summary>
        /// WDSMRP.
        /// </summary>
        public const string WDSMRP = "WDSMRP";

        /// <summary>
        /// WDSMPF.
        /// </summary>
        public const string WDSMPF = "WDSMPF";
    }

    /// <inheritdoc />
    public override string TableName => "F4812T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WDDOCO", "WDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WDDCTO", "WDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WDKCOO", "WDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WDCOCH", "WDCOCH", JdeDataType.String, 6, true, true),
        new JdeField("WDOPIM", "WDOPIM", JdeDataType.String, 30, true, true),
        new JdeField("WDICU", "WDICU", JdeDataType.Numeric, null, true, true),
        new JdeField("WDSBL", "WDSBL", JdeDataType.String, 16, true, true),
        new JdeField("WDSBLT", "WDSBLT", JdeDataType.String, 2, true, true),
        new JdeField("WDLNID", "WDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WDAPPL", "WDAPPL", JdeDataType.Numeric),
        new JdeField("WDSTML", "WDSTML", JdeDataType.Numeric),
        new JdeField("WDPSMA", "WDPSMA", JdeDataType.Numeric),
        new JdeField("WDFSMA", "WDFSMA", JdeDataType.Numeric),
        new JdeField("WDRTN1", "WDRTN1", JdeDataType.String, 6),
        new JdeField("WDFTML", "WDFTML", JdeDataType.Numeric),
        new JdeField("WDSMRT", "WDSMRT", JdeDataType.Numeric),
        new JdeField("WDSMRF", "WDSMRF", JdeDataType.Numeric),
        new JdeField("WDSMRP", "WDSMRP", JdeDataType.Numeric),
        new JdeField("WDSMPF", "WDSMPF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4812T_0", "Primary Key on WDDOCO, WDDCTO, WDKCOO, WDCOCH, WDOPIM, WDSBLT, WDSBL, WDICU, WDLNID", new[] { "WDDOCO", "WDDCTO", "WDKCOO", "WDCOCH", "WDOPIM", "WDSBLT", "WDSBL", "WDICU", "WDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
