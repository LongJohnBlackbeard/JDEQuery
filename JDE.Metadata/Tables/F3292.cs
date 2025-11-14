using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3292 - .
/// </summary>
public class F3292 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KUKIT.
        /// </summary>
        public const string KUKIT = "KUKIT";

        /// <summary>
        /// KULITM.
        /// </summary>
        public const string KULITM = "KULITM";

        /// <summary>
        /// KUAITM.
        /// </summary>
        public const string KUAITM = "KUAITM";

        /// <summary>
        /// KUMCU.
        /// </summary>
        public const string KUMCU = "KUMCU";

        /// <summary>
        /// KUATO#.
        /// </summary>
        public const string KUATO_ = "KUATO#";

        /// <summary>
        /// KUATOS.
        /// </summary>
        public const string KUATOS = "KUATOS";

        /// <summary>
        /// KUEFFF.
        /// </summary>
        public const string KUEFFF = "KUEFFF";

        /// <summary>
        /// KUEFFT.
        /// </summary>
        public const string KUEFFT = "KUEFFT";

        /// <summary>
        /// KUPEL.
        /// </summary>
        public const string KUPEL = "KUPEL";

        /// <summary>
        /// KUPSIN.
        /// </summary>
        public const string KUPSIN = "KUPSIN";

        /// <summary>
        /// KUEMCU.
        /// </summary>
        public const string KUEMCU = "KUEMCU";

        /// <summary>
        /// KUVALR.
        /// </summary>
        public const string KUVALR = "KUVALR";

        /// <summary>
        /// KUATIV.
        /// </summary>
        public const string KUATIV = "KUATIV";

        /// <summary>
        /// KUCEL.
        /// </summary>
        public const string KUCEL = "KUCEL";

        /// <summary>
        /// KUAO.
        /// </summary>
        public const string KUAO = "KUAO";

        /// <summary>
        /// KUAO5B.
        /// </summary>
        public const string KUAO5B = "KUAO5B";

        /// <summary>
        /// KUAO5E.
        /// </summary>
        public const string KUAO5E = "KUAO5E";

        /// <summary>
        /// KUATRQ.
        /// </summary>
        public const string KUATRQ = "KUATRQ";

        /// <summary>
        /// KUCSMG.
        /// </summary>
        public const string KUCSMG = "KUCSMG";

        /// <summary>
        /// KUEPGM.
        /// </summary>
        public const string KUEPGM = "KUEPGM";

        /// <summary>
        /// KUURCD.
        /// </summary>
        public const string KUURCD = "KUURCD";

        /// <summary>
        /// KUURDT.
        /// </summary>
        public const string KUURDT = "KUURDT";

        /// <summary>
        /// KUURAT.
        /// </summary>
        public const string KUURAT = "KUURAT";

        /// <summary>
        /// KUURAB.
        /// </summary>
        public const string KUURAB = "KUURAB";

        /// <summary>
        /// KUURRF.
        /// </summary>
        public const string KUURRF = "KUURRF";

        /// <summary>
        /// KUPID.
        /// </summary>
        public const string KUPID = "KUPID";

        /// <summary>
        /// KUJOBN.
        /// </summary>
        public const string KUJOBN = "KUJOBN";

        /// <summary>
        /// KUUSER.
        /// </summary>
        public const string KUUSER = "KUUSER";

        /// <summary>
        /// KUUPMJ.
        /// </summary>
        public const string KUUPMJ = "KUUPMJ";

        /// <summary>
        /// KUTDAY.
        /// </summary>
        public const string KUTDAY = "KUTDAY";

        /// <summary>
        /// KUCIALEFT.
        /// </summary>
        public const string KUCIALEFT = "KUCIALEFT";

        /// <summary>
        /// KUITMRIGHT.
        /// </summary>
        public const string KUITMRIGHT = "KUITMRIGHT";

        /// <summary>
        /// KUMCURIGHT.
        /// </summary>
        public const string KUMCURIGHT = "KUMCURIGHT";

        /// <summary>
        /// KUCIARIGHT.
        /// </summary>
        public const string KUCIARIGHT = "KUCIARIGHT";
    }

    /// <inheritdoc />
    public override string TableName => "F3292";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KUKIT", "KUKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("KULITM", "KULITM", JdeDataType.String, 50),
        new JdeField("KUAITM", "KUAITM", JdeDataType.String, 50),
        new JdeField("KUMCU", "KUMCU", JdeDataType.String, 24, true, true),
        new JdeField("KUATO#", "KUATO#", JdeDataType.Numeric, null, true, true),
        new JdeField("KUATOS", "KUATOS", JdeDataType.Numeric, null, true, true),
        new JdeField("KUEFFF", "KUEFFF", JdeDataType.Numeric),
        new JdeField("KUEFFT", "KUEFFT", JdeDataType.Numeric),
        new JdeField("KUPEL", "KUPEL", JdeDataType.Numeric),
        new JdeField("KUPSIN", "KUPSIN", JdeDataType.Numeric),
        new JdeField("KUEMCU", "KUEMCU", JdeDataType.String, 24),
        new JdeField("KUVALR", "KUVALR", JdeDataType.String, 4),
        new JdeField("KUATIV", "KUATIV", JdeDataType.String, 80),
        new JdeField("KUCEL", "KUCEL", JdeDataType.Numeric),
        new JdeField("KUAO", "KUAO", JdeDataType.String, 2),
        new JdeField("KUAO5B", "KUAO5B", JdeDataType.String, 8),
        new JdeField("KUAO5E", "KUAO5E", JdeDataType.String, 8),
        new JdeField("KUATRQ", "KUATRQ", JdeDataType.String, 2),
        new JdeField("KUCSMG", "KUCSMG", JdeDataType.String, 2),
        new JdeField("KUEPGM", "KUEPGM", JdeDataType.String, 20),
        new JdeField("KUURCD", "KUURCD", JdeDataType.String, 4),
        new JdeField("KUURDT", "KUURDT", JdeDataType.Numeric),
        new JdeField("KUURAT", "KUURAT", JdeDataType.Numeric),
        new JdeField("KUURAB", "KUURAB", JdeDataType.Numeric),
        new JdeField("KUURRF", "KUURRF", JdeDataType.String, 30),
        new JdeField("KUPID", "KUPID", JdeDataType.String, 20),
        new JdeField("KUJOBN", "KUJOBN", JdeDataType.String, 20),
        new JdeField("KUUSER", "KUUSER", JdeDataType.String, 20),
        new JdeField("KUUPMJ", "KUUPMJ", JdeDataType.Numeric),
        new JdeField("KUTDAY", "KUTDAY", JdeDataType.Numeric),
        new JdeField("KUCIALEFT", "KUCIALEFT", JdeDataType.String, 20),
        new JdeField("KUITMRIGHT", "KUITMRIGHT", JdeDataType.Numeric),
        new JdeField("KUMCURIGHT", "KUMCURIGHT", JdeDataType.String, 24),
        new JdeField("KUCIARIGHT", "KUCIARIGHT", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3292_0", "Primary Key on KUKIT, KUMCU, KUATO#, KUATOS", new[] { "KUKIT", "KUMCU", "KUATO#", "KUATOS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3292_2", "Index on KUKIT, KUMCU, KUPEL", new[] { "KUKIT", "KUMCU", "KUPEL" }),
        new JdeIndex("F3292_3", "Index on KUKIT, KUPEL, KUMCU", new[] { "KUKIT", "KUPEL", "KUMCU" }),
        new JdeIndex("F3292_4", "Index on KUKIT, KUMCU", new[] { "KUKIT", "KUMCU" }),
        new JdeIndex("F3292_5", "Index on KUPSIN, KUPEL, KUEMCU", new[] { "KUPSIN", "KUPEL", "KUEMCU" }),
        new JdeIndex("F3292_6", "Index on KUMCU, KUKIT, SYS_NC00035$, SYS_NC00036$", new[] { "KUMCU", "KUKIT", "SYS_NC00035$", "SYS_NC00036$" }),
        new JdeIndex("F3292_7", "Index on KUPSIN, KUEMCU, KUPEL", new[] { "KUPSIN", "KUEMCU", "KUPEL" })
    };
}
