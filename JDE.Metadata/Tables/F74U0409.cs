using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0409 - .
/// </summary>
public class F74U0409 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMDOCO.
        /// </summary>
        public const string LMDOCO = "LMDOCO";

        /// <summary>
        /// LMDCTO.
        /// </summary>
        public const string LMDCTO = "LMDCTO";

        /// <summary>
        /// LMKCOO.
        /// </summary>
        public const string LMKCOO = "LMKCOO";

        /// <summary>
        /// LMSFXO.
        /// </summary>
        public const string LMSFXO = "LMSFXO";

        /// <summary>
        /// LMLNID.
        /// </summary>
        public const string LMLNID = "LMLNID";

        /// <summary>
        /// LMEV01.
        /// </summary>
        public const string LMEV01 = "LMEV01";

        /// <summary>
        /// LM74UMLN.
        /// </summary>
        public const string LM74UMLN = "LM74UMLN";

        /// <summary>
        /// LMUKAPNM.
        /// </summary>
        public const string LMUKAPNM = "LMUKAPNM";

        /// <summary>
        /// LMAA.
        /// </summary>
        public const string LMAA = "LMAA";

        /// <summary>
        /// LM74UMCDR.
        /// </summary>
        public const string LM74UMCDR = "LM74UMCDR";

        /// <summary>
        /// LM74UMCDA.
        /// </summary>
        public const string LM74UMCDA = "LM74UMCDA";

        /// <summary>
        /// LM74UPCC4.
        /// </summary>
        public const string LM74UPCC4 = "LM74UPCC4";

        /// <summary>
        /// LM74UPCC5.
        /// </summary>
        public const string LM74UPCC5 = "LM74UPCC5";

        /// <summary>
        /// LM74UPCC6.
        /// </summary>
        public const string LM74UPCC6 = "LM74UPCC6";

        /// <summary>
        /// LMURAT.
        /// </summary>
        public const string LMURAT = "LMURAT";

        /// <summary>
        /// LMURCD.
        /// </summary>
        public const string LMURCD = "LMURCD";

        /// <summary>
        /// LMURDT.
        /// </summary>
        public const string LMURDT = "LMURDT";

        /// <summary>
        /// LMURAB.
        /// </summary>
        public const string LMURAB = "LMURAB";

        /// <summary>
        /// LMURRF.
        /// </summary>
        public const string LMURRF = "LMURRF";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMUPMT.
        /// </summary>
        public const string LMUPMT = "LMUPMT";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0409";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMDOCO", "LMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LMDCTO", "LMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LMKCOO", "LMKCOO", JdeDataType.String, 10, true, true),
        new JdeField("LMSFXO", "LMSFXO", JdeDataType.String, 6, true, true),
        new JdeField("LMLNID", "LMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LMEV01", "LMEV01", JdeDataType.String, 2, true, true),
        new JdeField("LM74UMLN", "LM74UMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("LMUKAPNM", "LMUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("LMAA", "LMAA", JdeDataType.Numeric),
        new JdeField("LM74UMCDR", "LM74UMCDR", JdeDataType.Numeric),
        new JdeField("LM74UMCDA", "LM74UMCDA", JdeDataType.Numeric),
        new JdeField("LM74UPCC4", "LM74UPCC4", JdeDataType.String, 20),
        new JdeField("LM74UPCC5", "LM74UPCC5", JdeDataType.Numeric),
        new JdeField("LM74UPCC6", "LM74UPCC6", JdeDataType.String, 6),
        new JdeField("LMURAT", "LMURAT", JdeDataType.Numeric),
        new JdeField("LMURCD", "LMURCD", JdeDataType.String, 4),
        new JdeField("LMURDT", "LMURDT", JdeDataType.Numeric),
        new JdeField("LMURAB", "LMURAB", JdeDataType.Numeric),
        new JdeField("LMURRF", "LMURRF", JdeDataType.String, 30),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMUPMT", "LMUPMT", JdeDataType.Numeric),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0409_0", "Primary Key on LMDOCO, LMDCTO, LMKCOO, LMSFXO, LMLNID, LMEV01, LMUKAPNM, LM74UMLN", new[] { "LMDOCO", "LMDCTO", "LMKCOO", "LMSFXO", "LMLNID", "LMEV01", "LMUKAPNM", "LM74UMLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0409_2", "Index on LMDOCO, LMDCTO, LMKCOO, LMEV01, LMUKAPNM", new[] { "LMDOCO", "LMDCTO", "LMKCOO", "LMEV01", "LMUKAPNM" }),
        new JdeIndex("F74U0409_3", "Index on LMDOCO, LMDCTO, LMKCOO, LMSFXO, LMLNID, LMEV01, LMUKAPNM", new[] { "LMDOCO", "LMDCTO", "LMKCOO", "LMSFXO", "LMLNID", "LMEV01", "LMUKAPNM" })
    };
}
