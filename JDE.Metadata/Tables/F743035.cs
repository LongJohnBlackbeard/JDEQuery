using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F743035 - .
/// </summary>
public class F743035 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTKCO.
        /// </summary>
        public const string DTKCO = "DTKCO";

        /// <summary>
        /// DTDCT.
        /// </summary>
        public const string DTDCT = "DTDCT";

        /// <summary>
        /// DTDOC.
        /// </summary>
        public const string DTDOC = "DTDOC";

        /// <summary>
        /// DTSEQ.
        /// </summary>
        public const string DTSEQ = "DTSEQ";

        /// <summary>
        /// DTLNID.
        /// </summary>
        public const string DTLNID = "DTLNID";

        /// <summary>
        /// DTK74TAXC.
        /// </summary>
        public const string DTK74TAXC = "DTK74TAXC";

        /// <summary>
        /// DTTXA1.
        /// </summary>
        public const string DTTXA1 = "DTTXA1";

        /// <summary>
        /// DTCRCD.
        /// </summary>
        public const string DTCRCD = "DTCRCD";

        /// <summary>
        /// DTTXR1.
        /// </summary>
        public const string DTTXR1 = "DTTXR1";

        /// <summary>
        /// DTAA.
        /// </summary>
        public const string DTAA = "DTAA";

        /// <summary>
        /// DTATXA.
        /// </summary>
        public const string DTATXA = "DTATXA";

        /// <summary>
        /// DTATXN.
        /// </summary>
        public const string DTATXN = "DTATXN";

        /// <summary>
        /// DTK74PN.
        /// </summary>
        public const string DTK74PN = "DTK74PN";

        /// <summary>
        /// DTDS40.
        /// </summary>
        public const string DTDS40 = "DTDS40";
    }

    /// <inheritdoc />
    public override string TableName => "F743035";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTKCO", "DTKCO", JdeDataType.String, 10, true, true),
        new JdeField("DTDCT", "DTDCT", JdeDataType.String, 4, true, true),
        new JdeField("DTDOC", "DTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DTSEQ", "DTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DTLNID", "DTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTK74TAXC", "DTK74TAXC", JdeDataType.String, 20),
        new JdeField("DTTXA1", "DTTXA1", JdeDataType.String, 20),
        new JdeField("DTCRCD", "DTCRCD", JdeDataType.String, 6),
        new JdeField("DTTXR1", "DTTXR1", JdeDataType.Numeric),
        new JdeField("DTAA", "DTAA", JdeDataType.Numeric),
        new JdeField("DTATXA", "DTATXA", JdeDataType.Numeric),
        new JdeField("DTATXN", "DTATXN", JdeDataType.Numeric),
        new JdeField("DTK74PN", "DTK74PN", JdeDataType.Numeric),
        new JdeField("DTDS40", "DTDS40", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F743035_0", "Primary Key on DTKCO, DTDCT, DTDOC, DTSEQ, DTLNID", new[] { "DTKCO", "DTDCT", "DTDOC", "DTSEQ", "DTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
