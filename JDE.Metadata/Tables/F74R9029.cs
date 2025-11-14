using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9029 - .
/// </summary>
public class F74R9029 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OAR74REPN.
        /// </summary>
        public const string OAR74REPN = "OAR74REPN";

        /// <summary>
        /// OAR74RROW.
        /// </summary>
        public const string OAR74RROW = "OAR74RROW";

        /// <summary>
        /// OAR74RCOL.
        /// </summary>
        public const string OAR74RCOL = "OAR74RCOL";

        /// <summary>
        /// OAAID.
        /// </summary>
        public const string OAAID = "OAAID";

        /// <summary>
        /// OACO.
        /// </summary>
        public const string OACO = "OACO";

        /// <summary>
        /// OAFY.
        /// </summary>
        public const string OAFY = "OAFY";

        /// <summary>
        /// OALT.
        /// </summary>
        public const string OALT = "OALT";

        /// <summary>
        /// OASBL.
        /// </summary>
        public const string OASBL = "OASBL";

        /// <summary>
        /// OASBLT.
        /// </summary>
        public const string OASBLT = "OASBLT";

        /// <summary>
        /// OACRCD.
        /// </summary>
        public const string OACRCD = "OACRCD";

        /// <summary>
        /// OAMCU.
        /// </summary>
        public const string OAMCU = "OAMCU";

        /// <summary>
        /// OAOBJ.
        /// </summary>
        public const string OAOBJ = "OAOBJ";

        /// <summary>
        /// OASUB.
        /// </summary>
        public const string OASUB = "OASUB";

        /// <summary>
        /// OAAA.
        /// </summary>
        public const string OAAA = "OAAA";

        /// <summary>
        /// OAAA1.
        /// </summary>
        public const string OAAA1 = "OAAA1";

        /// <summary>
        /// OAAA2.
        /// </summary>
        public const string OAAA2 = "OAAA2";

        /// <summary>
        /// OAAA3.
        /// </summary>
        public const string OAAA3 = "OAAA3";

        /// <summary>
        /// OAEV01.
        /// </summary>
        public const string OAEV01 = "OAEV01";

        /// <summary>
        /// OAURAB.
        /// </summary>
        public const string OAURAB = "OAURAB";

        /// <summary>
        /// OAURAT.
        /// </summary>
        public const string OAURAT = "OAURAT";

        /// <summary>
        /// OAURDT.
        /// </summary>
        public const string OAURDT = "OAURDT";

        /// <summary>
        /// OAURCD.
        /// </summary>
        public const string OAURCD = "OAURCD";

        /// <summary>
        /// OAURRF.
        /// </summary>
        public const string OAURRF = "OAURRF";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";

        /// <summary>
        /// OAJOBN.
        /// </summary>
        public const string OAJOBN = "OAJOBN";

        /// <summary>
        /// OAUPMJ.
        /// </summary>
        public const string OAUPMJ = "OAUPMJ";

        /// <summary>
        /// OAUPMT.
        /// </summary>
        public const string OAUPMT = "OAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9029";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OAR74REPN", "OAR74REPN", JdeDataType.String, 40, true, true),
        new JdeField("OAR74RROW", "OAR74RROW", JdeDataType.String, 8, true, true),
        new JdeField("OAR74RCOL", "OAR74RCOL", JdeDataType.String, 8, true, true),
        new JdeField("OAAID", "OAAID", JdeDataType.String, 16, true, true),
        new JdeField("OACO", "OACO", JdeDataType.String, 10, true, true),
        new JdeField("OAFY", "OAFY", JdeDataType.Numeric, null, true, true),
        new JdeField("OALT", "OALT", JdeDataType.String, 4, true, true),
        new JdeField("OASBL", "OASBL", JdeDataType.String, 16, true, true),
        new JdeField("OASBLT", "OASBLT", JdeDataType.String, 2, true, true),
        new JdeField("OACRCD", "OACRCD", JdeDataType.String, 6, true, true),
        new JdeField("OAMCU", "OAMCU", JdeDataType.String, 24),
        new JdeField("OAOBJ", "OAOBJ", JdeDataType.String, 12),
        new JdeField("OASUB", "OASUB", JdeDataType.String, 16),
        new JdeField("OAAA", "OAAA", JdeDataType.Numeric),
        new JdeField("OAAA1", "OAAA1", JdeDataType.Numeric),
        new JdeField("OAAA2", "OAAA2", JdeDataType.Numeric),
        new JdeField("OAAA3", "OAAA3", JdeDataType.Numeric),
        new JdeField("OAEV01", "OAEV01", JdeDataType.String, 2),
        new JdeField("OAURAB", "OAURAB", JdeDataType.Numeric),
        new JdeField("OAURAT", "OAURAT", JdeDataType.Numeric),
        new JdeField("OAURDT", "OAURDT", JdeDataType.Numeric),
        new JdeField("OAURCD", "OAURCD", JdeDataType.String, 4),
        new JdeField("OAURRF", "OAURRF", JdeDataType.String, 30),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20),
        new JdeField("OAJOBN", "OAJOBN", JdeDataType.String, 20),
        new JdeField("OAUPMJ", "OAUPMJ", JdeDataType.Numeric),
        new JdeField("OAUPMT", "OAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9029_0", "Primary Key on OAR74REPN, OAR74RROW, OAR74RCOL, OAAID, OACO, OAFY, OALT, OASBL, OASBLT, OACRCD", new[] { "OAR74REPN", "OAR74RROW", "OAR74RCOL", "OAAID", "OACO", "OAFY", "OALT", "OASBL", "OASBLT", "OACRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
