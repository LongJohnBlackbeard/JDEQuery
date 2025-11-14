using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4316 - .
/// </summary>
public class F74U4316 : JdeTable
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
        /// SCLNID.
        /// </summary>
        public const string SCLNID = "SCLNID";

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
        /// SCAG.
        /// </summary>
        public const string SCAG = "SCAG";

        /// <summary>
        /// SCACR.
        /// </summary>
        public const string SCACR = "SCACR";

        /// <summary>
        /// SCRTNG.
        /// </summary>
        public const string SCRTNG = "SCRTNG";

        /// <summary>
        /// SCFTNG.
        /// </summary>
        public const string SCFTNG = "SCFTNG";

        /// <summary>
        /// SC74UMCDA.
        /// </summary>
        public const string SC74UMCDA = "SC74UMCDA";

        /// <summary>
        /// SC74UFMCDA.
        /// </summary>
        public const string SC74UFMCDA = "SC74UFMCDA";

        /// <summary>
        /// SC74URCA.
        /// </summary>
        public const string SC74URCA = "SC74URCA";

        /// <summary>
        /// SC74UTOLA.
        /// </summary>
        public const string SC74UTOLA = "SC74UTOLA";

        /// <summary>
        /// SC74UTOLP.
        /// </summary>
        public const string SC74UTOLP = "SC74UTOLP";

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

        /// <summary>
        /// SC74UCLPF.
        /// </summary>
        public const string SC74UCLPF = "SC74UCLPF";

        /// <summary>
        /// SCAID.
        /// </summary>
        public const string SCAID = "SCAID";

        /// <summary>
        /// SCANI.
        /// </summary>
        public const string SCANI = "SCANI";

        /// <summary>
        /// SCSBL.
        /// </summary>
        public const string SCSBL = "SCSBL";

        /// <summary>
        /// SC74UMLMS.
        /// </summary>
        public const string SC74UMLMS = "SC74UMLMS";

        /// <summary>
        /// SCSBLT.
        /// </summary>
        public const string SCSBLT = "SCSBLT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4316";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCKCOO", "SCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SCDOCO", "SCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SCDCTO", "SCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SCSFXO", "SCSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SCLNID", "SCLNID", JdeDataType.Numeric, null, true, true),
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
        new JdeField("SCAG", "SCAG", JdeDataType.Numeric),
        new JdeField("SCACR", "SCACR", JdeDataType.Numeric),
        new JdeField("SCRTNG", "SCRTNG", JdeDataType.Numeric),
        new JdeField("SCFTNG", "SCFTNG", JdeDataType.Numeric),
        new JdeField("SC74UMCDA", "SC74UMCDA", JdeDataType.Numeric),
        new JdeField("SC74UFMCDA", "SC74UFMCDA", JdeDataType.Numeric),
        new JdeField("SC74URCA", "SC74URCA", JdeDataType.Numeric),
        new JdeField("SC74UTOLA", "SC74UTOLA", JdeDataType.Numeric),
        new JdeField("SC74UTOLP", "SC74UTOLP", JdeDataType.Numeric),
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
        new JdeField("SCAN82", "SCAN82", JdeDataType.Numeric),
        new JdeField("SC74UCLPF", "SC74UCLPF", JdeDataType.String, 2),
        new JdeField("SCAID", "SCAID", JdeDataType.String, 16),
        new JdeField("SCANI", "SCANI", JdeDataType.String, 58),
        new JdeField("SCSBL", "SCSBL", JdeDataType.String, 16),
        new JdeField("SC74UMLMS", "SC74UMLMS", JdeDataType.String, 2),
        new JdeField("SCSBLT", "SCSBLT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4316_0", "Primary Key on SCKCOO, SCDOCO, SCDCTO, SCSFXO, SCLNID", new[] { "SCKCOO", "SCDOCO", "SCDCTO", "SCSFXO", "SCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U4316_2", "Index on SC74UFCD", new[] { "SC74UFCD" })
    };
}
