using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4780 - .
/// </summary>
public class F4780 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AXANS8.
        /// </summary>
        public const string AXANS8 = "AXANS8";

        /// <summary>
        /// AXXRTS.
        /// </summary>
        public const string AXXRTS = "AXXRTS";

        /// <summary>
        /// AXAN8.
        /// </summary>
        public const string AXAN8 = "AXAN8";

        /// <summary>
        /// AXEXDJ.
        /// </summary>
        public const string AXEXDJ = "AXEXDJ";

        /// <summary>
        /// AXEFTJ.
        /// </summary>
        public const string AXEFTJ = "AXEFTJ";

        /// <summary>
        /// AXEXRA.
        /// </summary>
        public const string AXEXRA = "AXEXRA";

        /// <summary>
        /// AXALPH.
        /// </summary>
        public const string AXALPH = "AXALPH";

        /// <summary>
        /// AXDC.
        /// </summary>
        public const string AXDC = "AXDC";

        /// <summary>
        /// AXAX01.
        /// </summary>
        public const string AXAX01 = "AXAX01";

        /// <summary>
        /// AXAX02.
        /// </summary>
        public const string AXAX02 = "AXAX02";

        /// <summary>
        /// AXAX03.
        /// </summary>
        public const string AXAX03 = "AXAX03";

        /// <summary>
        /// AXAX04.
        /// </summary>
        public const string AXAX04 = "AXAX04";

        /// <summary>
        /// AXAX05.
        /// </summary>
        public const string AXAX05 = "AXAX05";

        /// <summary>
        /// AXURCD.
        /// </summary>
        public const string AXURCD = "AXURCD";

        /// <summary>
        /// AXURDT.
        /// </summary>
        public const string AXURDT = "AXURDT";

        /// <summary>
        /// AXURAT.
        /// </summary>
        public const string AXURAT = "AXURAT";

        /// <summary>
        /// AXURAB.
        /// </summary>
        public const string AXURAB = "AXURAB";

        /// <summary>
        /// AXURRF.
        /// </summary>
        public const string AXURRF = "AXURRF";

        /// <summary>
        /// AXUSER.
        /// </summary>
        public const string AXUSER = "AXUSER";

        /// <summary>
        /// AXPID.
        /// </summary>
        public const string AXPID = "AXPID";

        /// <summary>
        /// AXJOBN.
        /// </summary>
        public const string AXJOBN = "AXJOBN";

        /// <summary>
        /// AXUPMJ.
        /// </summary>
        public const string AXUPMJ = "AXUPMJ";

        /// <summary>
        /// AXTDAY.
        /// </summary>
        public const string AXTDAY = "AXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4780";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AXANS8", "AXANS8", JdeDataType.Numeric, null, true, true),
        new JdeField("AXXRTS", "AXXRTS", JdeDataType.String, 4, true, true),
        new JdeField("AXAN8", "AXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AXEXDJ", "AXEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("AXEFTJ", "AXEFTJ", JdeDataType.Numeric),
        new JdeField("AXEXRA", "AXEXRA", JdeDataType.String, 60),
        new JdeField("AXALPH", "AXALPH", JdeDataType.String, 80),
        new JdeField("AXDC", "AXDC", JdeDataType.String, 80),
        new JdeField("AXAX01", "AXAX01", JdeDataType.String, 6),
        new JdeField("AXAX02", "AXAX02", JdeDataType.String, 6),
        new JdeField("AXAX03", "AXAX03", JdeDataType.String, 6),
        new JdeField("AXAX04", "AXAX04", JdeDataType.String, 6),
        new JdeField("AXAX05", "AXAX05", JdeDataType.String, 6),
        new JdeField("AXURCD", "AXURCD", JdeDataType.String, 4),
        new JdeField("AXURDT", "AXURDT", JdeDataType.Numeric),
        new JdeField("AXURAT", "AXURAT", JdeDataType.Numeric),
        new JdeField("AXURAB", "AXURAB", JdeDataType.Numeric),
        new JdeField("AXURRF", "AXURRF", JdeDataType.String, 30),
        new JdeField("AXUSER", "AXUSER", JdeDataType.String, 20),
        new JdeField("AXPID", "AXPID", JdeDataType.String, 20),
        new JdeField("AXJOBN", "AXJOBN", JdeDataType.String, 20),
        new JdeField("AXUPMJ", "AXUPMJ", JdeDataType.Numeric),
        new JdeField("AXTDAY", "AXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4780_0", "Primary Key on AXANS8, AXXRTS, AXAN8, AXEXDJ", new[] { "AXANS8", "AXXRTS", "AXAN8", "AXEXDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
