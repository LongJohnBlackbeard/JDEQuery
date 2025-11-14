using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4312 - .
/// </summary>
public class F74U4312 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCKCOO.
        /// </summary>
        public const string SCKCOO = "SCKCOO";

        /// <summary>
        /// SCDOCO.
        /// </summary>
        public const string SCDOCO = "SCDOCO";

        /// <summary>
        /// SCDCTO.
        /// </summary>
        public const string SCDCTO = "SCDCTO";

        /// <summary>
        /// SCSFXO.
        /// </summary>
        public const string SCSFXO = "SCSFXO";

        /// <summary>
        /// SC74UMCD.
        /// </summary>
        public const string SC74UMCD = "SC74UMCD";

        /// <summary>
        /// SC74UPOC.
        /// </summary>
        public const string SC74UPOC = "SC74UPOC";

        /// <summary>
        /// SC74UAC.
        /// </summary>
        public const string SC74UAC = "SC74UAC";

        /// <summary>
        /// SC74UCC.
        /// </summary>
        public const string SC74UCC = "SC74UCC";

        /// <summary>
        /// SC74UVRB.
        /// </summary>
        public const string SC74UVRB = "SC74UVRB";

        /// <summary>
        /// SC74UAR.
        /// </summary>
        public const string SC74UAR = "SC74UAR";

        /// <summary>
        /// SC74UOC.
        /// </summary>
        public const string SC74UOC = "SC74UOC";

        /// <summary>
        /// SC74UFCD.
        /// </summary>
        public const string SC74UFCD = "SC74UFCD";

        /// <summary>
        /// SC74UPCC8.
        /// </summary>
        public const string SC74UPCC8 = "SC74UPCC8";

        /// <summary>
        /// SC74UPCC9.
        /// </summary>
        public const string SC74UPCC9 = "SC74UPCC9";

        /// <summary>
        /// SC74UPCC10.
        /// </summary>
        public const string SC74UPCC10 = "SC74UPCC10";

        /// <summary>
        /// SCURAT.
        /// </summary>
        public const string SCURAT = "SCURAT";

        /// <summary>
        /// SCURCD.
        /// </summary>
        public const string SCURCD = "SCURCD";

        /// <summary>
        /// SCURDT.
        /// </summary>
        public const string SCURDT = "SCURDT";

        /// <summary>
        /// SCURAB.
        /// </summary>
        public const string SCURAB = "SCURAB";

        /// <summary>
        /// SCURRF.
        /// </summary>
        public const string SCURRF = "SCURRF";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCGLC.
        /// </summary>
        public const string SCGLC = "SCGLC";

        /// <summary>
        /// SC74USURV.
        /// </summary>
        public const string SC74USURV = "SC74USURV";

        /// <summary>
        /// SCAN81.
        /// </summary>
        public const string SCAN81 = "SCAN81";

        /// <summary>
        /// SCAN82.
        /// </summary>
        public const string SCAN82 = "SCAN82";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4312";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCKCOO", "SCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SCDOCO", "SCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SCDCTO", "SCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SCSFXO", "SCSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SC74UMCD", "SC74UMCD", JdeDataType.Numeric),
        new JdeField("SC74UPOC", "SC74UPOC", JdeDataType.String, 2),
        new JdeField("SC74UAC", "SC74UAC", JdeDataType.String, 2),
        new JdeField("SC74UCC", "SC74UCC", JdeDataType.String, 2),
        new JdeField("SC74UVRB", "SC74UVRB", JdeDataType.String, 2),
        new JdeField("SC74UAR", "SC74UAR", JdeDataType.String, 2),
        new JdeField("SC74UOC", "SC74UOC", JdeDataType.String, 2),
        new JdeField("SC74UFCD", "SC74UFCD", JdeDataType.Numeric),
        new JdeField("SC74UPCC8", "SC74UPCC8", JdeDataType.String, 6),
        new JdeField("SC74UPCC9", "SC74UPCC9", JdeDataType.String, 6),
        new JdeField("SC74UPCC10", "SC74UPCC10", JdeDataType.String, 6),
        new JdeField("SCURAT", "SCURAT", JdeDataType.Numeric),
        new JdeField("SCURCD", "SCURCD", JdeDataType.String, 4),
        new JdeField("SCURDT", "SCURDT", JdeDataType.Numeric),
        new JdeField("SCURAB", "SCURAB", JdeDataType.Numeric),
        new JdeField("SCURRF", "SCURRF", JdeDataType.String, 30),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCGLC", "SCGLC", JdeDataType.String, 8),
        new JdeField("SC74USURV", "SC74USURV", JdeDataType.Numeric),
        new JdeField("SCAN81", "SCAN81", JdeDataType.Numeric),
        new JdeField("SCAN82", "SCAN82", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4312_0", "Primary Key on SCKCOO, SCDOCO, SCDCTO, SCSFXO", new[] { "SCKCOO", "SCDOCO", "SCDCTO", "SCSFXO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U4312_2", "Index on SC74UFCD", new[] { "SC74UFCD" })
    };
}
