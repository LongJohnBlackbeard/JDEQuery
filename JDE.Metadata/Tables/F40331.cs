using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40331 - .
/// </summary>
public class F40331 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OEAN8.
        /// </summary>
        public const string OEAN8 = "OEAN8";

        /// <summary>
        /// OECS31.
        /// </summary>
        public const string OECS31 = "OECS31";

        /// <summary>
        /// OEITM.
        /// </summary>
        public const string OEITM = "OEITM";

        /// <summary>
        /// OEIT81.
        /// </summary>
        public const string OEIT81 = "OEIT81";

        /// <summary>
        /// OEEFTJ.
        /// </summary>
        public const string OEEFTJ = "OEEFTJ";

        /// <summary>
        /// OEEXDJ.
        /// </summary>
        public const string OEEXDJ = "OEEXDJ";

        /// <summary>
        /// OEMNQ.
        /// </summary>
        public const string OEMNQ = "OEMNQ";

        /// <summary>
        /// OEMXQ.
        /// </summary>
        public const string OEMXQ = "OEMXQ";

        /// <summary>
        /// OEUOM.
        /// </summary>
        public const string OEUOM = "OEUOM";

        /// <summary>
        /// OETXID.
        /// </summary>
        public const string OETXID = "OETXID";

        /// <summary>
        /// OESTPR.
        /// </summary>
        public const string OESTPR = "OESTPR";

        /// <summary>
        /// OEOSEQ.
        /// </summary>
        public const string OEOSEQ = "OEOSEQ";

        /// <summary>
        /// OEMOT.
        /// </summary>
        public const string OEMOT = "OEMOT";

        /// <summary>
        /// OEOPEQ.
        /// </summary>
        public const string OEOPEQ = "OEOPEQ";

        /// <summary>
        /// OEDLLV.
        /// </summary>
        public const string OEDLLV = "OEDLLV";

        /// <summary>
        /// OEURCD.
        /// </summary>
        public const string OEURCD = "OEURCD";

        /// <summary>
        /// OEURDT.
        /// </summary>
        public const string OEURDT = "OEURDT";

        /// <summary>
        /// OEURAT.
        /// </summary>
        public const string OEURAT = "OEURAT";

        /// <summary>
        /// OEURAB.
        /// </summary>
        public const string OEURAB = "OEURAB";

        /// <summary>
        /// OEURRF.
        /// </summary>
        public const string OEURRF = "OEURRF";

        /// <summary>
        /// OEUSER.
        /// </summary>
        public const string OEUSER = "OEUSER";

        /// <summary>
        /// OEPID.
        /// </summary>
        public const string OEPID = "OEPID";

        /// <summary>
        /// OEJOBN.
        /// </summary>
        public const string OEJOBN = "OEJOBN";

        /// <summary>
        /// OEUPMJ.
        /// </summary>
        public const string OEUPMJ = "OEUPMJ";

        /// <summary>
        /// OETDAY.
        /// </summary>
        public const string OETDAY = "OETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40331";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OEAN8", "OEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OECS31", "OECS31", JdeDataType.String, 16, true, true),
        new JdeField("OEITM", "OEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OEIT81", "OEIT81", JdeDataType.String, 16, true, true),
        new JdeField("OEEFTJ", "OEEFTJ", JdeDataType.Numeric),
        new JdeField("OEEXDJ", "OEEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("OEMNQ", "OEMNQ", JdeDataType.Numeric),
        new JdeField("OEMXQ", "OEMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OEUOM", "OEUOM", JdeDataType.String, 4, true, true),
        new JdeField("OETXID", "OETXID", JdeDataType.Numeric),
        new JdeField("OESTPR", "OESTPR", JdeDataType.String, 2),
        new JdeField("OEOSEQ", "OEOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OEMOT", "OEMOT", JdeDataType.String, 6),
        new JdeField("OEOPEQ", "OEOPEQ", JdeDataType.String, 20),
        new JdeField("OEDLLV", "OEDLLV", JdeDataType.String, 2),
        new JdeField("OEURCD", "OEURCD", JdeDataType.String, 4),
        new JdeField("OEURDT", "OEURDT", JdeDataType.Numeric),
        new JdeField("OEURAT", "OEURAT", JdeDataType.Numeric),
        new JdeField("OEURAB", "OEURAB", JdeDataType.Numeric),
        new JdeField("OEURRF", "OEURRF", JdeDataType.String, 30),
        new JdeField("OEUSER", "OEUSER", JdeDataType.String, 20),
        new JdeField("OEPID", "OEPID", JdeDataType.String, 20),
        new JdeField("OEJOBN", "OEJOBN", JdeDataType.String, 20),
        new JdeField("OEUPMJ", "OEUPMJ", JdeDataType.Numeric),
        new JdeField("OETDAY", "OETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40331_0", "Primary Key on OEAN8, OECS31, OEITM, OEIT81, OEEXDJ, OEUOM, OEMXQ, OEOSEQ", new[] { "OEAN8", "OECS31", "OEITM", "OEIT81", "OEEXDJ", "OEUOM", "OEMXQ", "OEOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
