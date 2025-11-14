using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B901 - .
/// </summary>
public class F76B901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BAUKID.
        /// </summary>
        public const string BAUKID = "BAUKID";

        /// <summary>
        /// BAMCU.
        /// </summary>
        public const string BAMCU = "BAMCU";

        /// <summary>
        /// BAOBJ.
        /// </summary>
        public const string BAOBJ = "BAOBJ";

        /// <summary>
        /// BASUB.
        /// </summary>
        public const string BASUB = "BASUB";

        /// <summary>
        /// BASBL.
        /// </summary>
        public const string BASBL = "BASBL";

        /// <summary>
        /// BASBLT.
        /// </summary>
        public const string BASBLT = "BASBLT";

        /// <summary>
        /// BADGJ.
        /// </summary>
        public const string BADGJ = "BADGJ";

        /// <summary>
        /// BAATYB.
        /// </summary>
        public const string BAATYB = "BAATYB";

        /// <summary>
        /// BAOBJ0.
        /// </summary>
        public const string BAOBJ0 = "BAOBJ0";

        /// <summary>
        /// BASUB0.
        /// </summary>
        public const string BASUB0 = "BASUB0";

        /// <summary>
        /// BADL01.
        /// </summary>
        public const string BADL01 = "BADL01";

        /// <summary>
        /// BARDOR.
        /// </summary>
        public const string BARDOR = "BARDOR";

        /// <summary>
        /// BATORG.
        /// </summary>
        public const string BATORG = "BATORG";

        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAPID.
        /// </summary>
        public const string BAPID = "BAPID";

        /// <summary>
        /// BAJOBN.
        /// </summary>
        public const string BAJOBN = "BAJOBN";

        /// <summary>
        /// BAUPMJ.
        /// </summary>
        public const string BAUPMJ = "BAUPMJ";

        /// <summary>
        /// BAUPMT.
        /// </summary>
        public const string BAUPMT = "BAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAUKID", "BAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BAMCU", "BAMCU", JdeDataType.String, 24),
        new JdeField("BAOBJ", "BAOBJ", JdeDataType.String, 12),
        new JdeField("BASUB", "BASUB", JdeDataType.String, 16),
        new JdeField("BASBL", "BASBL", JdeDataType.String, 16),
        new JdeField("BASBLT", "BASBLT", JdeDataType.String, 2),
        new JdeField("BADGJ", "BADGJ", JdeDataType.Numeric),
        new JdeField("BAATYB", "BAATYB", JdeDataType.String, 2),
        new JdeField("BAOBJ0", "BAOBJ0", JdeDataType.String, 12),
        new JdeField("BASUB0", "BASUB0", JdeDataType.String, 16),
        new JdeField("BADL01", "BADL01", JdeDataType.String, 60),
        new JdeField("BARDOR", "BARDOR", JdeDataType.String, 2),
        new JdeField("BATORG", "BATORG", JdeDataType.String, 20),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric),
        new JdeField("BAUPMT", "BAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B901_0", "Primary Key on BAUKID", new[] { "BAUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B901_2", "Unique Index on BAMCU, BAOBJ, BASUB, BASBL, BASBLT", new[] { "BAMCU", "BAOBJ", "BASUB", "BASBL", "BASBLT" }, isUnique: true)
    };
}
