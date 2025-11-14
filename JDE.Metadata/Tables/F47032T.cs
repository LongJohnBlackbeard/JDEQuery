using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47032T - .
/// </summary>
public class F47032T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZARTG.
        /// </summary>
        public const string SZARTG = "SZARTG";

        /// <summary>
        /// SZASN.
        /// </summary>
        public const string SZASN = "SZASN";

        /// <summary>
        /// SZBALU.
        /// </summary>
        public const string SZBALU = "SZBALU";

        /// <summary>
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

        /// <summary>
        /// SZCATN.
        /// </summary>
        public const string SZCATN = "SZCATN";

        /// <summary>
        /// SZCHID.
        /// </summary>
        public const string SZCHID = "SZCHID";

        /// <summary>
        /// SZCHMJ.
        /// </summary>
        public const string SZCHMJ = "SZCHMJ";

        /// <summary>
        /// SZCHT.
        /// </summary>
        public const string SZCHT = "SZCHT";

        /// <summary>
        /// SZCLVL.
        /// </summary>
        public const string SZCLVL = "SZCLVL";

        /// <summary>
        /// SZCPNT.
        /// </summary>
        public const string SZCPNT = "SZCPNT";

        /// <summary>
        /// SZCRMD.
        /// </summary>
        public const string SZCRMD = "SZCRMD";

        /// <summary>
        /// SZCTAM.
        /// </summary>
        public const string SZCTAM = "SZCTAM";

        /// <summary>
        /// SZDCD.
        /// </summary>
        public const string SZDCD = "SZDCD";

        /// <summary>
        /// SZDCP.
        /// </summary>
        public const string SZDCP = "SZDCP";

        /// <summary>
        /// SZDRQT.
        /// </summary>
        public const string SZDRQT = "SZDRQT";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZFTRL.
        /// </summary>
        public const string SZFTRL = "SZFTRL";

        /// <summary>
        /// SZKTLN.
        /// </summary>
        public const string SZKTLN = "SZKTLN";

        /// <summary>
        /// SZMATC.
        /// </summary>
        public const string SZMATC = "SZMATC";

        /// <summary>
        /// SZMLNM.
        /// </summary>
        public const string SZMLNM = "SZMLNM";

        /// <summary>
        /// SZNDTP.
        /// </summary>
        public const string SZNDTP = "SZNDTP";

        /// <summary>
        /// SZPRGR.
        /// </summary>
        public const string SZPRGR = "SZPRGR";

        /// <summary>
        /// SZPXDD.
        /// </summary>
        public const string SZPXDD = "SZPXDD";

        /// <summary>
        /// SZPXDM.
        /// </summary>
        public const string SZPXDM = "SZPXDM";

        /// <summary>
        /// SZRSHT.
        /// </summary>
        public const string SZRSHT = "SZRSHT";

        /// <summary>
        /// SZTX.
        /// </summary>
        public const string SZTX = "SZTX";

        /// <summary>
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZEDOC.
        /// </summary>
        public const string SZEDOC = "SZEDOC";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZEKCO.
        /// </summary>
        public const string SZEKCO = "SZEKCO";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";
    }

    /// <inheritdoc />
    public override string TableName => "F47032T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZARTG", "SZARTG", JdeDataType.String, 24),
        new JdeField("SZASN", "SZASN", JdeDataType.String, 16),
        new JdeField("SZBALU", "SZBALU", JdeDataType.String, 2),
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZCATN", "SZCATN", JdeDataType.String, 16),
        new JdeField("SZCHID", "SZCHID", JdeDataType.String, 20),
        new JdeField("SZCHMJ", "SZCHMJ", JdeDataType.Numeric),
        new JdeField("SZCHT", "SZCHT", JdeDataType.Numeric),
        new JdeField("SZCLVL", "SZCLVL", JdeDataType.String, 6),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZCRMD", "SZCRMD", JdeDataType.String, 2),
        new JdeField("SZCTAM", "SZCTAM", JdeDataType.Numeric),
        new JdeField("SZDCD", "SZDCD", JdeDataType.Numeric),
        new JdeField("SZDCP", "SZDCP", JdeDataType.Numeric),
        new JdeField("SZDRQT", "SZDRQT", JdeDataType.Numeric),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZFTRL", "SZFTRL", JdeDataType.Numeric),
        new JdeField("SZKTLN", "SZKTLN", JdeDataType.Numeric),
        new JdeField("SZMATC", "SZMATC", JdeDataType.String, 2),
        new JdeField("SZMLNM", "SZMLNM", JdeDataType.String, 80),
        new JdeField("SZNDTP", "SZNDTP", JdeDataType.Numeric),
        new JdeField("SZPRGR", "SZPRGR", JdeDataType.String, 16),
        new JdeField("SZPXDD", "SZPXDD", JdeDataType.Numeric),
        new JdeField("SZPXDM", "SZPXDM", JdeDataType.Numeric),
        new JdeField("SZRSHT", "SZRSHT", JdeDataType.Numeric),
        new JdeField("SZTX", "SZTX", JdeDataType.String, 2),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZEDOC", "SZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SZEKCO", "SZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47032T_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
