using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0011 - .
/// </summary>
public class F0011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICICUT.
        /// </summary>
        public const string ICICUT = "ICICUT";

        /// <summary>
        /// ICICU.
        /// </summary>
        public const string ICICU = "ICICU";

        /// <summary>
        /// ICIST.
        /// </summary>
        public const string ICIST = "ICIST";

        /// <summary>
        /// ICIAPP.
        /// </summary>
        public const string ICIAPP = "ICIAPP";

        /// <summary>
        /// ICAICU.
        /// </summary>
        public const string ICAICU = "ICAICU";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICDICJ.
        /// </summary>
        public const string ICDICJ = "ICDICJ";

        /// <summary>
        /// ICNDO.
        /// </summary>
        public const string ICNDO = "ICNDO";

        /// <summary>
        /// ICBAL.
        /// </summary>
        public const string ICBAL = "ICBAL";

        /// <summary>
        /// ICBALJ.
        /// </summary>
        public const string ICBALJ = "ICBALJ";

        /// <summary>
        /// ICAME.
        /// </summary>
        public const string ICAME = "ICAME";

        /// <summary>
        /// ICDOCN.
        /// </summary>
        public const string ICDOCN = "ICDOCN";

        /// <summary>
        /// ICAUSR.
        /// </summary>
        public const string ICAUSR = "ICAUSR";

        /// <summary>
        /// ICPOB.
        /// </summary>
        public const string ICPOB = "ICPOB";

        /// <summary>
        /// ICIBOI.
        /// </summary>
        public const string ICIBOI = "ICIBOI";

        /// <summary>
        /// ICAIPT.
        /// </summary>
        public const string ICAIPT = "ICAIPT";

        /// <summary>
        /// ICOFFP.
        /// </summary>
        public const string ICOFFP = "ICOFFP";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICUPMJ.
        /// </summary>
        public const string ICUPMJ = "ICUPMJ";

        /// <summary>
        /// ICUPMT.
        /// </summary>
        public const string ICUPMT = "ICUPMT";

        /// <summary>
        /// ICDRSP.
        /// </summary>
        public const string ICDRSP = "ICDRSP";

        /// <summary>
        /// IC52PP.
        /// </summary>
        public const string IC52PP = "IC52PP";

        /// <summary>
        /// ICCBP.
        /// </summary>
        public const string ICCBP = "ICCBP";
    }

    /// <inheritdoc />
    public override string TableName => "F0011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICICUT", "ICICUT", JdeDataType.String, 4, true, true),
        new JdeField("ICICU", "ICICU", JdeDataType.Numeric, null, true, true),
        new JdeField("ICIST", "ICIST", JdeDataType.String, 2),
        new JdeField("ICIAPP", "ICIAPP", JdeDataType.String, 2),
        new JdeField("ICAICU", "ICAICU", JdeDataType.Numeric),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICDICJ", "ICDICJ", JdeDataType.Numeric),
        new JdeField("ICNDO", "ICNDO", JdeDataType.Numeric),
        new JdeField("ICBAL", "ICBAL", JdeDataType.String, 2),
        new JdeField("ICBALJ", "ICBALJ", JdeDataType.String, 2),
        new JdeField("ICAME", "ICAME", JdeDataType.Numeric),
        new JdeField("ICDOCN", "ICDOCN", JdeDataType.Numeric),
        new JdeField("ICAUSR", "ICAUSR", JdeDataType.String, 20),
        new JdeField("ICPOB", "ICPOB", JdeDataType.String, 2),
        new JdeField("ICIBOI", "ICIBOI", JdeDataType.String, 2),
        new JdeField("ICAIPT", "ICAIPT", JdeDataType.Numeric),
        new JdeField("ICOFFP", "ICOFFP", JdeDataType.String, 2),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICUPMJ", "ICUPMJ", JdeDataType.Numeric),
        new JdeField("ICUPMT", "ICUPMT", JdeDataType.Numeric),
        new JdeField("ICDRSP", "ICDRSP", JdeDataType.String, 2),
        new JdeField("IC52PP", "IC52PP", JdeDataType.String, 2),
        new JdeField("ICCBP", "ICCBP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0011_0", "Primary Key on ICICUT, ICICU", new[] { "ICICUT", "ICICU" }, isUnique: true, isPrimaryKey: true)
    };
}
