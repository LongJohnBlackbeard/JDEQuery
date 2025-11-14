using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q92 - .
/// </summary>
public class F43Q92 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIUITM.
        /// </summary>
        public const string AIUITM = "AIUITM";

        /// <summary>
        /// AIUOM1.
        /// </summary>
        public const string AIUOM1 = "AIUOM1";

        /// <summary>
        /// AISTKT.
        /// </summary>
        public const string AISTKT = "AISTKT";

        /// <summary>
        /// AILOCN.
        /// </summary>
        public const string AILOCN = "AILOCN";

        /// <summary>
        /// AICLEV.
        /// </summary>
        public const string AICLEV = "AICLEV";

        /// <summary>
        /// AIPPLV.
        /// </summary>
        public const string AIPPLV = "AIPPLV";

        /// <summary>
        /// AIEVNU.
        /// </summary>
        public const string AIEVNU = "AIEVNU";

        /// <summary>
        /// AIDCTO.
        /// </summary>
        public const string AIDCTO = "AIDCTO";

        /// <summary>
        /// AIKCOO.
        /// </summary>
        public const string AIKCOO = "AIKCOO";

        /// <summary>
        /// AIEVLN.
        /// </summary>
        public const string AIEVLN = "AIEVLN";

        /// <summary>
        /// AIURCD.
        /// </summary>
        public const string AIURCD = "AIURCD";

        /// <summary>
        /// AIURDT.
        /// </summary>
        public const string AIURDT = "AIURDT";

        /// <summary>
        /// AIURAT.
        /// </summary>
        public const string AIURAT = "AIURAT";

        /// <summary>
        /// AIURAB.
        /// </summary>
        public const string AIURAB = "AIURAB";

        /// <summary>
        /// AIURRF.
        /// </summary>
        public const string AIURRF = "AIURRF";

        /// <summary>
        /// AITORG.
        /// </summary>
        public const string AITORG = "AITORG";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AITDAY.
        /// </summary>
        public const string AITDAY = "AITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q92";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIUITM", "AIUITM", JdeDataType.String, 52, true, true),
        new JdeField("AIUOM1", "AIUOM1", JdeDataType.String, 4),
        new JdeField("AISTKT", "AISTKT", JdeDataType.String, 2),
        new JdeField("AILOCN", "AILOCN", JdeDataType.String, 40),
        new JdeField("AICLEV", "AICLEV", JdeDataType.String, 2),
        new JdeField("AIPPLV", "AIPPLV", JdeDataType.String, 2),
        new JdeField("AIEVNU", "AIEVNU", JdeDataType.Numeric),
        new JdeField("AIDCTO", "AIDCTO", JdeDataType.String, 4),
        new JdeField("AIKCOO", "AIKCOO", JdeDataType.String, 10),
        new JdeField("AIEVLN", "AIEVLN", JdeDataType.Numeric),
        new JdeField("AIURCD", "AIURCD", JdeDataType.String, 4),
        new JdeField("AIURDT", "AIURDT", JdeDataType.Numeric),
        new JdeField("AIURAT", "AIURAT", JdeDataType.Numeric),
        new JdeField("AIURAB", "AIURAB", JdeDataType.Numeric),
        new JdeField("AIURRF", "AIURRF", JdeDataType.String, 30),
        new JdeField("AITORG", "AITORG", JdeDataType.String, 20),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AITDAY", "AITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q92_0", "Primary Key on AIUITM", new[] { "AIUITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q92_3", "Index on AIEVNU, AIDCTO, AIKCOO, AIEVLN", new[] { "AIEVNU", "AIDCTO", "AIKCOO", "AIEVLN" })
    };
}
