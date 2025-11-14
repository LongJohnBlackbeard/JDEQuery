using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T311 - .
/// </summary>
public class F49T311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPDOCO.
        /// </summary>
        public const string TPDOCO = "TPDOCO";

        /// <summary>
        /// TPDCTO.
        /// </summary>
        public const string TPDCTO = "TPDCTO";

        /// <summary>
        /// TPKCOO.
        /// </summary>
        public const string TPKCOO = "TPKCOO";

        /// <summary>
        /// TPSFXO.
        /// </summary>
        public const string TPSFXO = "TPSFXO";

        /// <summary>
        /// TPLNID.
        /// </summary>
        public const string TPLNID = "TPLNID";

        /// <summary>
        /// TPOTSTATE2.
        /// </summary>
        public const string TPOTSTATE2 = "TPOTSTATE2";

        /// <summary>
        /// TPOTEXTFLG.
        /// </summary>
        public const string TPOTEXTFLG = "TPOTEXTFLG";

        /// <summary>
        /// TPOTTRNCOD.
        /// </summary>
        public const string TPOTTRNCOD = "TPOTTRNCOD";

        /// <summary>
        /// TPURCD.
        /// </summary>
        public const string TPURCD = "TPURCD";

        /// <summary>
        /// TPURDT.
        /// </summary>
        public const string TPURDT = "TPURDT";

        /// <summary>
        /// TPURRF.
        /// </summary>
        public const string TPURRF = "TPURRF";

        /// <summary>
        /// TPURAT.
        /// </summary>
        public const string TPURAT = "TPURAT";

        /// <summary>
        /// TPURAB.
        /// </summary>
        public const string TPURAB = "TPURAB";

        /// <summary>
        /// TPTORG.
        /// </summary>
        public const string TPTORG = "TPTORG";

        /// <summary>
        /// TPUSER.
        /// </summary>
        public const string TPUSER = "TPUSER";

        /// <summary>
        /// TPUUPMJ.
        /// </summary>
        public const string TPUUPMJ = "TPUUPMJ";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";

        /// <summary>
        /// TPJOBN.
        /// </summary>
        public const string TPJOBN = "TPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F49T311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPDOCO", "TPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TPDCTO", "TPDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TPKCOO", "TPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TPSFXO", "TPSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TPLNID", "TPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TPOTSTATE2", "TPOTSTATE2", JdeDataType.String, 4),
        new JdeField("TPOTEXTFLG", "TPOTEXTFLG", JdeDataType.String, 2),
        new JdeField("TPOTTRNCOD", "TPOTTRNCOD", JdeDataType.String, 4),
        new JdeField("TPURCD", "TPURCD", JdeDataType.String, 4),
        new JdeField("TPURDT", "TPURDT", JdeDataType.Numeric),
        new JdeField("TPURRF", "TPURRF", JdeDataType.String, 30),
        new JdeField("TPURAT", "TPURAT", JdeDataType.Numeric),
        new JdeField("TPURAB", "TPURAB", JdeDataType.Numeric),
        new JdeField("TPTORG", "TPTORG", JdeDataType.String, 20),
        new JdeField("TPUSER", "TPUSER", JdeDataType.String, 20),
        new JdeField("TPUUPMJ", "TPUUPMJ", JdeDataType.Date),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T311_0", "Primary Key on TPDOCO, TPDCTO, TPKCOO, TPSFXO, TPLNID", new[] { "TPDOCO", "TPDCTO", "TPKCOO", "TPSFXO", "TPLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
