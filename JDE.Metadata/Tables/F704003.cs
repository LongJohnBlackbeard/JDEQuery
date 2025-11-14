using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704003 - .
/// </summary>
public class F704003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDK70BTXC.
        /// </summary>
        public const string PDK70BTXC = "PDK70BTXC";

        /// <summary>
        /// PDCO.
        /// </summary>
        public const string PDCO = "PDCO";

        /// <summary>
        /// PDTX2.
        /// </summary>
        public const string PDTX2 = "PDTX2";

        /// <summary>
        /// PDK70BCNC.
        /// </summary>
        public const string PDK70BCNC = "PDK70BCNC";

        /// <summary>
        /// PDK70BJRD.
        /// </summary>
        public const string PDK70BJRD = "PDK70BJRD";

        /// <summary>
        /// PDAN8.
        /// </summary>
        public const string PDAN8 = "PDAN8";

        /// <summary>
        /// PDTAX.
        /// </summary>
        public const string PDTAX = "PDTAX";

        /// <summary>
        /// PDCTRY.
        /// </summary>
        public const string PDCTRY = "PDCTRY";

        /// <summary>
        /// PDFY.
        /// </summary>
        public const string PDFY = "PDFY";

        /// <summary>
        /// PDPN.
        /// </summary>
        public const string PDPN = "PDPN";

        /// <summary>
        /// PDK70BCAB.
        /// </summary>
        public const string PDK70BCAB = "PDK70BCAB";

        /// <summary>
        /// PDK70BCAW.
        /// </summary>
        public const string PDK70BCAW = "PDK70BCAW";

        /// <summary>
        /// PDK70BTAP.
        /// </summary>
        public const string PDK70BTAP = "PDK70BTAP";

        /// <summary>
        /// PDBCRC.
        /// </summary>
        public const string PDBCRC = "PDBCRC";

        /// <summary>
        /// PDURC1.
        /// </summary>
        public const string PDURC1 = "PDURC1";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F704003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDK70BTXC", "PDK70BTXC", JdeDataType.String, 20, true, true),
        new JdeField("PDCO", "PDCO", JdeDataType.String, 10, true, true),
        new JdeField("PDTX2", "PDTX2", JdeDataType.String, 40, true, true),
        new JdeField("PDK70BCNC", "PDK70BCNC", JdeDataType.String, 20, true, true),
        new JdeField("PDK70BJRD", "PDK70BJRD", JdeDataType.String, 8, true, true),
        new JdeField("PDAN8", "PDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PDTAX", "PDTAX", JdeDataType.String, 40, true, true),
        new JdeField("PDCTRY", "PDCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("PDFY", "PDFY", JdeDataType.Numeric, null, true, true),
        new JdeField("PDPN", "PDPN", JdeDataType.Numeric, null, true, true),
        new JdeField("PDK70BCAB", "PDK70BCAB", JdeDataType.Numeric),
        new JdeField("PDK70BCAW", "PDK70BCAW", JdeDataType.Numeric),
        new JdeField("PDK70BTAP", "PDK70BTAP", JdeDataType.Numeric),
        new JdeField("PDBCRC", "PDBCRC", JdeDataType.String, 6),
        new JdeField("PDURC1", "PDURC1", JdeDataType.String, 6),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704003_0", "Primary Key on PDK70BTXC, PDCO, PDTX2, PDK70BCNC, PDK70BJRD, PDAN8, PDTAX, PDCTRY, PDFY, PDPN", new[] { "PDK70BTXC", "PDCO", "PDTX2", "PDK70BCNC", "PDK70BJRD", "PDAN8", "PDTAX", "PDCTRY", "PDFY", "PDPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F704003_2", "Index on PDK70BTXC, PDCTRY, PDFY, PDPN, PDTX2, PDTAX, PDK70BCNC", new[] { "PDK70BTXC", "PDCTRY", "PDFY", "PDPN", "PDTX2", "PDTAX", "PDK70BCNC" }),
        new JdeIndex("F704003_3", "Index on PDK70BTXC, PDCTRY, PDFY, PDPN, PDCO, PDAN8, PDK70BCNC", new[] { "PDK70BTXC", "PDCTRY", "PDFY", "PDPN", "PDCO", "PDAN8", "PDK70BCNC" }),
        new JdeIndex("F704003_4", "Index on PDK70BTXC, PDTX2, PDTAX, PDCTRY, PDFY, PDPN", new[] { "PDK70BTXC", "PDTX2", "PDTAX", "PDCTRY", "PDFY", "PDPN" })
    };
}
