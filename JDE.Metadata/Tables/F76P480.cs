using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P480 - .
/// </summary>
public class F76P480 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVKCO.
        /// </summary>
        public const string SVKCO = "SVKCO";

        /// <summary>
        /// SVDCT.
        /// </summary>
        public const string SVDCT = "SVDCT";

        /// <summary>
        /// SVDOC.
        /// </summary>
        public const string SVDOC = "SVDOC";

        /// <summary>
        /// SVOKCO.
        /// </summary>
        public const string SVOKCO = "SVOKCO";

        /// <summary>
        /// SVODCT.
        /// </summary>
        public const string SVODCT = "SVODCT";

        /// <summary>
        /// SVODOC.
        /// </summary>
        public const string SVODOC = "SVODOC";

        /// <summary>
        /// SVP76SPDD.
        /// </summary>
        public const string SVP76SPDD = "SVP76SPDD";

        /// <summary>
        /// SVP76SPDN.
        /// </summary>
        public const string SVP76SPDN = "SVP76SPDN";

        /// <summary>
        /// SVP76SPIN.
        /// </summary>
        public const string SVP76SPIN = "SVP76SPIN";

        /// <summary>
        /// SVURAB.
        /// </summary>
        public const string SVURAB = "SVURAB";

        /// <summary>
        /// SVURDT.
        /// </summary>
        public const string SVURDT = "SVURDT";

        /// <summary>
        /// SVURC1.
        /// </summary>
        public const string SVURC1 = "SVURC1";

        /// <summary>
        /// SVURRF.
        /// </summary>
        public const string SVURRF = "SVURRF";

        /// <summary>
        /// SVUSER.
        /// </summary>
        public const string SVUSER = "SVUSER";

        /// <summary>
        /// SVPID.
        /// </summary>
        public const string SVPID = "SVPID";

        /// <summary>
        /// SVJOBN.
        /// </summary>
        public const string SVJOBN = "SVJOBN";

        /// <summary>
        /// SVUPMJ.
        /// </summary>
        public const string SVUPMJ = "SVUPMJ";

        /// <summary>
        /// SVUPMT.
        /// </summary>
        public const string SVUPMT = "SVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P480";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVKCO", "SVKCO", JdeDataType.String, 10, true, true),
        new JdeField("SVDCT", "SVDCT", JdeDataType.String, 4, true, true),
        new JdeField("SVDOC", "SVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SVOKCO", "SVOKCO", JdeDataType.String, 10),
        new JdeField("SVODCT", "SVODCT", JdeDataType.String, 4),
        new JdeField("SVODOC", "SVODOC", JdeDataType.Numeric),
        new JdeField("SVP76SPDD", "SVP76SPDD", JdeDataType.Numeric),
        new JdeField("SVP76SPDN", "SVP76SPDN", JdeDataType.String, 30),
        new JdeField("SVP76SPIN", "SVP76SPIN", JdeDataType.String, 24),
        new JdeField("SVURAB", "SVURAB", JdeDataType.Numeric),
        new JdeField("SVURDT", "SVURDT", JdeDataType.Numeric),
        new JdeField("SVURC1", "SVURC1", JdeDataType.String, 6),
        new JdeField("SVURRF", "SVURRF", JdeDataType.String, 30),
        new JdeField("SVUSER", "SVUSER", JdeDataType.String, 20),
        new JdeField("SVPID", "SVPID", JdeDataType.String, 20),
        new JdeField("SVJOBN", "SVJOBN", JdeDataType.String, 20),
        new JdeField("SVUPMJ", "SVUPMJ", JdeDataType.Numeric),
        new JdeField("SVUPMT", "SVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P480_0", "Primary Key on SVKCO, SVDCT, SVDOC", new[] { "SVKCO", "SVDCT", "SVDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76P480_2", "Index on SVOKCO, SVODCT, SVODOC", new[] { "SVOKCO", "SVODCT", "SVODOC" })
    };
}
