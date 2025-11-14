using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T009 - .
/// </summary>
public class F75T009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DVAN8.
        /// </summary>
        public const string DVAN8 = "DVAN8";

        /// <summary>
        /// DVCO.
        /// </summary>
        public const string DVCO = "DVCO";

        /// <summary>
        /// DV75TGCT.
        /// </summary>
        public const string DV75TGCT = "DV75TGCT";

        /// <summary>
        /// DV75TSUN.
        /// </summary>
        public const string DV75TSUN = "DV75TSUN";

        /// <summary>
        /// DV75TGFC.
        /// </summary>
        public const string DV75TGFC = "DV75TGFC";

        /// <summary>
        /// DV75TFC2.
        /// </summary>
        public const string DV75TFC2 = "DV75TFC2";

        /// <summary>
        /// DV75TZTT.
        /// </summary>
        public const string DV75TZTT = "DV75TZTT";

        /// <summary>
        /// DV75TDCU.
        /// </summary>
        public const string DV75TDCU = "DV75TDCU";

        /// <summary>
        /// DV75TIBF.
        /// </summary>
        public const string DV75TIBF = "DV75TIBF";

        /// <summary>
        /// DV75TFC3.
        /// </summary>
        public const string DV75TFC3 = "DV75TFC3";

        /// <summary>
        /// DV75TFCW.
        /// </summary>
        public const string DV75TFCW = "DV75TFCW";

        /// <summary>
        /// DV75TSIT.
        /// </summary>
        public const string DV75TSIT = "DV75TSIT";

        /// <summary>
        /// DV75TSTT.
        /// </summary>
        public const string DV75TSTT = "DV75TSTT";

        /// <summary>
        /// DV75TCC4.
        /// </summary>
        public const string DV75TCC4 = "DV75TCC4";

        /// <summary>
        /// DV75TCC5.
        /// </summary>
        public const string DV75TCC5 = "DV75TCC5";

        /// <summary>
        /// DV75TCC6.
        /// </summary>
        public const string DV75TCC6 = "DV75TCC6";

        /// <summary>
        /// DVURC1.
        /// </summary>
        public const string DVURC1 = "DVURC1";

        /// <summary>
        /// DVURDT.
        /// </summary>
        public const string DVURDT = "DVURDT";

        /// <summary>
        /// DVURAT.
        /// </summary>
        public const string DVURAT = "DVURAT";

        /// <summary>
        /// DVURAB.
        /// </summary>
        public const string DVURAB = "DVURAB";

        /// <summary>
        /// DVURRF.
        /// </summary>
        public const string DVURRF = "DVURRF";

        /// <summary>
        /// DVUSER.
        /// </summary>
        public const string DVUSER = "DVUSER";

        /// <summary>
        /// DVPID.
        /// </summary>
        public const string DVPID = "DVPID";

        /// <summary>
        /// DVJOBN.
        /// </summary>
        public const string DVJOBN = "DVJOBN";

        /// <summary>
        /// DVUPMJ.
        /// </summary>
        public const string DVUPMJ = "DVUPMJ";

        /// <summary>
        /// DVTDAY.
        /// </summary>
        public const string DVTDAY = "DVTDAY";

        /// <summary>
        /// DV75TEGMD.
        /// </summary>
        public const string DV75TEGMD = "DV75TEGMD";

        /// <summary>
        /// DVYFUTDT.
        /// </summary>
        public const string DVYFUTDT = "DVYFUTDT";

        /// <summary>
        /// DVFFU4.
        /// </summary>
        public const string DVFFU4 = "DVFFU4";

        /// <summary>
        /// DVFUT3.
        /// </summary>
        public const string DVFUT3 = "DVFUT3";

        /// <summary>
        /// DVX2.
        /// </summary>
        public const string DVX2 = "DVX2";

        /// <summary>
        /// DVFUTCH1.
        /// </summary>
        public const string DVFUTCH1 = "DVFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75T009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DVAN8", "DVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DVCO", "DVCO", JdeDataType.String, 10, true, true),
        new JdeField("DV75TGCT", "DV75TGCT", JdeDataType.String, 2),
        new JdeField("DV75TSUN", "DV75TSUN", JdeDataType.String, 16),
        new JdeField("DV75TGFC", "DV75TGFC", JdeDataType.String, 4),
        new JdeField("DV75TFC2", "DV75TFC2", JdeDataType.String, 4),
        new JdeField("DV75TZTT", "DV75TZTT", JdeDataType.String, 6),
        new JdeField("DV75TDCU", "DV75TDCU", JdeDataType.String, 2),
        new JdeField("DV75TIBF", "DV75TIBF", JdeDataType.String, 2),
        new JdeField("DV75TFC3", "DV75TFC3", JdeDataType.String, 4),
        new JdeField("DV75TFCW", "DV75TFCW", JdeDataType.String, 2),
        new JdeField("DV75TSIT", "DV75TSIT", JdeDataType.String, 6),
        new JdeField("DV75TSTT", "DV75TSTT", JdeDataType.String, 6),
        new JdeField("DV75TCC4", "DV75TCC4", JdeDataType.String, 6),
        new JdeField("DV75TCC5", "DV75TCC5", JdeDataType.String, 6),
        new JdeField("DV75TCC6", "DV75TCC6", JdeDataType.String, 6),
        new JdeField("DVURC1", "DVURC1", JdeDataType.String, 6),
        new JdeField("DVURDT", "DVURDT", JdeDataType.Numeric),
        new JdeField("DVURAT", "DVURAT", JdeDataType.Numeric),
        new JdeField("DVURAB", "DVURAB", JdeDataType.Numeric),
        new JdeField("DVURRF", "DVURRF", JdeDataType.String, 30),
        new JdeField("DVUSER", "DVUSER", JdeDataType.String, 20),
        new JdeField("DVPID", "DVPID", JdeDataType.String, 20),
        new JdeField("DVJOBN", "DVJOBN", JdeDataType.String, 20),
        new JdeField("DVUPMJ", "DVUPMJ", JdeDataType.Numeric),
        new JdeField("DVTDAY", "DVTDAY", JdeDataType.Numeric),
        new JdeField("DV75TEGMD", "DV75TEGMD", JdeDataType.String, 60),
        new JdeField("DVYFUTDT", "DVYFUTDT", JdeDataType.Numeric),
        new JdeField("DVFFU4", "DVFFU4", JdeDataType.Numeric),
        new JdeField("DVFUT3", "DVFUT3", JdeDataType.String, 60),
        new JdeField("DVX2", "DVX2", JdeDataType.String, 2),
        new JdeField("DVFUTCH1", "DVFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T009_0", "Primary Key on DVAN8, DVCO", new[] { "DVAN8", "DVCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T009_2", "Index on DV75TSUN", new[] { "DV75TSUN" })
    };
}
