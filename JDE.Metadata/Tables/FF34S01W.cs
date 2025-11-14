using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34S01W - .
/// </summary>
public class FF34S01W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDCCHN.
        /// </summary>
        public const string PDCCHN = "PDCCHN";

        /// <summary>
        /// PDDFINT.
        /// </summary>
        public const string PDDFINT = "PDDFINT";

        /// <summary>
        /// PDDFLNIDP.
        /// </summary>
        public const string PDDFLNIDP = "PDDFLNIDP";

        /// <summary>
        /// PDDFTYPEC.
        /// </summary>
        public const string PDDFTYPEC = "PDDFTYPEC";

        /// <summary>
        /// PDPLNID.
        /// </summary>
        public const string PDPLNID = "PDPLNID";

        /// <summary>
        /// PDDFDOCO.
        /// </summary>
        public const string PDDFDOCO = "PDDFDOCO";

        /// <summary>
        /// PDDCTO.
        /// </summary>
        public const string PDDCTO = "PDDCTO";

        /// <summary>
        /// PDDFKCOO.
        /// </summary>
        public const string PDDFKCOO = "PDDFKCOO";

        /// <summary>
        /// PDLNID.
        /// </summary>
        public const string PDLNID = "PDLNID";

        /// <summary>
        /// PDDFUORG.
        /// </summary>
        public const string PDDFUORG = "PDDFUORG";

        /// <summary>
        /// PDDFUOQT.
        /// </summary>
        public const string PDDFUOQT = "PDDFUOQT";

        /// <summary>
        /// PDUM.
        /// </summary>
        public const string PDUM = "PDUM";

        /// <summary>
        /// PDUPPDJ.
        /// </summary>
        public const string PDUPPDJ = "PDUPPDJ";

        /// <summary>
        /// PDDFPRIO.
        /// </summary>
        public const string PDDFPRIO = "PDDFPRIO";

        /// <summary>
        /// PDCUSN.
        /// </summary>
        public const string PDCUSN = "PDCUSN";

        /// <summary>
        /// PDDFITM.
        /// </summary>
        public const string PDDFITM = "PDDFITM";

        /// <summary>
        /// PDDFLITM.
        /// </summary>
        public const string PDDFLITM = "PDDFLITM";

        /// <summary>
        /// PDDFAITM.
        /// </summary>
        public const string PDDFAITM = "PDDFAITM";

        /// <summary>
        /// PDDFUITM.
        /// </summary>
        public const string PDDFUITM = "PDDFUITM";

        /// <summary>
        /// PDDSC1.
        /// </summary>
        public const string PDDSC1 = "PDDSC1";

        /// <summary>
        /// PDDFMCU.
        /// </summary>
        public const string PDDFMCU = "PDDFMCU";

        /// <summary>
        /// PDURSD.
        /// </summary>
        public const string PDURSD = "PDURSD";

        /// <summary>
        /// PDURCCD.
        /// </summary>
        public const string PDURCCD = "PDURCCD";

        /// <summary>
        /// PDDFTPCT.
        /// </summary>
        public const string PDDFTPCT = "PDDFTPCT";

        /// <summary>
        /// PDAPTS.
        /// </summary>
        public const string PDAPTS = "PDAPTS";

        /// <summary>
        /// PDEV07.
        /// </summary>
        public const string PDEV07 = "PDEV07";
    }

    /// <inheritdoc />
    public override string TableName => "FF34S01W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDCCHN", "PDCCHN", JdeDataType.String, 90, true, true),
        new JdeField("PDDFINT", "PDDFINT", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDFLNIDP", "PDDFLNIDP", JdeDataType.Numeric),
        new JdeField("PDDFTYPEC", "PDDFTYPEC", JdeDataType.String, 2),
        new JdeField("PDPLNID", "PDPLNID", JdeDataType.Numeric),
        new JdeField("PDDFDOCO", "PDDFDOCO", JdeDataType.Numeric),
        new JdeField("PDDCTO", "PDDCTO", JdeDataType.String, 4),
        new JdeField("PDDFKCOO", "PDDFKCOO", JdeDataType.String, 10),
        new JdeField("PDLNID", "PDLNID", JdeDataType.Numeric),
        new JdeField("PDDFUORG", "PDDFUORG", JdeDataType.Numeric),
        new JdeField("PDDFUOQT", "PDDFUOQT", JdeDataType.Numeric),
        new JdeField("PDUM", "PDUM", JdeDataType.String, 4),
        new JdeField("PDUPPDJ", "PDUPPDJ", JdeDataType.Date),
        new JdeField("PDDFPRIO", "PDDFPRIO", JdeDataType.String, 2),
        new JdeField("PDCUSN", "PDCUSN", JdeDataType.Numeric),
        new JdeField("PDDFITM", "PDDFITM", JdeDataType.Numeric),
        new JdeField("PDDFLITM", "PDDFLITM", JdeDataType.String, 50),
        new JdeField("PDDFAITM", "PDDFAITM", JdeDataType.String, 50),
        new JdeField("PDDFUITM", "PDDFUITM", JdeDataType.String, 52),
        new JdeField("PDDSC1", "PDDSC1", JdeDataType.String, 60),
        new JdeField("PDDFMCU", "PDDFMCU", JdeDataType.String, 24),
        new JdeField("PDURSD", "PDURSD", JdeDataType.Date),
        new JdeField("PDURCCD", "PDURCCD", JdeDataType.Date),
        new JdeField("PDDFTPCT", "PDDFTPCT", JdeDataType.Numeric),
        new JdeField("PDAPTS", "PDAPTS", JdeDataType.String, 2),
        new JdeField("PDEV07", "PDEV07", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34S01W_0", "Primary Key on PDCCHN, PDDFINT", new[] { "PDCCHN", "PDDFINT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF34S01W_2", "Index on PDDFTYPEC, PDURSD, PDURCCD, PDDFPRIO, PDCUSN, PDCCHN", new[] { "PDDFTYPEC", "PDURSD", "PDURCCD", "PDDFPRIO", "PDCUSN", "PDCCHN" }),
        new JdeIndex("FF34S01W_3", "Index on PDCCHN, PDEV07, PDDFDOCO, PDDCTO, PDDFKCOO, PDLNID", new[] { "PDCCHN", "PDEV07", "PDDFDOCO", "PDDCTO", "PDDFKCOO", "PDLNID" })
    };
}
