using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K41 - .
/// </summary>
public class FF31K41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCFSCID.
        /// </summary>
        public const string PCFSCID = "PCFSCID";

        /// <summary>
        /// PCDFKPC.
        /// </summary>
        public const string PCDFKPC = "PCDFKPC";

        /// <summary>
        /// PCDFPSEQ.
        /// </summary>
        public const string PCDFPSEQ = "PCDFPSEQ";

        /// <summary>
        /// PCDFSLOC.
        /// </summary>
        public const string PCDFSLOC = "PCDFSLOC";

        /// <summary>
        /// PCDFSMCU.
        /// </summary>
        public const string PCDFSMCU = "PCDFSMCU";

        /// <summary>
        /// PCDFCLOC.
        /// </summary>
        public const string PCDFCLOC = "PCDFCLOC";

        /// <summary>
        /// PCFDCMCU.
        /// </summary>
        public const string PCFDCMCU = "PCFDCMCU";

        /// <summary>
        /// PCKANFAS.
        /// </summary>
        public const string PCKANFAS = "PCKANFAS";

        /// <summary>
        /// PCREPHRS.
        /// </summary>
        public const string PCREPHRS = "PCREPHRS";

        /// <summary>
        /// PCPKUOM.
        /// </summary>
        public const string PCPKUOM = "PCPKUOM";

        /// <summary>
        /// PCKANPRL.
        /// </summary>
        public const string PCKANPRL = "PCKANPRL";

        /// <summary>
        /// PCDFREPT.
        /// </summary>
        public const string PCDFREPT = "PCDFREPT";

        /// <summary>
        /// PCSUPN.
        /// </summary>
        public const string PCSUPN = "PCSUPN";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCTORG.
        /// </summary>
        public const string PCTORG = "PCTORG";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCUUPMJ.
        /// </summary>
        public const string PCUUPMJ = "PCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCFSCID", "PCFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDFKPC", "PCDFKPC", JdeDataType.String, 60, true, true),
        new JdeField("PCDFPSEQ", "PCDFPSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDFSLOC", "PCDFSLOC", JdeDataType.String, 40),
        new JdeField("PCDFSMCU", "PCDFSMCU", JdeDataType.String, 24),
        new JdeField("PCDFCLOC", "PCDFCLOC", JdeDataType.String, 40),
        new JdeField("PCFDCMCU", "PCFDCMCU", JdeDataType.String, 24),
        new JdeField("PCKANFAS", "PCKANFAS", JdeDataType.Numeric),
        new JdeField("PCREPHRS", "PCREPHRS", JdeDataType.Numeric),
        new JdeField("PCPKUOM", "PCPKUOM", JdeDataType.String, 4),
        new JdeField("PCKANPRL", "PCKANPRL", JdeDataType.String, 2),
        new JdeField("PCDFREPT", "PCDFREPT", JdeDataType.String, 2),
        new JdeField("PCSUPN", "PCSUPN", JdeDataType.Numeric),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCTORG", "PCTORG", JdeDataType.String, 20),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCUUPMJ", "PCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K41_0", "Primary Key on PCFSCID, PCDFKPC, PCDFPSEQ", new[] { "PCFSCID", "PCDFKPC", "PCDFPSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31K41_2", "Index on PCFSCID, PCFDCMCU, PCDFCLOC", new[] { "PCFSCID", "PCFDCMCU", "PCDFCLOC" }),
        new JdeIndex("FF31K41_3", "Index on PCFSCID, PCDFSMCU, PCDFSLOC", new[] { "PCFSCID", "PCDFSMCU", "PCDFSLOC" }),
        new JdeIndex("FF31K41_4", "Index on PCFSCID, PCDFKPC", new[] { "PCFSCID", "PCDFKPC" })
    };
}
