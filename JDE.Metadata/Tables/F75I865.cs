using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I865 - .
/// </summary>
public class F75I865 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPDOC.
        /// </summary>
        public const string TPDOC = "TPDOC";

        /// <summary>
        /// TPDCT.
        /// </summary>
        public const string TPDCT = "TPDCT";

        /// <summary>
        /// TPKCO.
        /// </summary>
        public const string TPKCO = "TPKCO";

        /// <summary>
        /// TPI75CHNO.
        /// </summary>
        public const string TPI75CHNO = "TPI75CHNO";

        /// <summary>
        /// TPI75PYD.
        /// </summary>
        public const string TPI75PYD = "TPI75PYD";

        /// <summary>
        /// TPANI.
        /// </summary>
        public const string TPANI = "TPANI";

        /// <summary>
        /// TPI75TAUT.
        /// </summary>
        public const string TPI75TAUT = "TPI75TAUT";

        /// <summary>
        /// TPI75CHQN.
        /// </summary>
        public const string TPI75CHQN = "TPI75CHQN";

        /// <summary>
        /// TPI75BSR.
        /// </summary>
        public const string TPI75BSR = "TPI75BSR";

        /// <summary>
        /// TPI75TSAMT.
        /// </summary>
        public const string TPI75TSAMT = "TPI75TSAMT";

        /// <summary>
        /// TPI75TSPLA.
        /// </summary>
        public const string TPI75TSPLA = "TPI75TSPLA";

        /// <summary>
        /// TPAN8.
        /// </summary>
        public const string TPAN8 = "TPAN8";

        /// <summary>
        /// TPMCU.
        /// </summary>
        public const string TPMCU = "TPMCU";

        /// <summary>
        /// TPICU.
        /// </summary>
        public const string TPICU = "TPICU";

        /// <summary>
        /// TPICUT.
        /// </summary>
        public const string TPICUT = "TPICUT";

        /// <summary>
        /// TPUSER.
        /// </summary>
        public const string TPUSER = "TPUSER";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";

        /// <summary>
        /// TPJOBN.
        /// </summary>
        public const string TPJOBN = "TPJOBN";

        /// <summary>
        /// TPUPMJ.
        /// </summary>
        public const string TPUPMJ = "TPUPMJ";

        /// <summary>
        /// TPUPMT.
        /// </summary>
        public const string TPUPMT = "TPUPMT";

        /// <summary>
        /// TPYFUTDT.
        /// </summary>
        public const string TPYFUTDT = "TPYFUTDT";

        /// <summary>
        /// TPFFU4.
        /// </summary>
        public const string TPFFU4 = "TPFFU4";

        /// <summary>
        /// TPFUT3.
        /// </summary>
        public const string TPFUT3 = "TPFUT3";

        /// <summary>
        /// TPX2.
        /// </summary>
        public const string TPX2 = "TPX2";

        /// <summary>
        /// TPFUTCH1.
        /// </summary>
        public const string TPFUTCH1 = "TPFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I865";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPDOC", "TPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TPDCT", "TPDCT", JdeDataType.String, 4, true, true),
        new JdeField("TPKCO", "TPKCO", JdeDataType.String, 10, true, true),
        new JdeField("TPI75CHNO", "TPI75CHNO", JdeDataType.String, 120),
        new JdeField("TPI75PYD", "TPI75PYD", JdeDataType.Numeric),
        new JdeField("TPANI", "TPANI", JdeDataType.String, 58),
        new JdeField("TPI75TAUT", "TPI75TAUT", JdeDataType.Numeric),
        new JdeField("TPI75CHQN", "TPI75CHQN", JdeDataType.Numeric),
        new JdeField("TPI75BSR", "TPI75BSR", JdeDataType.Numeric),
        new JdeField("TPI75TSAMT", "TPI75TSAMT", JdeDataType.Numeric),
        new JdeField("TPI75TSPLA", "TPI75TSPLA", JdeDataType.Numeric),
        new JdeField("TPAN8", "TPAN8", JdeDataType.Numeric),
        new JdeField("TPMCU", "TPMCU", JdeDataType.String, 24),
        new JdeField("TPICU", "TPICU", JdeDataType.Numeric),
        new JdeField("TPICUT", "TPICUT", JdeDataType.String, 4),
        new JdeField("TPUSER", "TPUSER", JdeDataType.String, 20),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20),
        new JdeField("TPUPMJ", "TPUPMJ", JdeDataType.Numeric),
        new JdeField("TPUPMT", "TPUPMT", JdeDataType.Numeric),
        new JdeField("TPYFUTDT", "TPYFUTDT", JdeDataType.Numeric),
        new JdeField("TPFFU4", "TPFFU4", JdeDataType.Numeric),
        new JdeField("TPFUT3", "TPFUT3", JdeDataType.String, 60),
        new JdeField("TPX2", "TPX2", JdeDataType.String, 2),
        new JdeField("TPFUTCH1", "TPFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I865_0", "Primary Key on TPDOC, TPDCT, TPKCO", new[] { "TPDOC", "TPDCT", "TPKCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I865_2", "Index on TPICU, TPICUT", new[] { "TPICU", "TPICUT" }),
        new JdeIndex("F75I865_3", "Index on TPDOC, TPKCO, TPAN8, TPMCU", new[] { "TPDOC", "TPKCO", "TPAN8", "TPMCU" })
    };
}
