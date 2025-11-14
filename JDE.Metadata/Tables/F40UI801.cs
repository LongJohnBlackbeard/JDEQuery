using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40UI801 - .
/// </summary>
public class F40UI801 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZBCTID.
        /// </summary>
        public const string ZBCTID = "ZBCTID";

        /// <summary>
        /// ZBJOBS.
        /// </summary>
        public const string ZBJOBS = "ZBJOBS";

        /// <summary>
        /// ZBNLIN.
        /// </summary>
        public const string ZBNLIN = "ZBNLIN";

        /// <summary>
        /// ZBDOCO.
        /// </summary>
        public const string ZBDOCO = "ZBDOCO";

        /// <summary>
        /// ZBDCTO.
        /// </summary>
        public const string ZBDCTO = "ZBDCTO";

        /// <summary>
        /// ZBKCOO.
        /// </summary>
        public const string ZBKCOO = "ZBKCOO";

        /// <summary>
        /// ZBLNID.
        /// </summary>
        public const string ZBLNID = "ZBLNID";

        /// <summary>
        /// ZBFILE.
        /// </summary>
        public const string ZBFILE = "ZBFILE";

        /// <summary>
        /// ZBSHNO.
        /// </summary>
        public const string ZBSHNO = "ZBSHNO";

        /// <summary>
        /// ZBDOC.
        /// </summary>
        public const string ZBDOC = "ZBDOC";

        /// <summary>
        /// ZBDCT.
        /// </summary>
        public const string ZBDCT = "ZBDCT";

        /// <summary>
        /// ZBKCO.
        /// </summary>
        public const string ZBKCO = "ZBKCO";

        /// <summary>
        /// ZBSFX.
        /// </summary>
        public const string ZBSFX = "ZBSFX";

        /// <summary>
        /// ZBJELN.
        /// </summary>
        public const string ZBJELN = "ZBJELN";

        /// <summary>
        /// ZBALPH.
        /// </summary>
        public const string ZBALPH = "ZBALPH";

        /// <summary>
        /// ZBALP1.
        /// </summary>
        public const string ZBALP1 = "ZBALP1";

        /// <summary>
        /// ZBDTAI.
        /// </summary>
        public const string ZBDTAI = "ZBDTAI";
    }

    /// <inheritdoc />
    public override string TableName => "F40UI801";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZBCTID", "ZBCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZBJOBS", "ZBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBNLIN", "ZBNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBDOCO", "ZBDOCO", JdeDataType.Numeric),
        new JdeField("ZBDCTO", "ZBDCTO", JdeDataType.String, 4),
        new JdeField("ZBKCOO", "ZBKCOO", JdeDataType.String, 10),
        new JdeField("ZBLNID", "ZBLNID", JdeDataType.Numeric),
        new JdeField("ZBFILE", "ZBFILE", JdeDataType.String, 20),
        new JdeField("ZBSHNO", "ZBSHNO", JdeDataType.String, 20),
        new JdeField("ZBDOC", "ZBDOC", JdeDataType.Numeric),
        new JdeField("ZBDCT", "ZBDCT", JdeDataType.String, 4),
        new JdeField("ZBKCO", "ZBKCO", JdeDataType.String, 10),
        new JdeField("ZBSFX", "ZBSFX", JdeDataType.String, 6),
        new JdeField("ZBJELN", "ZBJELN", JdeDataType.Numeric),
        new JdeField("ZBALPH", "ZBALPH", JdeDataType.String, 80),
        new JdeField("ZBALP1", "ZBALP1", JdeDataType.String, 80),
        new JdeField("ZBDTAI", "ZBDTAI", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40UI801_0", "Primary Key on ZBCTID, ZBJOBS, ZBNLIN", new[] { "ZBCTID", "ZBJOBS", "ZBNLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40UI801_2", "Index on ZBDOCO, ZBDCTO, ZBKCOO, ZBLNID", new[] { "ZBDOCO", "ZBDCTO", "ZBKCOO", "ZBLNID" })
    };
}
