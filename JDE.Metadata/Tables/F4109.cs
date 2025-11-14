using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4109 - .
/// </summary>
public class F4109 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRLCRT.
        /// </summary>
        public const string LRLCRT = "LRLCRT";

        /// <summary>
        /// LRAN8.
        /// </summary>
        public const string LRAN8 = "LRAN8";

        /// <summary>
        /// LRMCU.
        /// </summary>
        public const string LRMCU = "LRMCU";

        /// <summary>
        /// LRLOCN.
        /// </summary>
        public const string LRLOCN = "LRLOCN";

        /// <summary>
        /// LRCLOCN.
        /// </summary>
        public const string LRCLOCN = "LRCLOCN";

        /// <summary>
        /// LRDSC1.
        /// </summary>
        public const string LRDSC1 = "LRDSC1";

        /// <summary>
        /// LREXDJ.
        /// </summary>
        public const string LREXDJ = "LREXDJ";

        /// <summary>
        /// LREFTJ.
        /// </summary>
        public const string LREFTJ = "LREFTJ";

        /// <summary>
        /// LRDMCT.
        /// </summary>
        public const string LRDMCT = "LRDMCT";

        /// <summary>
        /// LRDMCS.
        /// </summary>
        public const string LRDMCS = "LRDMCS";

        /// <summary>
        /// LRSEQ.
        /// </summary>
        public const string LRSEQ = "LRSEQ";

        /// <summary>
        /// LRALN.
        /// </summary>
        public const string LRALN = "LRALN";

        /// <summary>
        /// LRUSER.
        /// </summary>
        public const string LRUSER = "LRUSER";

        /// <summary>
        /// LRPID.
        /// </summary>
        public const string LRPID = "LRPID";

        /// <summary>
        /// LRJOBN.
        /// </summary>
        public const string LRJOBN = "LRJOBN";

        /// <summary>
        /// LRUPMJ.
        /// </summary>
        public const string LRUPMJ = "LRUPMJ";

        /// <summary>
        /// LRTDAY.
        /// </summary>
        public const string LRTDAY = "LRTDAY";

        /// <summary>
        /// LRFUCHAR40.
        /// </summary>
        public const string LRFUCHAR40 = "LRFUCHAR40";

        /// <summary>
        /// LRFUCHAR41.
        /// </summary>
        public const string LRFUCHAR41 = "LRFUCHAR41";

        /// <summary>
        /// LRFUCHAR42.
        /// </summary>
        public const string LRFUCHAR42 = "LRFUCHAR42";

        /// <summary>
        /// LRFUNUM40.
        /// </summary>
        public const string LRFUNUM40 = "LRFUNUM40";

        /// <summary>
        /// LRFUNUM41.
        /// </summary>
        public const string LRFUNUM41 = "LRFUNUM41";

        /// <summary>
        /// LRFUNUM42.
        /// </summary>
        public const string LRFUNUM42 = "LRFUNUM42";

        /// <summary>
        /// LRFUTSTR40.
        /// </summary>
        public const string LRFUTSTR40 = "LRFUTSTR40";

        /// <summary>
        /// LRFUTSTR41.
        /// </summary>
        public const string LRFUTSTR41 = "LRFUTSTR41";

        /// <summary>
        /// LRFUTSTR42.
        /// </summary>
        public const string LRFUTSTR42 = "LRFUTSTR42";

        /// <summary>
        /// LRFUDT40.
        /// </summary>
        public const string LRFUDT40 = "LRFUDT40";

        /// <summary>
        /// LRFUDT41.
        /// </summary>
        public const string LRFUDT41 = "LRFUDT41";

        /// <summary>
        /// LRFUDT42.
        /// </summary>
        public const string LRFUDT42 = "LRFUDT42";
    }

    /// <inheritdoc />
    public override string TableName => "F4109";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRLCRT", "LRLCRT", JdeDataType.String, 4, true, true),
        new JdeField("LRAN8", "LRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LRMCU", "LRMCU", JdeDataType.String, 24, true, true),
        new JdeField("LRLOCN", "LRLOCN", JdeDataType.String, 40),
        new JdeField("LRCLOCN", "LRCLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LRDSC1", "LRDSC1", JdeDataType.String, 60),
        new JdeField("LREXDJ", "LREXDJ", JdeDataType.Numeric),
        new JdeField("LREFTJ", "LREFTJ", JdeDataType.Numeric),
        new JdeField("LRDMCT", "LRDMCT", JdeDataType.String, 24),
        new JdeField("LRDMCS", "LRDMCS", JdeDataType.Numeric),
        new JdeField("LRSEQ", "LRSEQ", JdeDataType.Numeric),
        new JdeField("LRALN", "LRALN", JdeDataType.String, 60),
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20),
        new JdeField("LRPID", "LRPID", JdeDataType.String, 20),
        new JdeField("LRJOBN", "LRJOBN", JdeDataType.String, 20),
        new JdeField("LRUPMJ", "LRUPMJ", JdeDataType.Numeric),
        new JdeField("LRTDAY", "LRTDAY", JdeDataType.Numeric),
        new JdeField("LRFUCHAR40", "LRFUCHAR40", JdeDataType.String, 2),
        new JdeField("LRFUCHAR41", "LRFUCHAR41", JdeDataType.String, 2),
        new JdeField("LRFUCHAR42", "LRFUCHAR42", JdeDataType.String, 2),
        new JdeField("LRFUNUM40", "LRFUNUM40", JdeDataType.Numeric),
        new JdeField("LRFUNUM41", "LRFUNUM41", JdeDataType.Numeric),
        new JdeField("LRFUNUM42", "LRFUNUM42", JdeDataType.Numeric),
        new JdeField("LRFUTSTR40", "LRFUTSTR40", JdeDataType.String, 100),
        new JdeField("LRFUTSTR41", "LRFUTSTR41", JdeDataType.String, 100),
        new JdeField("LRFUTSTR42", "LRFUTSTR42", JdeDataType.String, 100),
        new JdeField("LRFUDT40", "LRFUDT40", JdeDataType.Numeric),
        new JdeField("LRFUDT41", "LRFUDT41", JdeDataType.Numeric),
        new JdeField("LRFUDT42", "LRFUDT42", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4109_0", "Primary Key on LRLCRT, LRAN8, LRMCU, LRCLOCN", new[] { "LRLCRT", "LRAN8", "LRMCU", "LRCLOCN" }, isUnique: true, isPrimaryKey: true)
    };
}
